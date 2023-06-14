import React, { useState } from "react";
import { Step1Component, Step2Component, Step3Component, Step4Component, Step5Component } from "./StepComponents/MajorStep1";
import { Step6Component, Step7Component, Step8Component } from "./StepComponents/MajorStep2";
import FinalStep from './StepComponents/FinalStep';
import { HostProvider } from "../../context/HostingContext";

const HostingHome: React.FC = () => {
  const [step, setStep] = useState(1);
  
  const stepComponents = [
    <Step1Component key={1} />,
    <Step2Component key={2} />,
    <Step3Component key={3} />,
    <Step4Component key={4} />,
    <Step5Component key={5} />,
    <Step6Component key={6} />,
    <Step7Component key={7} />,
    <Step8Component key={8} />,
    <FinalStep key={9} />
  ];
  
  const stepSize = stepComponents.length;

  const handleBack = () => setStep((prevStep) => prevStep - 1);
  const handleNext = () => setStep((prevStep) => prevStep + 1);
  const getProgressPercentage = () => (step / stepSize) * 100;

  return (
    <>
      <HostProvider>
        <div className="p-4">
          <div className="">{stepComponents[step - 1]}</div>
          <div className="flex justify-between items-center fixed bottom-0 left-0 right-0 p-4">
            <button
              className={`py-2 px-4 rounded-lg bg-emerald-500 text-white hover:bg-emerald-600 ${
                step === 1 ? "opacity-50 cursor-not-allowed" : ""
              }`}
              onClick={handleBack}
              disabled={step === 1}
            >
              Back
            </button>
            <button
              className={`py-2 px-4 rounded-lg bg-emerald-500 text-white hover:bg-emerald-600 ${
                step === stepSize ? "opacity-50 cursor-not-allowed" : ""
              }`}
              onClick={handleNext}
              disabled={step === stepSize}
            >
              Next
            </button>
          </div>
          <div
            className="w-full bg-gray-300 rounded-lg h-2 absolute bottom-0 left-0 right-0"
            style={{ marginBottom: "100px" }}
          >
            <div
              className="bg-emerald-500 absolute left-0 top-0 h-2 rounded-lg"
              style={{ width: `${getProgressPercentage()}%` }}
            ></div>
          </div>
        </div>
      </HostProvider>
    </>
  );
};

export default HostingHome;
