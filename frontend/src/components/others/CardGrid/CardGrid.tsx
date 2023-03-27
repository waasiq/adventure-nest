import React from "react";
import Card, { CardProps } from "../Card/Card";

interface CardGridProps {
    cards: CardProps[];
}

const CardGrid: React.FC<CardGridProps> = ({ cards }) => {
    return (
      <a className="grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-4 gap-4">
        {cards.map((card, index) => (
          <Card key={index} {...card} />
        ))}
      </a>
    );
};

export default CardGrid;