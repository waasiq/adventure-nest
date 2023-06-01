import React, { useContext } from "react";
import { FaHome } from "react-icons/fa";
import { MdApartment, MdCabin, MdHolidayVillage } from "react-icons/md";
import { GiBarn } from "react-icons/gi";
import { BsFillTreeFill } from "react-icons/bs";
import { HostContext } from "../../../../../context/HostingContext";
import HomeIcon from "./HomeIcon";
import { motion } from "framer-motion";

const Step2Component: React.FC = () => {
  const { host, setHost } = useContext(HostContext);

  const handleClick = (e: React.MouseEvent<HTMLDivElement, MouseEvent>) => {
    const target = e.target as HTMLElement;

    // If the user clicks on SVG, we get undefined in order to fix this
    // we need to get the parent element of the SVG

    const finalVal = target.closest("[data-type]")?.getAttribute("data-type");

    setHost({
      ...host,
      homeType: finalVal as string,
      propertyType: finalVal as string,
      selectedHomeIcon: finalVal as string,
    });
  };

  return (
    <React.Fragment>
      <motion.div
        className="mt-20"
        initial={{ opacity: 0, y: -20 }}
        animate={{ opacity: 1, y: 0 }}
        transition={{ duration: 0.5 }}
      >
        <motion.h1
          className="text-3xl text-green-700 font-bold mb-16 text-center"
          initial={{ opacity: 0, y: -20 }}
          animate={{ opacity: 1, y: 0 }}
          transition={{ duration: 0.5, delay: 0.3 }}
        >
          Which best describes your home?
        </motion.h1>
        <motion.div
          className="grid grid-cols-3 gap-3 px-72"
          initial={{ opacity: 0 }}
          animate={{ opacity: 1 }}
          transition={{ duration: 0.5, delay: 0.6 }}
        >
          <HomeIcon name="Home" Icon={FaHome} onClick={handleClick} />
          <HomeIcon name="Apartment" Icon={MdApartment} onClick={handleClick} />
          <HomeIcon name="Barn" Icon={GiBarn} onClick={handleClick} />
          <HomeIcon name="Cabin" Icon={MdCabin} onClick={handleClick} />
          <HomeIcon
            name="Villa"
            Icon={MdHolidayVillage}
            onClick={handleClick}
          />
          <HomeIcon name="Treehouse" Icon={BsFillTreeFill} onClick={handleClick} />
        </motion.div>
        <motion.p
          className="text-gray-500 text-sm text-center mt-12"
          initial={{ opacity: 0 }}
          animate={{ opacity: 1 }}
          transition={{ duration: 0.5, delay: 0.9 }}
        >
          More property types coming soon
        </motion.p>
      </motion.div>
    </React.Fragment>
  );
};

export default Step2Component;
