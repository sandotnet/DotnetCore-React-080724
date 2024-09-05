import { useNavigate } from "react-router-dom";
import SignUp from "../Components/SignUp";
import { useJeansContext } from "../context/JeansContext";
import { useEffect } from "react";

const SignUpPage = () => {
  let navigate = useNavigate();
  let { user } = useJeansContext();
  useEffect(() => {
    if (user?.username) {
      navigate("/products");
    }
  }, [user]);
  return (
    <>
      <SignUp />
    </>
  );
};
export default SignUpPage;
