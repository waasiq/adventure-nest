import React, { createContext, useEffect, useState } from "react";

// User Interface
export interface IUser {
  firstname: string;
  lastname: string;
  password?: string;
  email: string;
  picture?: string;
  id?: string;
}

// Context Interface
interface ICurrentUserContextType {
  user: IUser | null;
  setUser: React.Dispatch<React.SetStateAction<IUser | null>>;
}

// Context
export const CurrentUserContext = createContext<ICurrentUserContextType>(
  {} as ICurrentUserContextType
);

// Provider
interface IProviderProps {
  children: React.ReactNode;
}

// Provider Component
export const CurrentUserProvider: React.FC<IProviderProps> = ({ children }) => {
  const [user, setUser] = useState<IUser | null>(null);

  useEffect(() => {
    const user = localStorage.getItem("user");
    if (user) {
      setUser(JSON.parse(user));
    }
  }, []);

  return (
    <CurrentUserContext.Provider
      value={{
        user,
        setUser,
      }}
    >
      {children}
    </CurrentUserContext.Provider>
  );
};
