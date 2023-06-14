import React, { useContext, useState, useEffect } from "react";
import { HostContext } from "../../../../context/HostingContext";
import { motion } from "framer-motion";

const Step8Component: React.FC = () => {
  const { setHost } = useContext(HostContext);
  const [userData, setUserData] = useState({ name: "", country: "", city: "", description: "" });

  const handleInputChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    const { name, value } = e.target;
    setUserData((prevData) => ({ ...prevData, [name]: value }));
    setHost((prevHost) => ({ ...prevHost, [name]: value }));
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
      <div className="flex-1 py-20 px-4">
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
            A cheesy description: 
            <input
              type="text"
              name="description"
              value={userData.description}
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
      </div>
    </motion.div>
  );
};

export default Step8Component;