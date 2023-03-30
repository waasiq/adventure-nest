import React from 'react';
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Navbar from './components/shared/Navbar/Navbar';
import CardGrid from './components/others/CardGrid/CardGrid';
import PropertyDetails from './pages/PropertyDetails'
import { CurrentUserProvider } from './context/CurrentUserContext';
import HelpPage from './pages/HelpPage';
import HostPage from './pages/Hosting/HostPage';
import HostHome from './pages/Hosting/HostHome';

const App:React.FC = () => {
  const cards = [
    {
      id: 1,
      imageURL: "https://picsum.photos/id/237/300/200",
      title: "Cozy Loft in the Heart of Downtown",
      location: "New York, NY",
      price: "$99/night",
      rating: "4.9 (234)",
      to: "/listing/1",
    },
    {
      id: 2,
      imageURL: "https://picsum.photos/id/238/300/200",
      title: "Spacious Modern Apartment",
      location: "Los Angeles, CA",
      price: "$150/night",
      rating: "4.8 (187)",
      to: "/listing/2",
    },
    {
      id: 3,
      imageURL: "https://picsum.photos/id/239/300/200",
      title: "Private Room in Stylish Condo",
      location: "Miami, FL",
      price: "$75/night",
      rating: "4.7 (121)",
      to: "/listing/3",
    },
    {
      id: 4,
      imageURL: "https://picsum.photos/id/240/300/200",
      title: "Charming Cottage in the Woods",
      location: "Seattle, WA",
      price: "$125/night",
      rating: "4.6 (98)",
      to: "/listing/4",
    },
    {
      id: 5,
      imageURL: "https://picsum.photos/id/241/300/200",
      title: "Luxury Oceanfront Villa",
      location: "San Francisco, CA",
      price: "$500/night",
      rating: "4.9 (325)",
      to: "/listing/5",
    },
    {
      id: 6,
      imageURL: "https://picsum.photos/id/242/300/200",
      title: "Rustic Farmhouse with Pool",
      location: "Boston, MA",
      price: "$200/night",
      rating: "4.5 (67)",
      to: "/listing/6",
    },
  ];

  React.useEffect(() => {
    console.log(process.env.REACT_APP_GOOGLE_CLIENT_ID)
  }, [])

  return (
    <React.Fragment>
      <CurrentUserProvider>
        <Router>
          <Navbar />
          <div className=" mx-auto">
            <Routes>
              <Route path="/" element={<CardGrid cards={cards} />} />
              <Route path="/property-details/:id" element={<PropertyDetails />} />
              <Route path="/help" element={<HelpPage />} />
              <Route path="/host" element={<HostPage />} />
              <Route path="/hosting" element={<HostHome />} />
            </Routes>
          </div>
        </Router>
      </CurrentUserProvider>
    </React.Fragment>

  );
}

export default App;
