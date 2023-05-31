import React from "react";
import BannerImg from "../../../imgs/banner.webp";
import { Typewriter } from "react-simple-typewriter";

const Banner: React.FC = () => {

  return (
    <div className="relative">
      <img src={BannerImg} alt="banner" className="w-full h-96 object-cover" />
      <div className="absolute top-1/2 left-1/2 transform -translate-x-1/2 -translate-y-1/2">
        <h1 className="text-center text-3xl font-bold text-emerald-500">
          <Typewriter
            words={['Nest your next adventure with us!', 'Embark on your next escapade with us!', 'Discover boundless adventures with us!']}
            loop={true}
            cursor
            cursorStyle='|'
            typeSpeed={70}
            deleteSpeed={50}
            delaySpeed={1000}
          />
        </h1>
      </div>
    </div>
  );
};

export default Banner;
