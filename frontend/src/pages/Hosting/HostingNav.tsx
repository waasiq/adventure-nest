import React, { useState } from 'react';
import Step1Component from './StepComponents/Step1Component';
import Step2Component from './StepComponents/Step2Component';
import Step3Component from './StepComponents/Step3Component';
import Step4Component from './StepComponents/Step4Component';

const HostingNav: React.FC = () => {
  const [step, setStep] = useState(1);

  const handleBack = () => {
    setStep((prevStep) => prevStep - 1);
  };

  const handleNext = () => {
    if (step < 4) {
      setStep((prevStep) => prevStep + 1);
    }
  };

  const getProgressPercentage = () => {
    return (step / 4) * 100;
  };

  const renderStepComponent = () => {
    switch (step) {
      case 1:
        return <Step1Component />;
      case 2:
        return <Step2Component />;
      case 3:
        return <Step3Component />;
      case 4:
        return <Step4Component />;
      default:
        return null;
    }
  };
  return (
    <div className="w-full p-4 rounded-lg">
      <div className="mb-4">{renderStepComponent()}</div>
  
      <div className="flex justify-between items-center fixed bottom-0 left-0 right-0 p-4">
        <button
          className={`py-2 px-4 rounded-lg bg-blue-500 text-white hover:bg-blue-600 ${
            step === 1 ? "opacity-50 cursor-not-allowed" : ""
          }`}
          onClick={handleBack}
          disabled={step === 1}
        >
          Back
        </button>
        <button
          className={`py-2 px-4 rounded-lg bg-blue-500 text-white hover:bg-blue-600 ${
            step === 4 ? "opacity-50 cursor-not-allowed" : ""
          }`}
          onClick={handleNext}
          disabled={step === 4}
        >
          Next
        </button>
      </div>
  
      <div
        className="w-full bg-gray-300 rounded-lg h-2 absolute bottom-0 left-0 right-0"
        style={{ marginBottom: "100px" }}
      >
        <div
          className="bg-blue-500 absolute left-0 top-0 h-2 rounded-lg"
          style={{ width: `${getProgressPercentage()}%` }}
        ></div>
      </div>
    </div>
  );
  
};

export default HostingNav;
