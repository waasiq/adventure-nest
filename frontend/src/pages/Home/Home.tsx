import React, { useState, useEffect } from "react";
import { motion } from "framer-motion";
import CardGrid from "../../components/others/CardGrid/CardGrid";
import { CardProps } from "../../components/others/Card/Card";
import Banner from "../../components/others/Banner/Banner";
import { FaHome } from "react-icons/fa";
import { MdApartment, MdCabin, MdHolidayVillage } from "react-icons/md";
import { GiBarn } from "react-icons/gi";
import { BsFillTreeFill } from "react-icons/bs";
import { getAPIHandler } from "../../api/apiHandler";
import NavIcon from "./NavIcon";

interface IPropertyResponse {
  data: CardProps[];
  errors: string[] | null;
}

const Home: React.FC = () => {
  const [homeCards, setHomeCards] = useState<CardProps[]>([]);
  const [apartmentCards, setApartmentCards] = useState<CardProps[]>([]);
  const [barnCards, setBarnCards] = useState<CardProps[]>([]);
  const [cabinCards, setCabinCards] = useState<CardProps[]>([]);
  const [villageCards, setVillageCards] = useState<CardProps[]>([]);
  const [treehouseCards, setTreehouseCards] = useState<CardProps[]>([]);

  const [step, setStep] = useState(1);
  const [dataFetched, setDataFetched] = useState(false);

  useEffect(() => {
    if (!dataFetched) {
      try {
        const fetchData = async () => {
          const { data } = await getAPIHandler(
            "/publications/publications-with-property"
          );
          const propertyResponse: IPropertyResponse = data as IPropertyResponse;
          console.log(propertyResponse.data);

          propertyResponse.data.forEach((property: any) => {
            const card: CardProps = {
              id: property.id,
              propertyID: property.propertyID,
              imageURL: property.photographsPathList[0],
              title: property.title,
              location: `${property.city}, ${property.country}`,
              price: `$${property.price}/night`,
              rating: "4.9 (234)",
            };

            switch (property.propertyType) {
              case "Home":
                setHomeCards((prevCards) => [...prevCards, card]);
                break;
              case "Apartment":
                setApartmentCards((prevCards) => [...prevCards, card]);
                break;
              case "Barn":
                setBarnCards((prevCards) => [...prevCards, card]);
                break;
              case "Cabin":
                setCabinCards((prevCards) => [...prevCards, card]);
                break;
              case "Villa":
                setVillageCards((prevCards) => [...prevCards, card]);
                break;
              case "Treehouse":
                setTreehouseCards((prevCards) => [...prevCards, card]);
                break;
              default:
                break;
            }
          });
        };
        fetchData();
      } catch (error) {
        console.log(error);
      }

      setDataFetched(true);
    }
  }, []);

  const renderStepComponent = () => {
    switch (step) {
      case 1:
        return (
          <motion.div
            key={1}
            initial={{ opacity: 0 , x: 100}}
            animate={{ opacity: 1, x: 0, transition: { duration: 1 }}}
            exit={{ opacity: 0 }}
          >
            <CardGrid cards={homeCards} />
          </motion.div>
        );
      case 2:
        return (
          <motion.div
            key={2}
            initial={{ opacity: 0 , x: 100}}
            animate={{ opacity: 1, x: 0, transition: { duration: 1 }}}
            exit={{ opacity: 0 }}
          >
            <CardGrid cards={apartmentCards} />
          </motion.div>
        );
      case 3:
        return (
          <motion.div
            key={3}
            initial={{ opacity: 0 , x: 100}}
            animate={{ opacity: 1, x: 0, transition: { duration: 1 }}}
            exit={{ opacity: 0 }}
          >
            <CardGrid cards={barnCards} />
          </motion.div>
        );
      case 4:
        return (
          <motion.div
            key={4}
            initial={{ opacity: 0 , x: 100}}
            animate={{ opacity: 1, x: 0, transition: { duration: 1 }}}
            exit={{ opacity: 0 }}
          >
            <CardGrid cards={cabinCards} />
          </motion.div>
        );
      case 5:
        return (
          <motion.div
            key={5}
            initial={{ opacity: 0 , x: 100}}
            animate={{ opacity: 1, x: 0, transition: { duration: 1 }}}
            exit={{ opacity: 0 }}
          >
            <CardGrid cards={villageCards} />
          </motion.div>
        );
      case 6:
        return (
          <motion.div
            key={6}
            initial={{ opacity: 0 , x: 100}}
            animate={{ opacity: 1, x: 0, transition: { duration: 1 }}}
            exit={{ opacity: 0 }}
          >
            <CardGrid cards={treehouseCards} />
          </motion.div>
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
            text="Villa"
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
