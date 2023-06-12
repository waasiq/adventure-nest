# Adventure Nest

## 📝 About
AdventureNest is a web-based application designed to simplify the process of renting properties. It offers an intuitive platform for property owners to list their homes, upload photographs, and automate the object detection process for efficient property management. 

Additionally, when renting out their homes once a home owner uploads a photograph of their property, the application utilizes a deep learning module which automatically detects objects within the photograph and provides a list of items that the home owner contains within their home. 

## ⚙️ Tech Stack
AdventureNest utilizes the following technologies:

Frontend:
- [React](https://reactjs.org/)
- [TypeScript](https://www.typescriptlang.org/)
Backend:
- [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-5.0)
- [Flask](https://flask.palletsprojects.com/en/1.1.x/)
AI: 
- [PyTorch](https://pytorch.org/)
- [YOLOv5](https://github.com/ultralytics/yolov5)

## 🔍 Features
AdventureNest provides the following features:
1. Property Listing: Property owners can list their homes for rental purposes, providing essential information about the property.
2. Photo Upload: Users can upload photographs of their property through an intuitive interface.
3. Object Detection: The backend integrates the YOLO algorithm to automatically detect objects within the uploaded property photos.
4. User-Friendly Interface: AdventureNest offers a seamless and user-friendly interface, making it accessible to property owners without specialized information technology skills.

## 🔨 Installation
1. Clone the repository
```bash
git clone
```
2. Install dependencies on the frontend
```bash
npm install
```
3. Install dependencies on the flask backend
```bash
pip install -r requirements.txt
```
4. Install dependencies on the ASP.NET backend
```bash
dotnet restore
```
5. Run the frontend
```bash
npm start
```
6. Run the flask backend
```bash
python app.py
```
7. Run the ASP.NET backend
```bash
dotnet run
```

## 🔮 Future Plans
- [ ] Implement a payment system
- [ ] Implement review system
- [ ] Implement backend in Node.js (Backend is currently implemented in ASP.NET core due to limitations of tech stack by the university)
- [ ] Online hosting
- [ ] Implement a chat system
- [ ] Implement a notification system



