import React, { useContext, useState, useEffect } from "react";
import { HostContext, IHost } from "../../../context/HostingContext";
import { CurrentUserContext } from "../../../context/CurrentUserContext";
import { useNavigate } from "react-router-dom";
import axios from "axios";
import Checkbox from "../../../components/shared/CheckBox/CheckBox";
import { IResponse } from "../../../types/types";
import { postAPIHandler, getAPIHandler } from "../../../api/apiHandler";
import { motion } from "framer-motion";

const FinalStep: React.FC = () => {
  const navigate = useNavigate();
  const { host, setHost } = useContext(HostContext);
  const { user } = useContext(CurrentUserContext);

  const [showButton, setShowButton] = useState(false);
  const [detectedObj, setDetectedObj] = useState<string[]>([]);

  const objects: Record<string, keyof IHost> = {
    Refrigerator: "isRefrigerator",
    TV: "isTv",
    Couch: "isCouch",
    Bed: "isBed",
    "Gas stove": "isGasStove",
    Blender: "isBlender",
    "Coffee maker": "isCoffeeMaker",
    "Microwave oven": "isMicrowave",
    "Mixing bowl": "isMixingBowl",
    "Washing machine": "isWashingMachine",
  };

  useEffect(() => {
    const detectObjects = async () => {
      const formData = new FormData();
    
      if (host?.images) {
        host.images.forEach((image) => {
          formData.append("images", image);
        });
      }
    
      let dataArray: string[] = [];
      await axios.post("http://localhost:5000/api/detect", formData).then((res) => {
        dataArray = JSON.parse(res.data.detected_objects);
      });

      setDetectedObj(dataArray);    
      const updatedHost: IHost = { ...host };

      dataArray.forEach((item) => {
        const propertyName = objects[item] as keyof IHost;
        if (propertyName) {
          //eslint-disable-next-line
          //@ts-ignore
          updatedHost[propertyName] = true;
        }
      });
    
      setShowButton(true);
      setHost(updatedHost);
    };

    detectObjects();
  }, []);
  
  const sendToAPI = async () => {
    const users = await getAPIHandler("/users");
    const res: IResponse = users.data as IResponse;
    const usersData = res.data as any;
  
    let userID = 0;
  
    for (let i = 0; i < usersData.length; i++) {
      if (usersData[i].firstName === user?.firstname) {
        userID = usersData[i].id;
      }
    }

    // All the objects from host context are not being sent to the API so that is why 
    // I am creating a new object with only the properties that I need
    const transformedHost = {
      ownerId: userID,
      name: host?.name,
      country: host?.country,
      city: host?.city,
      address: host?.address,
      latitude: host?.latitude,
      longtitude: host?.longitude,
      propertyType: host?.propertyType,
      bookingType: host?.bookingType,
      photographsPathList: host?.images?.map((image: any) => image.path),
      maxGuestCount: host?.maxGuestCount,
      bedroomCount: host?.bedroomCount,
      bathroomCount: host?.bathroomCount,
      bedCount: host?.bedCount,
      isRefrigerator: host?.isRefrigerator,
      isTv: host?.isTv,
      isCouch: host?.isCouch,
      isBed: host?.isBed,
      isGasStove: host?.isGasStove,
      isBlender: host?.isBlender,
      isCoffeeMaker: host?.isCoffeeMaker,
      isMicrowave: host?.isMicrowave,
      isMixingBowl: host?.isMixingBowl,
      isWashingMachine: host?.isWashingMachine,
      createdDate: new Date().toISOString(),    
      hasKitchen: host?.hasKitchen,
    };

    console.log(transformedHost);
    await postAPIHandler("/properties", transformedHost);

    const getProperty = await getAPIHandler("/properties");
    const res2: IResponse = getProperty.data as IResponse;

    // get the property id of the property that was just created
    const propertyID = res2.data[res2.data.length - 1].id as any;

    // Due to backend design we also need to add the property to publication
    const transformedPublication = {
      propertyID: propertyID,
      title: host?.name,
      description: host?.description,
      price: host?.price,
      isActive: true,
      createdDate: new Date().toISOString(),
    };
    
    console.log(transformedPublication);
    await postAPIHandler("/publications", transformedPublication);

    // redirect to home 
    navigate("/");
  };

  const renderCheckboxRows = (): JSX.Element => {
    const kitchenObjects: JSX.Element[] = [];
    const roomObjects: JSX.Element[] = [];
  
    Object.entries(objects).forEach(([itemName, propertyName]) => {
      const checkbox = (
        <div key={itemName} className="flex items-center">
          <Checkbox
            label={itemName}
            checked={detectedObj.includes(itemName)}
          />
        </div>
      );
  
      if (
        itemName === "Refrigerator" ||
        itemName === "Coffee maker" ||
        itemName === "Microwave oven" ||
        itemName === "Mixing bowl" ||
        itemName === "Gas stove"
      ) {
        kitchenObjects.push(checkbox);
      } else {
        roomObjects.push(checkbox);
      }
    });
  
    const kitchenRows: JSX.Element[] = [];
    let currentKitchenRow: JSX.Element[] = [];
  
    kitchenObjects.forEach((checkbox, index) => {
      currentKitchenRow.push(checkbox);
  
      if ((index + 1) % 4 === 0 || index === kitchenObjects.length - 1) {
        kitchenRows.push(
          <div key={kitchenRows.length} className="flex flex-row justify-between">
            {currentKitchenRow}
          </div>
        );
        currentKitchenRow = [];
      }
    });
  
    const roomRows: JSX.Element[] = [];
    let currentRoomRow: JSX.Element[] = [];
  
    roomObjects.forEach((checkbox, index) => {
      currentRoomRow.push(checkbox);
  
      if ((index + 1) % 4 === 0 || index === roomObjects.length - 1) {
        roomRows.push(
          <div key={roomRows.length} className="flex flex-row justify-between">
            {currentRoomRow}
          </div>
        );
        currentRoomRow = [];
      }
    });
  
    return (
      <>
        <div className="text-2xl font-bold mb-4">Kitchen</div>
        {kitchenRows}
        <div className="text-2xl font-bold mt-8 mb-4">Room</div>
        {roomRows}
      </>
    );
  };

  return (
    <motion.div
      className="flex"
      variants={{
        hidden: { opacity: 0 },
        visible: { opacity: 1, transition: { duration: 0.5 } },
      }}
      initial="hidden"
      animate="visible"
    >
        <div className="w-2/5 py-24 px-10">
            <motion.h1 className="text-4xl text-red-500 font-bold mb-4" initial={{ y: -50 }} animate={{ y: 0 }} transition={{ delay: 0.2 }}>
                Final Step
            </motion.h1>
            <motion.h1 className="text-5xl font-bold mb-8" initial={{ opacity: 0 }} animate={{ opacity: 1 }} transition={{ delay: 0.4 }}>
            <span className="text-purple-600">We have detected these objects </span> 
            <span className="text-black">
                in your house.
            </span>
            </motion.h1>
        </div>

      <div className="flex-1 p-10">
        {renderCheckboxRows()}
        <div className="flex justify-center items-center mt-2">
            {showButton &&
                <motion.button
                    className="bg-green-400 text-white font-bold py-4 px-16 rounded-xl"
                    onClick={sendToAPI}
                    whileHover={{ scale: 1.1 }}
                    whileTap={{ scale: 0.9 }}
                >
                    Finish
                </motion.button>
            }
        </div>
      </div>
    </motion.div>
  );
};

export default FinalStep;