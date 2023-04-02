import React, { useState, useContext } from "react";
import getGeoCodeData from "../../../../utils/LocationSearch";
import LocalMap from "../../../../components/others/Map/LocalMap";
import { HostContext } from "../../../../context/HostingContext";

interface ICoord {
  latitude: number;
  longitude: number;
}

const Step4Component: React.FC = () => {
  const { host, setHost } = useContext(HostContext);

  const [address, setAddress] = useState<string>("");
  const [coord, setCoord] = useState<ICoord | null>(null);

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    const geoCodeData = await getGeoCodeData(address);
    const latt = parseFloat(geoCodeData?.latt as string);
    const longt = parseFloat(geoCodeData?.longt as string);

    setCoord({ latitude: latt, longitude: longt });
    setHost({
      ...host,
      address: address,
      latitude: latt,
      longitude: longt,
    });
  };

  return (
    <React.Fragment>
      <h1 className="mt-4 flex flex-col items-center text-3xl font-bold mb-4">
        Please type your address
      </h1>
      <div className="flex flex-col lg:flex-row my-12">
        <div className="w-full lg:w-1/2 flex justify-center">
          <div className="rounded-lg w-full md:w-96 h-96 flex flex-col justify-center items-center">
            <input
              type="text"
              className="w-full md:w-80 p-2  border-2 border-gray-300 rounded-lg mb-4"
              placeholder="Address"
              value={host?.address ? host?.address : address}
              onChange={(e) => setAddress(e.currentTarget.value)}
            />
            <button
              className="py-2 px-10 bg-emerald-500 text-white rounded-lg"
              onClick={handleSubmit}
            >
              Submit
            </button>
          </div>
        </div>

        <div className="w-full lg:w-1/2 flex justify-center">
          <div className="w-96 h-96">
            <LocalMap 
              latitude={host?.latitude ? host?.latitude : coord?.latitude}
              longitude={host?.longitude ? host?.longitude : coord?.longitude}
            />
          </div>
        </div>
      </div>
    </React.Fragment>
  );
};

export default Step4Component;
