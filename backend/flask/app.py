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

@app.route("/api/detect", methods=["GET"])
def detect():
    detected_objects = detectObj(images)
    detected_obj_json = json.dumps(detected_objects)
    return {
        "detected_objects": detected_obj_json
    }

if __name__ == "__main__":
    app.run()
