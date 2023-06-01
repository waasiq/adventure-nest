import React, { useEffect, useState, useContext } from "react";
import ImageCarousel from "../components/shared/ImageCarousel/ImageCarousel";
import BookingForm from "../components/others/BookingForm/BookingForm";
import HomeDetails from "../components/others/HomeDetails/HomeDetails";
import Footer from "../components/shared/Footer/Footer";
import { getAPIHandler } from "../api/apiHandler";
import { useParams } from "react-router-dom";
import { PublicationContext } from "../context/PublicationContext";
import { IPublication, IProperty, IResponse } from "../types/types";


const PropertyDetails: React.FC = () => {
  const { id , propertyID } = useParams<{ id: string, propertyID: string }>()
  const { publication, setPublication, property, setProperty } = useContext(PublicationContext);

  useEffect(() => {
    const fetchData = async () => {
      try{
        const getPublication = await getAPIHandler("/publications/" + id);
        const getProperty  = await getAPIHandler("/properties/" + propertyID);

        const getPublicationRes: IResponse = getPublication.data as IResponse;
        const getPropertyRes: IResponse = getProperty.data as IResponse;
        
        setProperty(getPropertyRes.data as IProperty);
        setPublication(getPublicationRes.data as IPublication);

        console.log(getPropertyRes.data as IProperty);
      } catch {
        console.log("Error fetching property details");
      }
    };
  
    fetchData();
  }, []);

  // placeholder images
  const images = [
    "https://via.placeholder.com/800x500.png?text=Image+1",
    "https://via.placeholder.com/800x500.png?text=Image+2",
    "https://via.placeholder.com/800x500.png?text=Image+3",
  ];

  return (
    <React.Fragment>
      {publication && property && (
        <div className="mx-40 mt-10">
          <div className="my-10">
            <h1 className="text-2xl font-bold">{publication.title}</h1>
            <p className="text-gray-500">{property?.city}, {property?.country}</p>
            <p className="text-gray-500">
              {property?.maxGuestCount} guests ·
              {property?.bedroomCount} bedrooms ·
              {property?.bedCount} beds ·
              {property?.bathroomCount} baths
            </p>
          </div>
          <ImageCarousel images={images} height={500} />

          <div className="my-10 flex">
            <div className="flex-0.6">
              <HomeDetails  />
            </div>
            <div className="flex-0.4 pl-16">
              <BookingForm />
            </div>
          </div>
        </div>
      )}
      <Footer />
    </React.Fragment>
  );
};

export default PropertyDetails;
