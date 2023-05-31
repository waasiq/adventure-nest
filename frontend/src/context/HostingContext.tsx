import React, { createContext, useEffect, useState } from "react";

// Image Interface
export interface IHost {
    id?: number;
    createdDate?: string;
    ownerId?: number;
    name?: string;
    country?: string;
    city?: string; 
    address?: string;
    propertyType?: string;
    bookingType?: string;
    photographsPathList?: string[];
    maxGuestCount?: number;
    bedroomCount?: number;
    bathroomCount?: number;
    bedCount?: number;

    isRefrigerator?: boolean;
    isTv?: boolean;
    isCouch?: boolean;
    isBed?: boolean;
    isGasStove?: boolean;
    isBlender?: boolean;
    isCoffeeMaker?: boolean;
    isMicrowave?: boolean;
    isMixingBowl?: boolean;
    isWashingMachine?: boolean;

    latitude?: number;
    longitude?: number;

    homeType?: string;
    placeType?: string;
    selectedHomeIcon?: string;
    selectedPlaceIcon?: string;
    images?: any[]; //! Getting lint error don't know type of img obj
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

  useEffect(() => {
      setHost(
      {
        bedroomCount: 1,
        bathroomCount: 1,
        bedCount: 1,
        maxGuestCount: 1,
        bookingType: "Normal",
        isRefrigerator: false,
        isTv: false,
        isCouch: false,
        isBed: false,
        isGasStove: false,
        isBlender: false,
        isCoffeeMaker: false,
        isMicrowave: false,
        isMixingBowl: false,
        isWashingMachine: false,
      } as IHost
    )
  }, []);

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
