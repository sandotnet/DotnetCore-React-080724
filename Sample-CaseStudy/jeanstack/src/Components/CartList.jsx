import { Link, useNavigate } from "react-router-dom";
import { useJeansContext } from "../context/JeansContext";
import CartItem from "./CartItem";
import "./CartList.css";
import TotalAmount from "./TotalAmount";
import { placeOrder } from "../../data/Api";
import { useState } from "react";
import { toast } from "react-toastify";
const CartList = () => {
  let { cart } = useJeansContext();
  let navigate = useNavigate();
  let userId = localStorage.getItem("user")?.userId;
  let [status, setStatus] = useState("Place Order");
  let total = cart.reduce((acc, product) => {
    acc += product.qty * product.price;
    return acc;
  }, 0);
  if (cart.length == 0) {
    return (
      <div className="cart-message">
        <p>You have no products in cart</p>
        <Link to="/products">Browse Products</Link>
      </div>
    );
  }
  // let carts = cart.filter((item) => item.userId == userId);
  let placeorder = async () => {
    setStatus("placing order...");
    try {
      let order = {
        id: 0,
        orderDate: new Date().toISOString(), // Use current date and time
        // Carts: cart,
        userId: JSON.parse(localStorage.getItem("user"))?.userId,
        totalAmount: total,
      };
      console.log(order);
      await placeOrder(order);
      toast.success("order placed successfully");
      console.log("Order placed successfully!");
      navigate("/orders");
    } catch (error) {
      console.error("Error placing order:", error);
      // Handle the error, e.g., show an error message to the user
    }
  };
  return (
    <div className="cart">
      <div className="cart-list">
        <div className="cart-item row-1">
          <p className="image"></p>
          <p>size</p>
          <p>Name</p>
          <p>brand</p>
          <p>category</p>
          <p>price</p>
          <p>Total</p>
        </div>
        {cart?.map((product) => {
          return product
            ? product && <CartItem product={product} key={product.id} />
            : null;
        })}
      </div>
      {total > 0 && <TotalAmount total={total} />}
      <button className="place-order-button" onClick={placeorder}>
        {status}
      </button>
    </div>
  );
};
export default CartList;
