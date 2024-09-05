import { useState } from "react";
import {
  ADD_TO_CART,
  DELETE_PRODUCT,
  useJeansContext,
} from "../context/JeansContext";
import "./ProductDetail.css";
import axios from "axios";
import { Link, useNavigate } from "react-router-dom";
import { addToCart, getCarts } from "../../data/Api";
import { toast } from "react-toastify";
const ProductSingle = ({ product }) => {
  let navigate = useNavigate();
  let { dispatch } = useJeansContext();
  let [status, setStatus] = useState("AddToCart");
  let { user } = useJeansContext();
  let addtocart = async () => {
    console.log(product);
    let userId = JSON.parse(localStorage.getItem("user")).userId;
    let existingCarts = await getCarts();
    let isCart = existingCarts?.find((p) => p?.productId == product?.id);
    console.log(isCart);

    if (isCart?.id) {
      let res = await addToCart({ ...isCart });
      dispatch({ type: ADD_TO_CART, payload: { ...res.data } });
      setStatus("ADDED");
      setTimeout(() => {
        setStatus("AddToCart");
      }, 1000);
      return;
    } else {
      let res = await addToCart({
        ...product,
        userId,
        id: 0,
        productId: product.id,
      });
      console.log("added", res.data);
      dispatch({ type: ADD_TO_CART, payload: { ...res.data } });
      toast.success("Added");
      setStatus("ADDED");

      setTimeout(() => {
        setStatus("AddToCart");
      }, 1000);
    }
  };
  let handleDelete = async () => {
    await axios.delete(`http://localhost:5287/products/${product.id}`, {
      headers: {
        Authorization: `Bearer ${
          JSON.parse(localStorage.getItem("user")).token
        }`,
      },
    });
    toast.dismiss("product deleted");
    dispatch({ type: DELETE_PRODUCT, payload: product.id });
    navigate("/products");
  };
  return (
    <div className="product-detail">
      <img src={product.image} />
      <div className="product-content">
        <h2>{product.brand}</h2>
        <h3>{product.name}</h3>
        <p>{product.description}</p>
        <p>size:{product.size}</p>
        <p>category:{product.category}</p>
        <p>qty:{product.quantity}</p>
        <blockquote>Price:{product.price}$</blockquote>
        {user?.username ? (
          <>
            <button className="add_to_cart" onClick={addtocart}>
              {status}
            </button>
            <Link className="go_to_cart" to="/cart">
              Go to cart
            </Link>
          </>
        ) : (
          <>
            <button className="add_to_cart" onClick={() => navigate("/login")}>
              Login
            </button>
          </>
        )}

        {user?.username && user.type == "admin" && (
          <>
            <button className="delete-btn" onClick={handleDelete}>
              Delete
            </button>
            <Link className="edit-btn" to={`/products/edit/${product.id}`}>
              EditProduct
            </Link>
          </>
        )}
      </div>
    </div>
  );
};
export default ProductSingle;
