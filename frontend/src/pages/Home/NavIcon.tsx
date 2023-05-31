import React from "react";
import { motion } from "framer-motion";

interface Icon {
  size: number;
  className: string;
}

interface NavIconProps {
  Icon: React.FC<Icon>;
  text: string;
  handleIconClick: (id: number) => void;
  id: number;
}

const NavIcon: React.FC<NavIconProps> = (props) => {
  const { Icon, text, handleIconClick, id } = props;

  const iconVariants = {
    hover: {
      scale: 1.2, // Increase icon size on hover
    },
  };

  return (
    <motion.div
      className="rounded-full cursor-pointer flex items-center bg-gray-100 hover:bg-gray-200 p-2"
      onClick={() => handleIconClick(id)}
      whileHover="hover"
      variants={iconVariants}
    >
      <Icon size={24} className="text-emerald-500" />
      <p className="text-xs uppercase font-bold mx-2 text-gray-700">{text}</p>
    </motion.div>
  );
};

export default NavIcon;
