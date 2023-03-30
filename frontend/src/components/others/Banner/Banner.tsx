import React from "react";
import BannerImg from "../../../imgs/banner.webp";

const Banner: React.FC = () => {
  return (
    <div className="relative">
      <img src={BannerImg} alt="banner" className="w-full h-96 object-cover" />
      <div className="absolute top-1/2 left-1/2 transform -translate-x-1/2 -translate-y-1/2">
        <h1 className="text-center text-3xl font-bold text-emerald-500">
          Nest your next adventure with us!
        </h1>
        <p className="text-center text-black-500">
          Find your fellow adventurers here
        </p>
      </div>
    </div>
  );
};

export default Banner;
