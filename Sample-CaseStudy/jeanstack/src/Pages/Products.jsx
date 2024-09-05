import ProductList from "../Components/ProductList";
import Search from "../Components/Search";
import { Link, useNavigate } from "react-router-dom";
import { useJeansContext } from "../context/JeansContext";
import { useEffect } from "react";
import { toast } from "react-toastify";

const Products = () => {
  let navigate = useNavigate();
  let { user } = useJeansContext();
  useEffect(() => {
    if (!user?.username) {
      toast.info("login to explore");
      navigate("/login");
    }
  }, [user]);
  return (
    <div className="products">
      <Search />
      <ProductList />
    </div>
  );
};
export default Products;
