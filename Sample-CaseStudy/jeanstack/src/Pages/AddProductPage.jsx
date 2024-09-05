import { useNavigate } from "react-router-dom";
import AddProduct from "../Components/AddProduct";
import { useJeansContext } from "../context/JeansContext";
import { useEffect } from "react";

const AddProductPage = () => {
  let navigate = useNavigate();
  let { user } = useJeansContext();
  useEffect(() => {
    if (!user?.username || !user?.type == "admin") {
      navigate("/products");
    }
  }, [user]);
  return (
    <>
      <AddProduct />
    </>
  );
};
export default AddProductPage;
