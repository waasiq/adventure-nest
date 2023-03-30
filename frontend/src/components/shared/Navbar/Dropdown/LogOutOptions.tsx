import React, { useContext, useState } from "react";
import { CurrentUserContext } from "../../../../context/CurrentUserContext";

const LogOutOption: React.FC = () => {
  const { user } = useContext(CurrentUserContext);
  const [logInModal, setLogInModal] = useState(false);
  const openLogInModal = () => {
    setLogInModal(!logInModal);
  };

  const handleLogout = () => {
    localStorage.removeItem("user");
    window.location.reload();
  };

  return (
    <React.Fragment>
      {user && (
        <a
          href="#"
          className="block px-4 py-2 text-sm text-gray-700 hover:bg-gray-100 hover:text-gray-900"
          role="menuitem"
          onClick={handleLogout}
        >
          Log Out
        </a>
      )}
    </React.Fragment>
  );
};

export default LogOutOption;
