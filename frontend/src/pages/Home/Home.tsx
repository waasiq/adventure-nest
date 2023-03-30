import React, { useState } from "react";
import CardGrid from "../../components/others/CardGrid/CardGrid";
import Banner from "../../components/others/Banner/Banner";
import { FaHome } from "react-icons/fa";
import { MdApartment, MdCabin, MdHolidayVillage } from "react-icons/md";
import { GiBarn } from "react-icons/gi";
import { BsFillTreeFill } from "react-icons/bs";

import NavIcon from "./NavIcon";

const Home: React.FC = () => {
  const cards = [
    {
      id: 1,
      imageURL: "https://picsum.photos/id/237/300/200",
      title: "Cozy Loft in the Heart of Downtown",
      location: "New York, NY",
      price: "$99/night",
      rating: "4.9 (234)",
      to: "/listing/1",
    },
    {
      id: 2,
      imageURL: "https://picsum.photos/id/238/300/200",
      title: "Spacious Modern Apartment",
      location: "Los Angeles, CA",
      price: "$150/night",
      rating: "4.8 (187)",
      to: "/listing/2",
    },
    {
      id: 3,
      imageURL: "https://picsum.photos/id/239/300/200",
      title: "Private Room in Stylish Condo",
      location: "Miami, FL",
      price: "$75/night",
      rating: "4.7 (121)",
      to: "/listing/3",
    },
    {
      id: 4,
      imageURL: "https://picsum.photos/id/240/300/200",
      title: "Charming Cottage in the Woods",
      location: "Seattle, WA",
      price: "$125/night",
      rating: "4.6 (98)",
      to: "/listing/4",
    },
    {
      id: 5,
      imageURL: "https://picsum.photos/id/241/300/200",
      title: "Luxury Oceanfront Villa",
      location: "San Francisco, CA",
      price: "$500/night",
      rating: "4.9 (325)",
      to: "/listing/5",
    },
    {
      id: 6,
      imageURL: "https://picsum.photos/id/242/300/200",
      title: "Rustic Farmhouse with Pool",
      location: "Boston, MA",
      price: "$200/night",
      rating: "4.5 (67)",
      to: "/listing/6",
    },
  ];

  const [step, setStep] = useState(1);

  const renderStepComponent = () => {
    switch (step) {
      case 1:
        return (
          <>
            <CardGrid cards={cards} />
          </>
        );
      case 2:
        return (
          <>
            <h1>Yo 2</h1>
          </>
        );
      case 3:
        return (
          <>
            <h1>Yo 3</h1>
          </>
        );
      case 4:
        return (
          <>
            <h1>Yo 4</h1>
          </>
        );
      case 5:
        return (
          <>
            <h1>Yo 5</h1>
          </>
        );
      case 6:
        return (
          <>
            <h1>Yo 6</h1>
          </>
        );
      default:
        return null;
    }
  };

  const handleIconClick = (step: any) => {
    setStep(step);
  };

  return (
    <React.Fragment>
      <Banner />
      <div className="w-full p-4 rounded-lg">
        <div className="flex justify-between p-4 mx-20">
          <NavIcon
            Icon={FaHome}
            text="Home"
            handleIconClick={handleIconClick}
            id={1}
          />
          <NavIcon
            Icon={MdApartment}
            text="Apartment"
            handleIconClick={handleIconClick}
            id={2}
          />
          <NavIcon
            Icon={GiBarn}
            text="Barn"
            handleIconClick={handleIconClick}
            id={3}
          />
          <NavIcon
            Icon={MdCabin}
            text="Cabin"
            handleIconClick={handleIconClick}
            id={4}
          />
          <NavIcon
            Icon={MdHolidayVillage}
            text="Village"
            handleIconClick={handleIconClick}
            id={5}
          />
          <NavIcon
            Icon={BsFillTreeFill}
            text="Treehouse"
            handleIconClick={handleIconClick}
            id={6}
          />
        </div>
        <div className="mb-4">{renderStepComponent()}</div>
      </div>
    </React.Fragment>
  );
};

export default Home;
