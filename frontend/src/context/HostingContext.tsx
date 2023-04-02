import React, { createContext, useEffect, useState } from "react";

// Image Interface
export interface IHost {
    homeType?: string;
    placeType?: string;
    address?: string;
    latitude?: number;
    longitude?: number;
    numOfGuests?: number;
    numOfBedrooms?: number;
    numOfBeds?: number;
    numOfBathrooms?: number;
    selectedHomeIcon?: string;
    selectedPlaceIcon?: string;
}

// Context Interface
interface IHostContextType {
  host: IHost | null;
  setHost: React.Dispatch<React.SetStateAction<IHost | null>>;
}

// Context
export const HostContext = createContext<IHostContextType>(
  {} as IHostContextType
);

// Provider
interface IProviderProps {
  children: React.ReactNode;
}

// Provider Component
export const HostProvider: React.FC<IProviderProps> = ({ children }) => {
  const [host, setHost] = useState<IHost | null>(null);

  return (
    <HostContext.Provider
      value={{
        host,
        setHost,
      }}
    >
      {children}
    </HostContext.Provider>
  );
};
