import React from "react";
import { useNavigate } from "react-router-dom";
import Skeleton from 'react-loading-skeleton'
import 'react-loading-skeleton/dist/skeleton.css'

export interface CardProps {
  id: number;
  propertyID: number;
  title: string;
  imageURL: string;
  price: string;
  rating: string;
  location: string;
}

const Card: React.FC<CardProps> = ({
  id,
  propertyID,
  title,
  imageURL,
  price,
  location,
  rating,
}) => {
  const navigate = useNavigate();

  const handleClick = () => { 
    // navigate(`/property-details/${id}`);
    navigate(`/property-details/${id}/${propertyID}`); // navigate to the property-details route with id and propertyID
  };
  
  return (
    <div
      className="max-w-sm rounded overflow-hidden shadow-lg cursor-pointer hover:shadow-2xl transition duration-500 ease-in-out transform hover:-translate-y-1 hover:scale-110"
      onClick={handleClick}
    >
      <img 
        src={imageURL}
        alt={title}
        className="w-full h-48 object-cover"
        onError={(e) => {
          e.currentTarget.src = "https://media.istockphoto.com/id/1147544807/vector/thumbnail-image-vector-graphic.jpg?s=612x612&w=0&k=20&c=rnCKVbdxqkjlcs3xH87-9gocETqpspHFXu5dIGB4wuM=";
        }}
      />
      <div className="px-6 py-4">
        <div className="font-bold text-xl mb-2">{title || <Skeleton count={1} />}</div>
        <p className="text-gray-700 text-base">{location || <Skeleton count={1} />}</p>
        <p className="text-gray-700 text-base">{price || <Skeleton count={1} />}</p>
        <p className="text-gray-700 text-base">{rating || <Skeleton count={1} />}</p>
      </div>
    </div>
  );
};

export default Card;
