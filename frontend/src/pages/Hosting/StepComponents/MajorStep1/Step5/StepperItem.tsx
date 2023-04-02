import React, { useState } from "react";
import StepperButton from "../../../../../components/shared/StepperButton/StepperButton";

interface IStepperProps {
    count: number;
    setCount: (value: number) => void;
    minValue: number;
    maxValue: number;
    title: string;
    onStepperChange?: (count: number, title: string) => void;
}

const StepperItem:React.FC<IStepperProps> = (props) => {
    const { count, setCount, minValue, maxValue, title, onStepperChange } = props;


    const handleCountChange = (newValue: number) => {
      setCount(newValue);
      onStepperChange && onStepperChange(newValue, title);
    };

    return (
        <React.Fragment>
            <div className="border-b border-gray-200 mx-32 py-10 flex flex-row justify-between">
                <p className="text-xl">{title} </p>
                <StepperButton value={count} minValue={minValue} maxValue={maxValue} onChange={handleCountChange} />
            </div>
        </React.Fragment>
    )
}

export default StepperItem;