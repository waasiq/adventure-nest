import React, { useContext } from "react";
import { GoogleOAuthProvider, GoogleLogin } from "@react-oauth/google";
import jwtDecode from "jwt-decode";
import { CurrentUserContext } from "../context/CurrentUserContext";
import { postAPIHandler } from "../api/apiHandler";
import { IUser } from "../types/types";

interface IDecodedData {
  given_name: string;
  family_name: string;
  password: string;
  picture: string;
  email: string;
}

const Login: React.FC = () => {
  const { setUser } = useContext(CurrentUserContext);

  const handleLogin = async (res: any) => {
    // data from google API decoded and stored in User object
    const decoded_data: IDecodedData = jwtDecode(res.credential);
    console.log(decoded_data)

    const User: IUser = {
      firstname: decoded_data.given_name,
      lastname: decoded_data.family_name,
      password: "string",
      email: decoded_data.email,
      picture: decoded_data.picture,
    };

    // User object sent to backend to be stored in database
    try {
      // await postAPIHandler("/users", User); // if user already exists just register token
    } catch (error) {
      console.log(error);
    }

    setUser(User);
    localStorage.setItem("user", JSON.stringify(User));
  };

  return (
    <div>
      <GoogleOAuthProvider
        clientId={process.env.REACT_APP_GOOGLE_CLIENT_ID as string}
      >
        <GoogleLogin onSuccess={handleLogin} />
      </GoogleOAuthProvider>
    </div>
  );
};

export default Login;
