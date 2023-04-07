import torch

def detectObj(img_file):
    label_dict = {
        0:"Couch",
        1:"Refrigerator",
        2:"Washing machine",
        3:"Bed",
        4:"Television"
    }

    weight_file = "E:\\Bitirme\\ai\\code\\kaggle\\yolov5l6\\weights\\best.pt"

    #model = torch.hub.load('ultralytics/yolov5','yolov5m')
    model = torch.hub.load('ultralytics/yolov5', 'custom', path=weight_file)  # local model
    img = "C:\\Users\\waasi\\Downloads\\bed-pic.jpg"
    results = model(img)
    #results.show()

    #* Get labels
    pred_labels = results.pred[0].cpu().numpy()[:, -1]

    labels = []
    # # Print the predicted labels and bounding boxes
    for label in list(pred_labels):
        label = int(label)
        label = label_dict[label]
        labels.append(label)
        
    return labels