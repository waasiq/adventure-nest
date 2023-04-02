import React from "react";
import Card, { CardProps } from "../Card/Card";


interface CardGridProps {
  cards: CardProps[];
}

const CardGrid: React.FC<CardGridProps> = ({ cards }) => {
  return (
    <div className="container mx-auto pt-10">
      {/* // eslint-disable-next-line */}
      <a className="grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-5 gap-7">
        {cards.map((card, index) => (
             <Card key={index} {...card} />  
        ))}
      </a>
    </div>
  );
};

export default CardGrid;
