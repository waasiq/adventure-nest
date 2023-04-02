import React, { useState, useContext } from "react";
import StepperItem from "./StepperItem";
import { HostContext } from "../../../../../context/HostingContext";

const Step5Component: React.FC = () => {
  const { host, setHost } = useContext(HostContext);

  const [guests, setGuests] = useState(host?.numOfGuests || 1);
  const [bedrooms, setBedrooms] = useState(host?.numOfBedrooms || 1);
  const [beds, setBeds] = useState(host?.numOfBeds || 1);
  const [bathrooms, setBathrooms] = useState(host?.numOfBathrooms || 1);

  const onStepperChange = (count: number, title: string) => {
    switch (title) {
      case "Guests":
        setGuests(count);
        break;
      case "Bedrooms":
        setBedrooms(count);
        break;
      case "Beds":
        setBeds(count);
        break;
      case "Bathrooms":
        setBathrooms(count);
        break;
      default:
        break;
    }

    setHost({
      ...host,
      numOfGuests: guests,
      numOfBedrooms: bedrooms,
      numOfBeds: beds,
      numOfBathrooms: bathrooms,
    });
  };

  return (
    <React.Fragment>
      <h1 className="mt-4 flex flex-col items-center text-3xl font-bold mb-4">
        Share some basics about your place
      </h1>
      <div className="grid grid-cols-1 gap-1 px-96">
        <StepperItem count={guests} setCount={setGuests} minValue={1} maxValue={10} title="Guests" onStepperChange={onStepperChange} />
        <StepperItem count={bedrooms} setCount={setBedrooms} minValue={1} maxValue={10} title="Bedrooms" onStepperChange={onStepperChange} />
        <StepperItem count={beds} setCount={setBeds} minValue={1} maxValue={10} title="Beds" onStepperChange={onStepperChange} />
        <StepperItem count={bathrooms} setCount={setBathrooms} minValue={1} maxValue={10} title="Bathrooms" onStepperChange={onStepperChange} />
      </div>
    </React.Fragment>
  );
};

export default Step5Component;
