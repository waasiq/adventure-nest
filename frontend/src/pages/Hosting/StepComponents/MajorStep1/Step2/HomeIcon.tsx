import React, { useState, useContext, useEffect } from "react";
import { IconType } from "react-icons";
import { HostContext } from "../../../../../context/HostingContext";

interface IProps {
    name: string;
    Icon: IconType;
    onClick?: (e: React.MouseEvent<HTMLDivElement, MouseEvent>) => void;
}
  
const HomeIcon: React.FC<IProps> = ({ name, Icon, onClick }) => {
    const { host } = useContext(HostContext);
  
    return (
      <div
        onClick={(e: React.MouseEvent<HTMLDivElement, MouseEvent>) => {
          if (onClick) {
            onClick(e);
          }
        }}
        className={`flex flex-col items-center border py-4 rounded-lg cursor-pointer ${
          host?.selectedHomeIcon === name ? "border-black" : "hover:border-emerald-500"
        }`}
        data-type={name}
      >
        <Icon
          size={36}
          className={`${host?.selectedHomeIcon === name ? "text-emerald-500" : ""}`}
        />
        <span className="mt-2 font-bold">{name}</span>
      </div>
    );
};
  
export default HomeIcon;