import React from "react";
import { SlCalender } from "react-icons/sl";
import { MdWorkOutline } from "react-icons/md";

import ApplianceDetails from "./ApplianceDetails";

const HomeDetails: React.FC = () => {
  return (
    <React.Fragment>
      <div className="flex flex-col border-b pb-8 border-gray-200">
        <div className="flex p-4 border-b border-gray-200 justify-between">
          <h2 className="text-2xl font-bold pr-96">Hosted by Waasiq</h2>
          <img
            src="https://via.placeholder.com/150"
            alt="Host avatar"
            className="rounded-full h-10 w-10"
          />
        </div>

        <div className="flex mt-6">
          <MdWorkOutline className="text-2xl text-gray-500" />
          <h4 className="text-2xs px-2 font-bold">Dedicated workspace</h4>
        </div>
        <p className="px-8">A room which fits your needs</p>

        <div className="flex mt-6">
          <SlCalender className="text-2xl  text-gray-500" />
          <p className="font-bold px-2">
            {" "}
            Free cancellation until 2 days before check-in
          </p>
        </div>
      </div>
      <div className="flex flex-col border-b pb-8 border-gray-200">
        <div className="flex mt-6">
          <p className="px-2">
            Every booking includes free protection from Host cancellations,
            listing inaccuracies, and other issues like trouble checking in.
          </p>
        </div>
      </div>
      <div className="flex flex-col border-b pb-8 border-gray-200">
        <div className="flex mt-6">
          <p className="px-2">Description of the place</p>
        </div>
      </div>

      <ApplianceDetails />
    </React.Fragment>
  );
};

export default HomeDetails;
