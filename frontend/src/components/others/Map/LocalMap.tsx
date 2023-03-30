import React, { useEffect, useState } from 'react';
import { Map, Marker } from 'react-map-gl';
import 'mapbox-gl/dist/mapbox-gl.css';

interface IViewport {
  latitude: number;
  longitude: number;
  zoom: number;
}

const LocalMap:React.FC = () => {
  const [viewport, setViewport] = useState<IViewport>({
    latitude: 40.716957,
    longitude: 30.359314,
    zoom: 11,
  });

  useEffect(() => {
    navigator.geolocation.getCurrentPosition((pos) => {
      setViewport((prevViewport) => ({
        ...prevViewport,
        latitude: pos.coords.latitude,
        longitude: pos.coords.longitude,
      }));
    });
  }, []);

  return (
    <React.Fragment>
      <Map
        mapboxAccessToken={process.env.REACT_APP_MAP_ACCESS_TOKEN}
        mapStyle={process.env.REACT_APP_MAP_STYLE_URL}
        {...viewport}
      >
        <Marker
          longitude={viewport.longitude}
          latitude={viewport.latitude}
        />
      </Map>
    </React.Fragment>
  );
};

export default LocalMap;
