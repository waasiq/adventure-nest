import React from "react";
import { BsHouse, BsBuilding } from "react-icons/bs";
import { GiTwoCoins } from "react-icons/gi";

const Step3Component: React.FC = () => {
  return (
    <React.Fragment>
      <h1 className="mt-4 flex flex-col items-center text-3xl font-bold mb-4">
        What type of place will guests have?
      </h1>
      <div className="grid grid-cols-1 gap-4  px-96">
        <div className="py-5">
          <div className="flex items-center justify-between cursor-pointer p-7 border border-gray-200 rounded-lg hover:border-emerald-500">
            <span className="font-bold">An entire home to themselves</span>
            <BsHouse size={36} />
          </div>
        </div>
        <div className="py-5">
          <div className="flex items-center justify-between cursor-pointer p-7 border border-gray-200 rounded-lg hover:border-emerald-500">
            <span className="font-bold">A private room to themselves</span>
            <BsBuilding size={36} />
          </div>
        </div>

        <div className="py-5">
          <div className="flex items-center justify-between cursor-pointer p-7 border border-gray-200 rounded-lg hover:border-emerald-500">
            <div>
              <span className="font-bold">A shared room</span>
              <span className="font-bold">with other guests</span>
            </div>
            <GiTwoCoins size={36} />
          </div>
        </div>
      </div>
    </React.Fragment>
  );
};

export default Step3Component;
