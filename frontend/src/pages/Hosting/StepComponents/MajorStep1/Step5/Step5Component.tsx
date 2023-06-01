import React, { useState, useContext } from "react";
import StepperItem from "./StepperItem";
import { HostContext } from "../../../../../context/HostingContext";
import { motion } from "framer-motion";

const Step5Component: React.FC = () => {
  const { host, setHost } = useContext(HostContext);

  const [guests, setGuests] = useState(host?.maxGuestCount || 1);
  const [bedrooms, setBedrooms] = useState(host?.bedroomCount || 1);
  const [beds, setBeds] = useState(host?.bathroomCount || 1);
  const [bathrooms, setBathrooms] = useState(host?.bedCount || 1);

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
      maxGuestCount: guests,
      bedroomCount: bedrooms,
      bathroomCount: beds,
      bedCount: bathrooms,
    });
  };

  return (
    <React.Fragment>
      <motion.h1
        className="mt-4 flex flex-col items-center text-orange-900 text-3xl font-bold mb-4"
        initial={{ opacity: 0, y: -20 }}
        animate={{ opacity: 1, y: 0 }}
        transition={{ duration: 0.5 }}
      >
        Share some basics about your place
      </motion.h1>
      <motion.div
        className="grid grid-cols-1 gap-1 px-96"
        initial={{ opacity: 0 }}
        animate={{ opacity: 1 }}
        transition={{ duration: 0.5, delay: 0.3 }}
      >
        <StepperItem
          count={guests}
          setCount={setGuests}
          minValue={1}
          maxValue={10}
          title="Guests"
          onStepperChange={onStepperChange}
        />
        <StepperItem
          count={bedrooms}
          setCount={setBedrooms}
          minValue={1}
          maxValue={10}
          title="Bedrooms"
          onStepperChange={onStepperChange}
        />
        <StepperItem
          count={beds}
          setCount={setBeds}
          minValue={1}
          maxValue={10}
          title="Beds"
          onStepperChange={onStepperChange}
        />
        <StepperItem
          count={bathrooms}
          setCount={setBathrooms}
          minValue={1}
          maxValue={10}
          title="Bathrooms"
          onStepperChange={onStepperChange}
        />
      </motion.div>
    </React.Fragment>
  );
};

export default Step5Component;
