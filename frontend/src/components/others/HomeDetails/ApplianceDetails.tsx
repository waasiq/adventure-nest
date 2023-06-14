import React from "react";
import { RiCheckLine, RiCloseLine } from 'react-icons/ri';

interface Props {
  isBed: boolean;
  isBlender: boolean;
  isCoffeeMaker: boolean;
  isCouch: boolean;
  isGasStove: boolean;
  isMicrowave: boolean;
  isMixingBowl: boolean;
  isRefrigerator: boolean;
}

const ApplianceDetails: React.FC<Props> = (props) => {
  const { isBed, isBlender, isCoffeeMaker, isCouch, isGasStove, isMicrowave, isMixingBowl, isRefrigerator } = props;

  const renderIcon = (value: boolean) => {
    if (value) {
      return <RiCheckLine className="text-green-500 text-2xl" />;
    } else {
      return <RiCloseLine className="text-red-500 text-2xl" />;
    }
  };

  return (
    <React.Fragment>
      <div className="flex flex-col border-b py-4 px-2 border-gray-200">
        <h3 className="text-2xl font-bold">What this place offers</h3>
        <div className="flex mt-6">
          <div className="flex flex-col gap-4">
            <div className="flex items-center">
              {renderIcon(isBed)}
              <span className="ml-2 text-lg">Bed</span>
            </div>
            <div className="flex items-center">
              {renderIcon(isBlender)}
              <span className="ml-2 text-lg">Blender</span>
            </div>
            <div className="flex items-center">
              {renderIcon(isCoffeeMaker)}
              <span className="ml-2 text-lg">Coffee Maker</span>
            </div>
            <div className="flex items-center">
              {renderIcon(isCouch)}
              <span className="ml-2 text-lg">Couch</span>
            </div>
            <div className="flex items-center">
              {renderIcon(isGasStove)}
              <span className="ml-2 text-lg">Gas Stove</span>
            </div>
            <div className="flex items-center">
              {renderIcon(isMicrowave)}
              <span className="ml-2 text-lg">Microwave</span>
            </div>
            <div className="flex items-center">
              {renderIcon(isMixingBowl)}
              <span className="ml-2 text-lg">Mixing Bowl</span>
            </div>
            <div className="flex items-center">
              {renderIcon(isRefrigerator)}
              <span className="ml-2 text-lg">Refrigerator</span>
            </div>
          </div>
        </div>
      </div>
    </React.Fragment>
  );
};

export default ApplianceDetails;