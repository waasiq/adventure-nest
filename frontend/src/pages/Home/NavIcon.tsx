import React from "react";

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
  return (
    <div
      className="p-2 rounded-full cursor-pointer"
      onClick={() => handleIconClick(id)}
    >
      <Icon size={24} className="text-emerald-500" />
      <p className="text-xs text-gray-500">{text}</p>
    </div>
  );
};

export default NavIcon;
