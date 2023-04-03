from flask import Flask, request
from flask_cors import CORS

app = Flask(__name__)
CORS(app)

@app.route("/")
def hello():
    return "Hello World!"

@app.route("/api/hosting", methods=["POST"])
def hosting():
    images = request.files.getlist('images')
    for image in images:
        print(image.filename)
        image.save(image.filename)
    return "Success"

if __name__ == "__main__":
    app.run()
