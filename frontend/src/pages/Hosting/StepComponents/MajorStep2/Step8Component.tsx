import React, { useContext, useState, useEffect } from "react";
import { HostContext, IHost } from "../../../../context/HostingContext";
import { CurrentUserContext } from "../../../../context/CurrentUserContext";
import axios from "axios";
import { IResponse } from "../../../../types/types";
import { postAPIHandler, getAPIHandler } from "../../../../api/apiHandler";
import { motion } from "framer-motion";

const Step8Component: React.FC = () => {
  const { host, setHost } = useContext(HostContext);
  const { user } = useContext(CurrentUserContext);
  const [userData, setUserData] = useState({ name: "", country: "", city: "" });
  const [showButton, setShowButton] = useState(false);
  const [detectedObj, setDetectedObj] = useState<string[]>([]);

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
      console.log(dataArray);
    
      const mapping: Record<string, keyof IHost> = {
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
    
      const updatedHost: IHost = { ...host };

      dataArray.forEach((item) => {
        const propertyName = mapping[item] as keyof IHost;
        if (propertyName) {
          //eslint-disable-next-line
          //@ts-ignore
          updatedHost[propertyName] = true;
        }
      });
    
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
      name: userData.name,
      country: userData.country,
      city: userData.city,
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
    };

    console.log(transformedHost);
    const postRes = await postAPIHandler("/properties", transformedHost);
  };

  const handleInputChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    const { name, value } = e.target;
    setUserData((prevData) => ({ ...prevData, [name]: value }));

    if (userData.name && userData.country && userData.city) {
      setShowButton(true);
    }
  };

 const containerVariants = {
    hidden: { opacity: 0 },
    visible: { opacity: 1, transition: { duration: 0.5 } },
  };

  return (
    <motion.div
      className="flex"
      variants={containerVariants}
      initial="hidden"
      animate="visible"
    >
      <div className="w-2/5 p-16">
        <motion.h1 className="text-4xl font-bold mb-4" initial={{ y: -50 }} animate={{ y: 0 }} transition={{ delay: 0.2 }}>
          Final Step
        </motion.h1>
        <motion.h1 className="text-5xl font-bold mb-8" initial={{ opacity: 0 }} animate={{ opacity: 1 }} transition={{ delay: 0.4 }}>
          <span className="text-red-600">AI</span> is detecting the amenities in your house.
          <span className="text-yellow-400">
            Meanwhile, can you fill in this information?
          </span>
        </motion.h1>
      </div>
      <div className="flex-1 p-16">
        <p className="text-gray-600 text-xl mb-8">
          <label className="block mb-4">
            The name you would like to put on your listing:
            <input
              type="text"
              name="name"
              value={userData.name}
              onChange={handleInputChange}
              className="border border-gray-300 rounded px-3 py-2 mt-1 w-full"
            />
          </label>
          <label className="block mb-4">
            Country:
            <input
              type="text"
              name="country"
              value={userData.country}
              onChange={handleInputChange}
              className="border border-gray-300 rounded px-3 py-2 mt-1 w-full"
            />
          </label>
          <label className="block mb-4">
            City:
            <input
              type="text"
              name="city"
              value={userData.city}
              onChange={handleInputChange}
              className="border border-gray-300 rounded px-3 py-2 mt-1 w-full"
            />
          </label>
        </p>

        <p className="text-xl mb-4">The detected objects in your house are:</p>
        <ul>
          {detectedObj.map((object, index) => (
            <li key={index}>{object}</li>
          ))}
        </ul>

        <div className="flex justify-center">
          {showButton && (
            <motion.button
              onClick={sendToAPI}
              className="bg-emerald-500 hover:bg-emerald-700 text-white font-bold py-4 px-4 my-4 rounded-full"
              initial={{ scale: 0 }}
              animate={{ scale: 1 }}
              transition={{ delay: 0.6 }}
            >
              Finish booking
            </motion.button>
          )}
        </div>
      </div>
    </motion.div>
  );
};

export default Step8Component;