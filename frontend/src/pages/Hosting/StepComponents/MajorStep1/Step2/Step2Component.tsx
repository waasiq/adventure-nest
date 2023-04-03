import React, { useContext } from "react";
import { FaHome } from "react-icons/fa";
import { MdApartment, MdCabin, MdHolidayVillage } from "react-icons/md";
import { GiBarn } from "react-icons/gi";
import { BsFillTreeFill } from "react-icons/bs";
import { HostContext } from "../../../../../context/HostingContext";
import HomeIcon from "./HomeIcon";

const Step2Component: React.FC = () => {
  const { host, setHost } = useContext(HostContext);

  const handleClick = (e: React.MouseEvent<HTMLDivElement, MouseEvent>) => {
    const target = e.target as HTMLElement;

    // If the user clicks on SVG, we get undefined in order to fix this 
    // we need to get the parent element of the SVG

    const finalVal = target.closest('[data-type]')?.getAttribute('data-type');

    setHost({
      ...host,
      homeType: finalVal as string,
      selectedHomeIcon: finalVal as string,
    });
  }

  return (
    <React.Fragment>
      <div className="mt-20">
        <h1 className="text-3xl font-bold mb-16 text-center">
          Which best describes your home?
        </h1>
        <div className="grid grid-cols-3 gap-3 px-72">
          <HomeIcon
              name="House"
              Icon={FaHome}
              onClick={handleClick}
            />
            <HomeIcon
              name="Apartment"
              Icon={MdApartment}
              onClick={handleClick}
            />
            <HomeIcon
              name="Barn"
              Icon={GiBarn}
              onClick={handleClick}
            />
            <HomeIcon
              name="Cabin"
              Icon={MdCabin}
              onClick={handleClick}
            />
            <HomeIcon
              name="Villa"
              Icon={MdHolidayVillage}
              onClick={handleClick}
            />
            <HomeIcon
              name="Treehouse"
              Icon={BsFillTreeFill}
              onClick={handleClick}
            />
        </div>
        <p className="text-gray-500 text-sm text-center mt-12">
          More property types coming soon
        </p>
      </div>
    </React.Fragment>
  );
};

export default Step2Component;
