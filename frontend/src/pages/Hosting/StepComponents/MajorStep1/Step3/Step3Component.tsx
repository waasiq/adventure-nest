import React, { useContext } from "react";
import { BsHouse, BsBuilding } from "react-icons/bs";
import { GiTwoCoins } from "react-icons/gi";
import StepIcon from "./StepIcon";
import { HostContext } from "../../../../../context/HostingContext";
import { motion } from "framer-motion";

const Step3Component: React.FC = () => {
  const { host, setHost } = useContext(HostContext);

  const handleClick = (e: React.MouseEvent<HTMLDivElement, MouseEvent>) => {
    const target = e.target as HTMLDivElement;
    const finalVal = target.closest("[data-type]")?.getAttribute("data-type");

    setHost({
      ...host,
      placeType: finalVal as string,
      selectedPlaceIcon: finalVal as string,
    });
  };

  return (
    <React.Fragment>
      <motion.h1
        className="mt-4 flex flex-col text-rose-900 items-center text-3xl font-bold mb-4"
        initial={{ opacity: 0, y: -20 }}
        animate={{ opacity: 1, y: 0 }}
        transition={{ duration: 0.5 }}
      >
        What type of place will guests have?
      </motion.h1>
      <motion.div
        className="grid grid-cols-1 gap-4 px-96"
        initial={{ opacity: 0 }}
        animate={{ opacity: 1 }}
        transition={{ duration: 0.5, delay: 0.3 }}
      >
        <StepIcon name="Entire place" Icon={BsHouse} onClick={handleClick} />
        <StepIcon name="Private room" Icon={BsBuilding} onClick={handleClick} />
        <StepIcon name="Shared room" Icon={GiTwoCoins} onClick={handleClick} />
      </motion.div>
    </React.Fragment>
  );
};

export default Step3Component;
