import React, { useEffect } from "react";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import { CurrentUserProvider } from "./context/CurrentUserContext";
import { PublicationProvider } from "./context/PublicationContext";

import Navbar from "./components/shared/Navbar/Navbar";
import {
  Home,
  PropertyDetails,
  HelpPage,
  HostPage,
  HostingHome,
  Bookings
} from "./pages";

const App: React.FC = () => {
  useEffect(() => {
    document.title = "Adventure Nest";
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
                element={
                <PublicationProvider>
                  <PropertyDetails />
                </PublicationProvider>
              }
              />
              <Route path="/help" element={<HelpPage />} />
              <Route path="/host" element={<HostPage />} />
              <Route path="/hosting" element={<HostingHome />} />
              <Route path="/bookings" element={<Bookings />} />
            </Routes>
          </div>
        </Router>
      </CurrentUserProvider>
    </React.Fragment>
  );
};

export default App;
