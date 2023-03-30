import React, { useState } from "react";
import LocalMap from "../../components/others/Map/LocalMap";

const HostPage: React.FC = () => {
  const redirectHost = () => {

  }
  
  return (
    <React.Fragment>
    <div className="flex my-24 flex-row justify-center items-center">
      <div className="p-14">
        <h2 className="text-3xl font-bold"> Make your home Adventurer's nest</h2>
        <p className="text-gray-600"> and earn money while you're at it</p>
      </div>
      <div className="rounded-lg w-96 h-96">
        <LocalMap />
      </div>
    </div>

    <div className="flex justify-center">
      <button onClick={redirectHost }className="bg-blue-500 hover:bg-blue-700 text-white font-bold py-4 px-16 rounded-full">
        Host your home
      </button>
    </div>

    </React.Fragment>
  );
};

export default HostPage;
