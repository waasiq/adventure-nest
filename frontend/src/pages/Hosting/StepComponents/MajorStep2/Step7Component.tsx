import React, { useContext, useEffect } from "react";
import ImageUploader from "../../../../utils/ImageUploader";
// import { HostContext } from "../../../../context/HostingContext";

const Step7Component: React.FC = () => {
  // const { host, setHost } = useContext(HostContext);

  return (
    <React.Fragment>
      <div className="flex">
        <ImageUploader />
      </div>
    </React.Fragment>
  );
};

export default Step7Component;
