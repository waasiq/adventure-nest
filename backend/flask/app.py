from flask import Flask, request
from flask_cors import CORS
from detect import detectObj
import json

app = Flask(__name__)
CORS(app)

@app.route("/")
def hello():
    return "Hello World!"

images = []

@app.route("/api/hosting", methods=["POST"])
def hosting():
    image_list = []
    images = request.files.getlist('images')
    print(images)
    for image in images:
        image_list.append(image)
        print(image.filename)
    images.extend(image_list)
    return "Success"

import os

@app.route("/api/detect", methods=["POST"])
def detect():
    image_files = request.files.getlist("images")
    image_paths = []
    for image_file in image_files:
        # Save the image temporarily to a file
        image_path = f"temp/{image_file.filename}"
        
        # Create the 'temp' directory if it doesn't exist
        os.makedirs("temp", exist_ok=True)
        
        image_file.save(image_path)
        image_paths.append(image_path)
   
    detected_objects = detectObj(image_paths)
    detected_obj_json = json.dumps(detected_objects)
    return {
        "detected_objects": detected_obj_json
    }

if __name__ == "__main__":
    app.run()
