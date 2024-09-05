import { useNavigate } from "react-router-dom";
import Login from "../Components/Login";
import { useJeansContext } from "../context/JeansContext";
import { useEffect } from "react";

const LoginPage = () => {
  let navigate = useNavigate();
  let { user } = useJeansContext();
  useEffect(() => {
    if (user?.username) {
      navigate("/products");
    }
  }, [user]);
  return (
    <>
      <Login />
    </>
  );
};
export default LoginPage;
