import React from "react";
import { FaHome } from "react-icons/fa";
import { MdApartment, MdCabin, MdHolidayVillage } from "react-icons/md";
import { GiBarn } from "react-icons/gi";
import { BsFillTreeFill } from "react-icons/bs";

const Step2Component: React.FC = () => {
  return (
    <React.Fragment>
      <div className="mt-20">
        <h1 className="text-3xl font-bold mb-16 text-center">
          Which best describes your home?
        </h1>
        <div className="grid grid-cols-3 gap-3 px-72">
          <div className="flex flex-col items-center border py-4 rounded-lg cursor-pointer hover:border-emerald-500">
            <FaHome size={36} />
            <span className="mt-2 font-bold">Home</span>
          </div>
          <div className="flex flex-col items-center border py-4 rounded-lg cursor-pointer hover:border-emerald-500">
            <MdApartment size={36} />
            <span className="mt-2 font-bold">Apartment</span>
          </div>
          <div className="flex flex-col items-center border py-4 rounded-lg cursor-pointer hover:border-emerald-500">
            <GiBarn size={36} />
            <span className="mt-2 font-bold">Barn</span>
          </div>
          <div className="flex flex-col items-center border py-4 rounded-lg cursor-pointer hover:border-emerald-500">
            <MdCabin size={36} />
            <span className="mt-2 font-bold">Cabin</span>
          </div>
          <div className="flex flex-col items-center border py-4 rounded-lg cursor-pointer hover:border-emerald-500">
            <MdHolidayVillage size={36} />
            <span className="mt-2 font-bold">Villa</span>
          </div>
          <div className="flex flex-col items-center border py-4 rounded-lg cursor-pointer hover:border-emerald-500">
            <BsFillTreeFill size={36} />
            <span className="mt-2 font-bold">Treehouse</span>
          </div>
        </div>
        <p className="text-gray-500 text-sm text-center mt-12">
          More property types coming soon
        </p>
      </div>
    </React.Fragment>
  );
};

export default Step2Component;
