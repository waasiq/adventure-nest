import React, { createContext, useEffect, useState } from "react";

// User Interface
export interface User {
  username: string;
  email: string;
  picture?: string;
  id?: string;
}

// Context Interface
interface CurrentUserContextType {
  user: User | null;
  setUser: React.Dispatch<React.SetStateAction<User | null>>;
}

// Context
export const CurrentUserContext = createContext<CurrentUserContextType>(
  {} as CurrentUserContextType
);

// Provider
interface ProviderProps {
  children: React.ReactNode;
}

// Provider Component
export const CurrentUserProvider: React.FC<ProviderProps> = ({ children }) => {
  const [user, setUser] = useState<User | null>(null);

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
