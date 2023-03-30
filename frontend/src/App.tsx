import React from "react";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import { CurrentUserProvider } from "./context/CurrentUserContext";

import Navbar from "./components/shared/Navbar/Navbar";
import {
  Home,
  PropertyDetails,
  HelpPage,
  HostPage,
  HostingHome,
} from "./pages";

const App: React.FC = () => {
  React.useEffect(() => {
    console.log(process.env.REACT_APP_GOOGLE_CLIENT_ID);
  }, []);

  return (
    <React.Fragment>
      <CurrentUserProvider>
        <Router>
          <Navbar />
          <div className=" mx-auto">
            <Routes>
              <Route path="/" element={<Home />} />
              <Route
                path="/property-details/:id"
                element={<PropertyDetails />}
              />
              <Route path="/help" element={<HelpPage />} />
              <Route path="/host" element={<HostPage />} />
              <Route path="/hosting" element={<HostingHome />} />
            </Routes>
          </div>
        </Router>
      </CurrentUserProvider>
    </React.Fragment>
  );
};

export default App;
