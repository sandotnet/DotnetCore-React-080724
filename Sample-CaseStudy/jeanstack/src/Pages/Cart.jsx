import { useEffect } from "react";
import CartList from "../Components/CartList";
import ProductList from "../Components/ProductList";
import { useJeansContext } from "../context/JeansContext";
import { Navigate, useNavigate } from "react-router-dom";

const Cart = () => {
  let navigate = useNavigate();
  let { user } = useJeansContext();
  // let userId = JSON.parse(localStorage.getItem("user")).userId;
  useEffect(() => {
    if (!user?.username) {
      navigate("/");
    } else {
      navigate("/cart");
    }
  }, [user]);
  return (
    <>
      <CartList />
    </>
  );
};
export default Cart;
