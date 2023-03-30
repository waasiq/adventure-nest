import React, { useContext } from "react";
import { GoogleOAuthProvider, GoogleLogin } from "@react-oauth/google";
import jwtDecode from "jwt-decode";
import { User, CurrentUserContext } from "../context/CurrentUserContext";

interface decodedData {
  name: string;
  picture: string;
  email: string;
}

const Login: React.FC = () => {
  const { setUser } = useContext(CurrentUserContext);

  const handleLogin = async (res: any) => {
    // data from google API decoded and stored in User object
    const decoded_data: decodedData = jwtDecode(res.credential);

    const User: User = {
      username: decoded_data.name,
      email: decoded_data.email,
      picture: decoded_data.picture,
    };
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
