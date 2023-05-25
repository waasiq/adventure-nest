import React, { createContext, useEffect, useState } from "react";
import { IPublication, IProperty, IResponse } from "../types/types";

// Context Interface
interface IPublicationContextType {
  publication: IPublication | null;
  setPublication: React.Dispatch<React.SetStateAction<IPublication | null>>;
  property: IProperty | null;
  setProperty: React.Dispatch<React.SetStateAction<IProperty | null>>;
}

// Context
export const PublicationContext = createContext<IPublicationContextType>(
  {} as IPublicationContextType
);

// Provider
interface IProviderProps {
  children: React.ReactNode;
}

// Provider Component
export const PublicationProvider: React.FC<IProviderProps> = ({ children }) => {
   const [publication, setPublication] = useState<IPublication | null>(null); 
   const [property, setProperty] = useState<IProperty | null>(null);

  return (
    <PublicationContext.Provider
      value={{
        publication,
        setPublication,
        property,
        setProperty,
      }}
    >
      {children}
    </PublicationContext.Provider>
  );
};
