import React from "react";
import { GrLanguage } from "react-icons/gr";
import Logo from "../../../imgs//logos/logo_transparent.png";
import UserDropdown from "./Dropdown/UserDropdown";
import { useNavigate } from "react-router-dom";

const Navbar: React.FC = () => {
  // Redirection From Navbar
  const navigate = useNavigate();
  const redirectToHome = () => {
    navigate("/");
  };
  const redirectToHost = () => {
    navigate("/host");
  };

  return (
    <nav className="flex justify-between border-b border-gray-200 items-center py-4">
      {/* Left side of navbar */}
      <div className="flex items-center mx-16">
        <div
          className="h-16 w-full flex justify-center items-center cursor-pointer"
          style={{
            filter:
              "invert(48%) sepia(13%) saturate(3207%) hue-rotate(130deg) brightness(95%) contrast(80%)",
          }}
          onClick={redirectToHome}
        >
          <img src={Logo} alt="Logo" style={{ height: "7.5rem" }} />
        </div>
      </div>

      {/* Middle of navbar */}
      <div className="hidden md:flex items-center border border-gray-400 rounded-full px-4 py-2">
        {/* !Insert here later on */}
      </div>

      {/* Right side of navbar */}
      <div className="flex items-center space-x-4 mx-10">
        <div className="hidden md:block">
          <p
            className="text-gray-600 font-medium cursor-pointer"
            onClick={redirectToHost}
          >
            Host an Adventure
          </p>
        </div>
        <div className="hidden md:block">
          <p
            className="text-gray-600 font-medium cursor-pointer"
            // onClick={redirectToHost}
          >
            My Bookings
          </p>
        </div>
        <div className="hidden md:block">
          <GrLanguage className="text-gray-600 text-lg" />
        </div>
        <div className="hidden md:block">
          <UserDropdown />
        </div>
      </div>
    </nav>
  );
};

export default Navbar;
