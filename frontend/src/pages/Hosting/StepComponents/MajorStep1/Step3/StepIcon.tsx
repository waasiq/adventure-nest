import React, { useContext } from "react";
import { HostContext } from "../../../../../context/HostingContext";
import { IconType } from "react-icons";

interface IStepIcon {
  Icon: IconType;
  name: string;
  onClick: (e: React.MouseEvent<HTMLDivElement, MouseEvent>) => void;
}

const StepIcon: React.FC<IStepIcon> = ({ Icon, name, onClick }) => {
  const { host } = useContext(HostContext);

  return (
    <React.Fragment>
      <div className="py-5">
        <div
          data-type={name}
          onClick={onClick}
          className={`flex items-center justify-between cursor-pointer p-7 border border-gray-200 rounded-lg ${
            host?.selectedPlaceIcon === name ? "border-black" : "hover:border-emerald-500"
          }`}
        >
          <span className="font-bold">{name}</span>
          <Icon size={36} className={`${host?.selectedPlaceIcon === name ? "text-emerald-500" : ""}`} />
        </div>
      </div>
    </React.Fragment>
  );
};

export default StepIcon;
