import React, { createContext, useEffect, useState } from "react";

// Image Interface
export interface IImage {
    image: Object;
}

// Context Interface
interface IImageContextType {
  images: IImage[];
  setImages: React.Dispatch<React.SetStateAction<IImage[]>>;
}

// Context
export const ImageContext = createContext<IImageContextType>(
  {} as IImageContextType
);

// Provider
interface ProviderProps {
  children: React.ReactNode;
}

// Provider Component
export const ImageProvider: React.FC<ProviderProps> = ({ children }) => {
  const [images, setImages] = useState<IImage[]>([]);

  return (
    <ImageContext.Provider
      value={{
        images,
        setImages,
      }}
    >
      {children}
    </ImageContext.Provider>
  );
};
