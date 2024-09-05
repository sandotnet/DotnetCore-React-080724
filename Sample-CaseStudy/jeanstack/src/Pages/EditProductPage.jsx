import { useNavigate } from "react-router-dom";
import { EditProduct } from "../Components/EditProduct";
import { useEffect } from "react";
import { useJeansContext } from "../context/JeansContext";

const EditProductPage = () => {
  let navigate = useNavigate();
  let { user } = useJeansContext();
  useEffect(() => {
    if ( !user?.username ) {
      
      navigate("/");
    }
  }, [user]);
  return <EditProduct />;
};
export default EditProductPage;
