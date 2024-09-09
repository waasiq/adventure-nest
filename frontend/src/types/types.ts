export interface IUser {
    firstname: string;
    lastname: string;
    password?: string;
    email: string;
    picture?: string;
    id?: string;
    [key: string]: any; // Add an index signature
}
  

export interface IPublication {
    id: string;
    createdDate: string;
    description: string;
    isActive: boolean;
    title: string;
    price: number;
    [key: string]: any; // Add an index signature
}
  
export interface IProperty { 
    id: number;
    ownerId: number;
    name: string;
    country: string;
    city: string;
    address: string;
    latitude: number;
    longtitude: number;
    propertyType: string;
    bookingType: number;
    photographsPathList: string[];
    maxGuestCount: number;
    bedroomCount: number;
    bathroomCount: number;
    bedCount: number;
    isBed: boolean;
    isBlender: boolean;
    isCoffeeMaker: boolean;
    isCouch: boolean;
    isGasStove: boolean;
    isMicrowave: boolean;
    isMixingBowl: boolean;
    isRefrigerator: boolean;
    isWashingMachine: boolean;

    createdDate: string;
    [key: string]: any; // Add an index signature
}
  
export  interface IResponse {
    data: IProperty | IPublication | IUser;
    errors: string[] | null;
}