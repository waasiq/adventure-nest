import React, { useState, useContext } from "react";
import LogInOptions from "./LoginOptions";
import LogOutOption from "./LogOutOptions";
import { CurrentUserContext } from '../../../../context/CurrentUserContext';
import { useNavigate } from "react-router-dom";

const UserDropdown: React.FC = () => {
  const [isOpen, setIsOpen] = useState(false);
  const { user } = useContext(CurrentUserContext);
  const toggleMenu = () => { setIsOpen(!isOpen) }
  
  const navigate = useNavigate();
  const redirect = () => {
    navigate("/help");
  }

  return (
    <div className="relative inline-block text-left">
      <div>
        <button
          type="button"
          className="inline-flex items-center justify-center w-full rounded-md border border-gray-300 shadow-sm px-4 py-2 bg-white text-sm font-medium text-gray-700 hover:bg-gray-50 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-offset-gray-100 focus:ring-indigo-500"
          id="user-menu"
          aria-expanded="false"
          aria-haspopup="true"
          onClick={toggleMenu}
        >
          <img 
          src={user?.picture ? user.picture : "https://via.placeholder.com/150" }
            alt="Host avatar"
            className="rounded-full h-10 w-10" />
        </button>
      </div>

      {isOpen && (
        <div className="origin-top-right absolute right-0 mt-2 w-56 rounded-md shadow-lg bg-white ring-1 ring-black ring-opacity-5">
          <div
            className="py-1"
            role="menu"
            aria-orientation="vertical"
            aria-labelledby="user-menu"
          >
            
            <LogInOptions />
            <LogOutOption />
            <a
              href="#"
              className="block px-4 py-2 text-sm text-gray-700 hover:bg-gray-100 hover:text-gray-900"
              role="menuitem"
              onClick={redirect}
            >
              Help 
            </a>
          </div>
        </div>
      )}
    </div>
  );
};

export default UserDropdown;