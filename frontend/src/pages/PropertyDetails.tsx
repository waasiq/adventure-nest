import React from "react";
import { useParams } from "react-router-dom";
import ImageCarousel from "../components/shared/ImageCarousel/ImageCarousel";
import BookingForm from "../components/others/BookingForm/BookingForm";
import HomeDetails from "../components/others/HomeDetails/HomeDetails";
import Footer from "../components/shared/Footer/Footer";

const PropertyDetails: React.FC = () => {
  const { id } = useParams<{ id: string }>();

  // Fetch property data using the id from the URL params from the backend

  // placeholder images
  const images = [
    'https://via.placeholder.com/800x500.png?text=Image+1',
    'https://via.placeholder.com/800x500.png?text=Image+2',
    'https://via.placeholder.com/800x500.png?text=Image+3',
  ];

  return (
    <React.Fragment>
      <div className="mx-40 mt-10" >
        <div className="my-10">
          <h1 className="text-2xl font-bold">Samujana Twenty-Four</h1>
          <p className="text-gray-500">Koh Samui, Thailand</p>
          <p className="text-gray-500">4 guests · 2 bedrooms · 2 beds · 2 baths</p>
        </div>
        <ImageCarousel images={images} height={500} />

        <div className="my-10 flex">
          <div className="flex-1">
            <HomeDetails />
          </div>
          <div className="flex-0.8 pl-8">
            <BookingForm />
          </div>
        </div>
      </div>
      <Footer />
    </React.Fragment>
  );
};

export default PropertyDetails;