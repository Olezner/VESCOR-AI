Imports System.Net.Http
Imports System.Text
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Text.RegularExpressions

Public Class frmMain
    Public Property UserId As Integer
    Private isMenuVisible As Boolean = True
    Private WithEvents menuTransitionTimer As New Timer()

    ' Store the original colors for light mode
    Private originalBackColor As Color
    Private originalForeColor As Color
    Private originalControlColors As New Dictionary(Of Control, Tuple(Of Color, Color))

    ' Placeholder text for controls
    Private Const btnNewChatPlaceholder As String = "New Chat"

    ' OpenAI Client
    Private ReadOnly apiKey As String = "sk-proj-14eWcmiOzUwQSoadHrMJT3BlbkFJJgBjTx4gFjnnwFwgSTVH"

    Private Function GetUserInventory() As List(Of String)
        Dim connString As String = SQL_Connection.ConnectionString
        Dim inventory As New List(Of String)
        Dim query As String = "SELECT item_name FROM tblinventory WHERE USERID=@user_id"

        Using connection As New MySqlConnection(connString)
            Try
                connection.Open()
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@user_id", UserId)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    inventory.Add(reader("item_name").ToString().ToLower())
                End While

            Catch ex As MySqlException
                MessageBox.Show("Database error: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("General error: " & ex.Message)
            End Try
        End Using

        Return inventory
    End Function
    Private Sub LoadData()
        Try
            ' Load User's Inventory
            Dim inventory As List(Of String) = GetUserInventory()
            If inventory.Count > 0 Then
                Console.WriteLine("User Inventory Loaded:")
                For Each item As String In inventory
                    Console.WriteLine("- " & item)
                Next
            Else
                Console.WriteLine("No items in inventory.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pnlSideMenu.Width = 220
        pnlSubHeader.Width = 220
        pnlIngredients.Width = 220
        pnlBookmarks.Width = 220
        pnlCalorieTrack.Width = 220
        pnlLogout.Width = 22
        pnlSideMenu.Visible = True

        ' Configure transition timer
        menuTransitionTimer.Interval = 5

        Generating.Visible = False

        txtPrompt.Select()  ' Set initial placeholder text

        LoadData()
    End Sub

    Private Async Function GetResponseFromOpenAI(prompt As String, inventory As List(Of String)) As Task(Of (String, Integer)) 'API Response configuration
        Using client As New HttpClient()
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}")

            Dim inventoryList As String = String.Join(", ", inventory)
            Console.WriteLine("Inventory List: " & inventoryList)

            Dim requestData As New With {
                .model = "gpt-4",
                .messages = New Object() {
                    New With {
                        .role = "system",
                        .content = $"You are VescorAI, a Filipino cookbook AI. Include ingredient measurement and how many pieces. 
                                    Please provide the quantities of ingredients using standardized units. 
                                    Don't specify the type of cut. For recipe requests, compare the recipe ingredients 
                                    with the user's inventory and mark missing items with 'X'. Ingredients should be state in mL then (cups)
                                    Accomodate Calorie questions. Don't entertain profanities. Tell the cooking time of the dish.
                            

                                    [Recipe for:] {prompt}
                                    [Cooking time:]
                                    Inventory: {inventoryList}

                                    Response format:
                                    1. Recipe for [Dish Name]:
                                    [ingredient 1]
                                    Instructions:
                                    1. [Step 1]
                                    2. Unavailable Ingredients:
                                    X [ingredient 1]

                                    Calorie Counte per serving (200 grams): [Approximate Calorie]

                                    [Disclaimer: The calorie count may vary depending on factors.]

                                    Exclude Water from unavailable ingredients.
                                    Greet with 'Hi, I'm VescorAI. What dish should we cook today?' if needed.
                                    Ignore inventory if not a recipe request."
                        },
                    New With {
                        .role = "user",
                        .content = prompt
                    }
                },
                .temperature = 0.7,
                .max_tokens = 1000
            }

            Dim json As String = JsonConvert.SerializeObject(requestData)
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")

            Dim endpoint As String = "https://api.openai.com/v1/chat/completions" 'API endpoint
            Try
                Dim response As HttpResponseMessage = Await client.PostAsync(endpoint, content)

                If response.IsSuccessStatusCode Then
                    Dim responseString As String = Await response.Content.ReadAsStringAsync()
                    Dim responseData As JObject = JsonConvert.DeserializeObject(Of JObject)(responseString)
                    Dim choices As JArray = responseData("choices")
                    Dim text As String = choices(0)("message")("content").ToString().Trim()

                    ' Parse token usage
                    Dim tokenUsage As Integer = responseData("usage")("total_tokens").ToObject(Of Integer)()

                    ' Return both response text and token usage
                    Return (text, tokenUsage)
                Else
                    Dim errorMsg As String = Await response.Content.ReadAsStringAsync()
                    Return ($"Error: {response.StatusCode} - {response.ReasonPhrase}. Details: {errorMsg}", 0)
                End If
            Catch ex As HttpRequestException
                MessageBox.Show("You are not connected to the internet.")
                Return ("", 0)
            End Try
        End Using
    End Function
    Private Async Sub btnSend1_Click(sender As Object, e As EventArgs) Handles btnSend1.Click
        ' Show the PictureBox when the button is clicked
        Generating.Visible = True

        ' Change the text color to light gray if there is a value inside the textbox
        If Not String.IsNullOrEmpty(txtairesponse.Text) Then
            txtairesponse.ForeColor = Color.LightGray
        End If

        Dim prompt As String = txtPrompt.Text

        ' Log the user prompt
        Console.WriteLine("User Prompt: " & prompt)

        ' Log database inventory check start
        Console.WriteLine("Checking user's inventory in database...")

        ' Retrieve user inventory from database
        Dim userInventory = GetUserInventory()

        ' Log inventory retrieval completion
        Console.WriteLine("User inventory retrieved: " & String.Join(", ", userInventory))

        ' Log API request start
        Console.WriteLine("Sending request to OpenAI API...")

        ' Send the prompt and inventory to the API
        Dim responseTuple = Await GetResponseFromOpenAI(prompt, userInventory)
        Dim responseText As String = responseTuple.Item1
        Dim tokenUsage As Integer = responseTuple.Item2

        ' Log API response received
        Console.WriteLine("API Response received.")

        ' Log the actual response text
        Console.WriteLine("Response Text: " & responseText)

        ' Hide the PictureBox after the response is received
        Generating.Visible = False

        ' Revert the text color to black
        txtairesponse.ForeColor = Color.Black

        ' Display the response text
        txtairesponse.Text = responseText

        ' Clear the prompt textbox
        txtPrompt.Clear()

        ' Log token usage
        Console.WriteLine("Token Usage: " & tokenUsage)

        ' Save token usage to database with USERID
        SaveTokenUsageToDatabase(tokenUsage, Module1.CurrentUserID)

        ' Extract and save recipe details
        ExtractAndSaveRecipe(responseText, Module1.CurrentUserID)

        ' Log process completion
        Console.WriteLine("Process completed successfully.")
    End Sub
    Private Sub menuTransitionTimer_Tick(sender As Object, e As EventArgs) Handles menuTransitionTimer.Tick
        Dim stepSize As Integer = 10 ' Adjust for animation speed
        Dim menuExpandedWidth As Integer = 220
        Dim menuCollapsedWidth As Integer = 60

        If isMenuVisible Then
            ' Expanding the menu
            If pnlSideMenu.Width < menuExpandedWidth Then
                pnlSideMenu.Width += stepSize
                pnlSubHeader.Width += stepSize
                pnlIngredients.Width += stepSize
                pnlBookmarks.Width += stepSize
                pnlCalorieTrack.Width += stepSize
                pnlLogout.Width += stepSize

                ' Move and resize AI Response Panel
                pnlAiResponse.Left += stepSize
                pnlAiResponse.Width -= stepSize

                ' Move and resize txtPrompt
                txtPrompt.Left += stepSize
                txtPrompt.Width -= stepSize

            Else
                pnlSideMenu.Width = menuExpandedWidth
                menuTransitionTimer.Stop()
            End If
        Else
            ' Retracting the menu
            If pnlSideMenu.Width > menuCollapsedWidth Then
                pnlSideMenu.Width -= stepSize
                pnlSubHeader.Width -= stepSize
                pnlIngredients.Width -= stepSize
                pnlBookmarks.Width -= stepSize
                pnlCalorieTrack.Width -= stepSize
                pnlLogout.Width -= stepSize

                ' Move and resize AI Response Panel
                pnlAiResponse.Left -= stepSize
                pnlAiResponse.Width += stepSize

                ' Move and resize txtPrompt
                txtPrompt.Left -= stepSize
                txtPrompt.Width += stepSize

            Else
                pnlSideMenu.Width = menuCollapsedWidth
                menuTransitionTimer.Stop()
            End If
        End If

        ' Keep picGenerating centered in pnlAiResponse
        Generating.Left = pnlAiResponse.Left + (pnlAiResponse.Width - Generating.Width) \ 2
    End Sub
    Private Sub CenterElements()
        ' Center relative to pnlAiResponse or the main form
        Dim parentWidth As Integer = pnlAiResponse.Width ' Or use Me.ClientSize.Width for full form
        Dim centerX As Integer = parentWidth \ 2

        ' Center txtPrompt
        txtPrompt.Left = centerX - (txtPrompt.Width \ 2)

        ' Center btnSend1 below txtPrompt
        btnSend1.Left = centerX - (btnSend1.Width \ 2)
        btnSend1.Top = txtPrompt.Bottom + 10 ' Add spacing

        ' Center btnSaveRecipe below btnSend1
        btnSaveRecipe.Left = centerX - (btnSaveRecipe.Width \ 2)
        btnSaveRecipe.Top = btnSend1.Bottom + 10 ' Add spacing
    End Sub
    Private Sub SaveTokenUsageToDatabase(tokenUsage As Integer, userID As Integer)
        Dim connString As String = SQL_Connection.ConnectionString
        Using connection As New MySqlConnection(connString)
            Try
                connection.Open()
                Dim query As String = "INSERT INTO tblchatrequest (token_count, USERID, timelog) VALUES (@TokenCount, @UserID, @Timestamp)"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@TokenCount", tokenUsage)
                    command.Parameters.AddWithValue("@UserID", userID)
                    command.Parameters.AddWithValue("@Timestamp", DateTime.Now)
                    command.ExecuteNonQuery()
                End Using
            Catch ex As MySqlException
                ' Handle database error catcher
                MessageBox.Show("Database error: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub ExtractAndSaveRecipe(responseText As String, userID As Integer)
        Dim recipePattern As String = "Recipe for (.*?):\n(.*?)Instructions:\n(.*?)\nUnavailable Ingredients:\n(.*)"
        Dim match As Match = Regex.Match(responseText, recipePattern, RegexOptions.Singleline)

        If match.Success Then
            Dim dishName As String = match.Groups(1).Value.Trim()
            Dim ingredients As String = match.Groups(2).Value.Trim()
            Dim instructions As String = match.Groups(3).Value.Trim()
            Dim unavailableIngredients As String = match.Groups(4).Value.Trim()

            SaveRecipeToDatabase(userID, dishName, ingredients, instructions)
        End If
    End Sub
    Private Sub btnSavedRecipes(sender As Object, e As EventArgs)
        frmSavedRecipes.MdiParent = Me
        frmSavedRecipes.Dock = DockStyle.Fill
        frmSavedRecipes.Show()
        pnlHome.Visible = False
        frmMyIngredients.Visible = False
    End Sub
    Private Function RecipeExists(userId As Integer, dishName As String) As Boolean
        Dim connString As String = SQL_Connection.ConnectionString
        Dim query As String = "SELECT COUNT(*) FROM tblsavedrecipes WHERE USERID = @user_id AND DishName = @dishName"

        Using connection As New MySqlConnection(connString)
            Try
                connection.Open()
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@user_id", userId)
                cmd.Parameters.AddWithValue("@dishName", dishName)

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            Catch ex As MySqlException
                MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function
    Private Sub btnSaveRecipe_Click(sender As Object, e As EventArgs) Handles btnSaveRecipe.Click
        ' Hide lblSaved when a new recipe is prompted
        lblSaved.Visible = False

        ' Extract recipe details from the response text
        Dim responseText As String = txtairesponse.Text.Trim()
        If String.IsNullOrWhiteSpace(responseText) Then
            lblSaved.Text = "Invalid input. Try again."
            lblSaved.ForeColor = Color.Red
            lblSaved.Visible = True
            tmrLabel.Start()
            Return
        End If

        Dim dishName As String = "Unknown Dish"
        Dim ingredients As String = ""
        Dim instructions As String = ""
        Dim timelog As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") ' Save timestamp

        ' Identify and extract the recipe name
        Dim recipePattern As String = "Recipe for (.+?):"
        Dim match As System.Text.RegularExpressions.Match = System.Text.RegularExpressions.Regex.Match(responseText, recipePattern)
        If match.Success Then
            dishName = match.Groups(1).Value.Trim()
        End If

        ' Remove calorie count if present
        responseText = System.Text.RegularExpressions.Regex.Replace(responseText, "Calorie Counter per serving \(200 grams\):.*", "", System.Text.RegularExpressions.RegexOptions.IgnoreCase)

        ' Extract ingredients
        Dim ingredientsPattern As String = "Recipe for .*?:\s*(.*?)(?=\n\nInstructions:)"
        Dim ingredientsMatch As System.Text.RegularExpressions.Match = System.Text.RegularExpressions.Regex.Match(responseText, ingredientsPattern, System.Text.RegularExpressions.RegexOptions.Singleline)
        If ingredientsMatch.Success Then
            ingredients = ingredientsMatch.Groups(1).Value.Trim()
        Else
            ingredients = "No ingredients found."
        End If

        ' Extract instructions
        Dim instructionsPattern As String = "Instructions:\s*(.*?)(?=\n\n2\. Unavailable Ingredients:|$)"
        Dim instructionsMatch As System.Text.RegularExpressions.Match = System.Text.RegularExpressions.Regex.Match(responseText, instructionsPattern, System.Text.RegularExpressions.RegexOptions.Singleline)
        If instructionsMatch.Success Then
            instructions = instructionsMatch.Groups(1).Value.Trim()
        Else
            instructions = "No instructions found."
        End If

        ' Save the recipe to the database
        If SaveRecipeToDatabase(Module1.CurrentUserID, dishName, ingredients, instructions) Then
            lblSaved.Text = "Saved"
            lblSaved.ForeColor = Color.Green
            lblSaved.Visible = True
        Else
            lblSaved.Text = "Error saving recipe."
            lblSaved.ForeColor = Color.Red
            lblSaved.Visible = True
        End If

        ' Start Timer to hide lblSaved after 3 seconds
        tmrLabel.Start()
    End Sub
    Private Sub DisplayMessage(message As String, color As Color)
        lblSaved.Text = message
        lblSaved.ForeColor = color
        lblSaved.Visible = True
    End Sub
    Private Sub tmrLabel_Tick(sender As Object, e As EventArgs) Handles tmrLabel.Tick
        lblSaved.Visible = False
        tmrLabel.Stop() ' Stop the timer after hiding the label
    End Sub
    Private Function SaveRecipeToDatabase(userId As Integer, dishName As String, ingredients As String, instructions As String) As Boolean
        Dim connString As String = SQL_Connection.ConnectionString
        Dim query As String = "INSERT INTO tblsavedrecipes (USERID, DishName, Ingredients, Instructions) VALUES (@user_id, @dishName, @ingredients, @instructions)"

        Using connection As New MySqlConnection(connString)
            Try
                connection.Open()
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@user_id", userId)
                cmd.Parameters.AddWithValue("@dishName", dishName)
                cmd.Parameters.AddWithValue("@ingredients", ingredients)
                cmd.Parameters.AddWithValue("@instructions", instructions)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                Return rowsAffected > 0
            Catch ex As MySqlException
                MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim signInForm As New frmLogin

            signInForm.Show()

            Me.Close()
        End If
    End Sub
    Private Sub btnIngredients_Click(sender As Object, e As EventArgs) Handles btnIngredients.Click
        ' Close existing MDI children to avoid multiple open instances
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next

        ' Create a new instance of frmMyIngredients
        Dim ingredientsForm As New frmMyIngredients()
        ingredientsForm.UserId = UserId
        ingredientsForm.MdiParent = Me  ' Set MDI Parent
        ingredientsForm.Dock = DockStyle.Fill  ' Make it fill the window
        ingredientsForm.Show()

        ' Hide unnecessary panels
        pnlHome.Visible = False
        frmSavedRecipes.Visible = False
    End Sub
    Private Sub btnCalorieTrack_Click(sender As Object, e As EventArgs) Handles btnCalorieTrack.Click
        ' Close existing MDI children to avoid multiple open instances
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next

        ' Create a new instance of frmCalorieTracker
        Dim calorieTrackerForm As New frmCalorieTracker()
        calorieTrackerForm.MdiParent = Me  ' Set MDI Parent
        calorieTrackerForm.Dock = DockStyle.Fill  ' Make it fill the window
        calorieTrackerForm.Show()

        ' Hide unnecessary panels
        pnlHome.Visible = False
        frmSavedRecipes.Visible = False

    End Sub

    Private Sub btnSideMenu_Click(sender As Object, e As EventArgs) Handles btnSideMenu.Click
        ' Toggle the menu state
        isMenuVisible = Not isMenuVisible

        ' Set the interval for the animation timer
        menuTransitionTimer.Interval = 5

        ' Start the animation timer
        menuTransitionTimer.Start()

        ' Disable other timers to prevent conflicts
        tmrReduce.Enabled = False
        tmrIncrease.Enabled = False
    End Sub
    Private Sub tmrReduce_Tick(sender As Object, e As EventArgs) Handles tmrReduce.Tick
        If pnlSideMenu.Width <= 60 Then
            tmrReduce.Enabled = False
        Else
            Dim reduction As Integer = 20
            pnlSideMenu.Width -= reduction
            pnlSubHeader.Width -= reduction
            pnlIngredients.Width -= reduction
            pnlBookmarks.Width -= reduction
            pnlCalorieTrack.Width -= reduction
            pnlLogout.Width -= reduction

        End If
    End Sub
    Private Sub tmrIncrease_Tick(sender As Object, e As EventArgs) Handles tmrIncrease.Tick
        If pnlSideMenu.Width >= 220 Then
            tmrIncrease.Enabled = False
        Else
            Dim increase As Integer = 20
            pnlSideMenu.Width += increase
            pnlSubHeader.Width += increase
            pnlIngredients.Width += increase
            pnlBookmarks.Width += increase
            pnlCalorieTrack.Width += increase
            pnlLogout.Width += increase

        End If
    End Sub
    Private Sub btnBookmarked_Click(sender As Object, e As EventArgs) Handles btnBookmarked.Click
        ' Create a new instance of frmSavedRecipes
        Dim savedRecipesForm As New frmSavedRecipes()

        ' Set the MDI parent, dock style, and show the form
        savedRecipesForm.MdiParent = Me
        savedRecipesForm.Dock = DockStyle.Fill
        savedRecipesForm.Show()

        ' Hide other forms and panels if needed
        pnlHome.Visible = False
        frmMyIngredients.Visible = False
    End Sub
End Class