import React, { useState, useContext } from "react";
import getGeoCodeData from "../../../../utils/LocationSearch";
import LocalMap from "../../../../components/others/Map/LocalMap";
import { HostContext } from "../../../../context/HostingContext";
import { motion } from "framer-motion";

interface ICoord {
  latitude: number;
  longitude: number;
}

const Step4Component: React.FC = () => {
  const { host, setHost } = useContext(HostContext);

  const [address, setAddress] = useState<string>("");
  const [coord, setCoord] = useState<ICoord | null>(null);

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    const geoCodeData = await getGeoCodeData(address);
    const latt = parseFloat(geoCodeData?.latt as string);
    const longt = parseFloat(geoCodeData?.longt as string);

    setCoord({ latitude: latt, longitude: longt });
    setHost({
      ...host,
      address: address,
      latitude: latt,
      longitude: longt,
    });
  };

  return (
    <React.Fragment>
      <motion.h1
        className="mt-4 flex flex-col items-center text-green-900 text-3xl font-bold mb-4"
        initial={{ opacity: 0, y: -20 }}
        animate={{ opacity: 1, y: 0 }}
        transition={{ duration: 0.5 }}
      >
        Please type your address and give the price per night
      </motion.h1>
      <div className="flex flex-col lg:flex-row my-12">
        <div className="w-full lg:w-1/2 flex justify-center">
          <motion.div
            className="rounded-lg w-full md:w-96 h-96 flex flex-col justify-center items-center"
            initial={{ opacity: 0, x: -20 }}
            animate={{ opacity: 1, x: 0 }}
            transition={{ duration: 0.5, delay: 0.2 }}
          >
            <input
              type="text"
              className="w-full md:w-80 p-2  border-2 border-gray-300 rounded-lg mb-4"
              placeholder="Address"
              value={host?.address ? host?.address : address}
              onChange={(e) => setAddress(e.currentTarget.value)}
            />
            <motion.button
              className="py-2 px-10 bg-emerald-500 text-white rounded-lg"
              onClick={handleSubmit}
              whileHover={{ scale: 1.05 }}
              whileTap={{ scale: 0.95 }}
            >
              Submit
            </motion.button>

            <div className="flex flex-col items-center mt-4">
              <label className="text-gray-600 mb-2">Price per night in TL</label>
              <input
                type="number"
                className="w-24 p-2 border-2 border-gray-300 rounded-lg"
                value={host?.price ? host?.price : 0}
                onChange={(e) =>
                  setHost({ ...host, price: parseInt(e.currentTarget.value) })
                }
              />
            </div>
          </motion.div>
        </div>

        <div className="w-full lg:w-1/2 flex justify-center">
          <motion.div
            className="w-96 h-96"
            initial={{ opacity: 0, x: 20 }}
            animate={{ opacity: 1, x: 0 }}
            transition={{ duration: 0.5, delay: 0.2 }}
          >
            <LocalMap
              latitude={host?.latitude ? host?.latitude : coord?.latitude}
              longitude={host?.longitude ? host?.longitude : coord?.longitude}
            />
          </motion.div>
        </div>
      </div>
    </React.Fragment>
  );
};

export default Step4Component;
