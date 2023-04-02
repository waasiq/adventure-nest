import React, { useState } from "react";
import { FaPlus, FaMinus } from "react-icons/fa";

interface IStepperProps {
  value: number;
  minValue: number;
  maxValue: number;
  onChange: (newValue: number) => void;
}

const StepperButton: React.FC<IStepperProps> = ({
  value,
  minValue,
  maxValue,
  onChange,
}) => {
  
  const handleIncrement = () => {
    if (value < maxValue) {
      onChange(value + 1);
    }
  };

  const handleDecrement = () => {
    if (value > minValue) {
      onChange(value - 1);
    }
  };

  return (
    <div className="flex items-center justify-center">
      <button
        className="px-2 py-2 rounded-full border-2  border-gray-300"
        onClick={handleDecrement}
      >
        <FaMinus className="text-emerald-500" />
      </button>
      <span className="mx-2 text-emerald-900 text-2xl font-bold">{value}</span>
      <button
        className="px-2 py-2 rounded-full border-2 border-gray-300"
        onClick={handleIncrement}
      >
        <FaPlus className="text-emerald-500" />
      </button>
    </div>
  );
};

export default StepperButton;
