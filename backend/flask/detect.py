import torch

def detectObj(image_paths):
    print("detectObj")
    label_dict = {
        0: " Blender",
        1: "Coffeemaker",
        2: "Microwave oven",
        3: "Gas stove",
        4: "Mixing bowl",
        5: "Couch",
        6: "Refrigerator",
        7: "Washing machine",
        8: "Bed",
        9: "Television"
    }

    weight_file = "E:\\Bitirme\\ai\\code\\kaggle\\yolov5l6-10class\\yolov5l6\\weights\\best.pt"
    model = torch.hub.load('ultralytics/yolov5', 'custom', path=weight_file)  # local model

    labels = []
    for image_path in image_paths:
        results = model(image_path)
        pred_labels = results.pred[0].cpu().numpy()[:, -1]

        for label in list(pred_labels):
            label = int(label)
            label = label_dict[label]
            labels.append(label)
    
    print(labels)
    return labels