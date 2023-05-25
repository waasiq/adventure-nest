import React, { useContext } from "react";
import { HostContext } from "../../../../context/HostingContext";
import axios from "axios";

const Step8Component: React.FC = () => {
  const { host, setHost } = useContext(HostContext);

  const sendToAPI = async () => {
    const formData = new FormData();

    if (host?.images) {
      host.images.forEach((image) => {
        formData.append("images", image);
      });
    }

    await axios.post("http://localhost:5000/api/detect", formData).then((res) => {
      console.log(res);
    });
  };
  
  return (
    <React.Fragment>
      <div className="flex">
        <div className="w-3/5 p-16">
          <h1 className="text-4xl font-bold mb-4">Final Step</h1>
          <h1 className="text-6xl font-bold mb-8">Are these amenities in your house?</h1>
          <p className="text-gray-600 text-xl mb-8">
            Insert loader here
          </p>
        </div>
        <button onClick={sendToAPI} className="bg-emerald-500 hover:bg-emerald-700 text-white font-bold py-2 px-4 rounded-full">
          Send to API
        </button>
      </div>
    </React.Fragment>
  );
};

export default Step8Component;