import React, { useContext, useState } from "react";
import Dropzone, { DropzoneProps } from "react-dropzone";
import { AiOutlineUpload } from "react-icons/ai";
import { HostContext } from "../context/HostingContext";

const ImageUploader: React.FC = () => {
  const { host, setHost } = useContext(HostContext);
  const [files, setFiles] = useState([]);

  const handleDrop = (acceptedFiles: File[]) => {
    const updatedFiles = [...files, ...acceptedFiles];
    setHost((prevHost) => ({ ...prevHost, images: updatedFiles }));
  };
  
  const handleRejection = () => {
    alert("File size is too big");
  };

  const dropzoneProps: DropzoneProps = {
    onDrop: handleDrop,
    maxFiles: 5,
    accept: {
      'image/jpeg': [],
      'image/png': []
    },
    multiple: true,
  };

  return (
    <Dropzone 
      {...dropzoneProps}
      onDrop={handleDrop}
      maxSize={1024 * 1024}
      onDropRejected={handleRejection}
    >
      {({ getRootProps, getInputProps }) => (
        <div {...getRootProps()} className="max-w-4xl mx-auto text-center">
          <input {...getInputProps()} />
          <div className="my-12 ">
            <h1 className="text-3xl font-bold">Add some photos of your house</h1>
            <p className="mt-2 mb-6 text-gray-400">You can add up to 5 photos with 1 mb maximum size each.</p>
            <div className="flex flex-col mx-10 items-center justify-center w-96 h-96 border-2 border-dashed border-gray-400 rounded-lg">
              <AiOutlineUpload className="text-7xl text-gray-400 mb-2" />
              <p className="text-lg text-gray-400">Upload your images here</p>
            </div>
          </div>
        </div>
      )}
    </Dropzone>
  );
};

export default ImageUploader;
