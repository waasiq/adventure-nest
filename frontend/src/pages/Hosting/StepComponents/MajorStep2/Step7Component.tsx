import React, { useContext } from "react";
import ImageUploader from "../../../../utils/ImageUploader";
import { IHost,  HostContext } from "../../../../context/HostingContext";

const Step7Component: React.FC = () => {
  const { host, setHost } = useContext(HostContext);

  return (
    <React.Fragment>
      <div className="flex">
        <ImageUploader />
      </div>
    </React.Fragment>
  );
};

export default Step7Component;
