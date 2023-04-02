import React, { useContext } from "react";
import { BsHouse, BsBuilding } from "react-icons/bs";
import { GiTwoCoins } from "react-icons/gi";
import StepIcon from "./StepIcon";
import { HostContext } from "../../../../../context/HostingContext";


const Step3Component: React.FC= () => {
  const { host, setHost } = useContext(HostContext);

  const handleClick = (e: React.MouseEvent<HTMLDivElement, MouseEvent>) => {
    const target = e.target as HTMLDivElement;
    const finalVal = target.closest('[data-type]')?.getAttribute('data-type');
    
    setHost({
      ...host,
      placeType: finalVal as string,
      selectedPlaceIcon: finalVal as string,
    });
  }

  return (
    <React.Fragment>
      <h1 className="mt-4 flex flex-col items-center text-3xl font-bold mb-4">
        What type of place will guests have?
      </h1>
      <div className="grid grid-cols-1 gap-4  px-96">
        <StepIcon name="Entire place" Icon={BsHouse}  onClick={handleClick} />
        <StepIcon name="Private room" Icon={BsBuilding} onClick={handleClick}/>
        <StepIcon name="Shared room" Icon={GiTwoCoins} onClick={handleClick} />
      </div>
    </React.Fragment>
  );
};

export default Step3Component;
