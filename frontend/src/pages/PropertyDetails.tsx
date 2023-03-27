import React from "react";
import { useParams } from "react-router-dom";

const PropertyDetails: React.FC = () => {
  const { id } = useParams<{ id: string }>();

  console.log(id)
  // Fetch property data using the id from the URL params from the backend
  // ...

  return (
    <div>
      <h1>Property Details</h1>
      <p>ID: {id}</p>
      {/* Display property data */}
      {/* ... */}
    </div>
  );
};

export default PropertyDetails;