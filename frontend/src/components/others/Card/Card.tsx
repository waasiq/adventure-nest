import React from "react";
import { useNavigate } from "react-router-dom";

export interface CardProps {
  id: number;
  title: string;
  imageURL: string;
  price: string;
  rating: string;
  location: string;
}

const Card: React.FC<CardProps> = ({
  id,
  title,
  imageURL,
  price,
  location,
  rating,
}) => {
  const navigate = useNavigate();

  const handleClick = () => {
    navigate(`/property-details/${id}`); // navigate to the property-details route
  };

  return (
    <div
      className="max-w-sm rounded overflow-hidden shadow-lg cursor-pointer hover:shadow-2xl transition duration-500 ease-in-out transform hover:-translate-y-1 hover:scale-110"
      onClick={handleClick}
    >
      <img src={imageURL} alt={title} className="w-full h-48 object-cover" />
      <div className="px-6 py-4">
        <div className="font-bold text-xl mb-2">{title}</div>
        <p className="text-gray-700 text-base">{location}</p>
        <p className="text-gray-700 text-base">{price}</p>
        <p className="text-gray-700 text-base">{rating}</p>
      </div>
    </div>
  );
};

export default Card;
