import tkinter as tk
from tkinter import filedialog
from inference_sdk import InferenceHTTPClient

# Function to select an image file
def select_image():
    file_path = filedialog.askopenfilename(
        title="Select an Image",
        filetypes=[("Image Files", "*.jpg;*.jpeg;*.png;*.bmp;*.gif")]
    )
    
    if file_path:
        detect_objects(file_path)
    else:
        print("No image selected.")

# Function to perform object detection
def detect_objects(image_path):
    CLIENT = InferenceHTTPClient(
        api_url="https://detect.roboflow.com",
        api_key="OvKJWSOubLLAREpVScnp"
    )

    # Perform object detection with confidence filtering
    model_with_confidence = "food-ingredients-dataset/3?confidence=0.192"  # Adjust confidence threshold

    result = CLIENT.infer(image_path, model_id=model_with_confidence)

    # Extract detected object classes dynamically
    detected_classes = {pred['class'] for pred in result.get('predictions', [])}  # Remove duplicates
    class_output = ", ".join(detected_classes) if detected_classes else "No objects detected"

    # Print only the detected classes
    print(class_output)

# Open file picker and detect objects
select_image()
