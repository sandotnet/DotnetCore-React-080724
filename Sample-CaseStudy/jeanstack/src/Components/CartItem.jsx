import { addToCart, removeFromCart } from "../../data/Api";
import {
  ADD_TO_CART,
  REMOVE_FROM_CART,
  useJeansContext,
} from "../context/JeansContext";

const CartItem = ({ product }) => {
  let { dispatch, user } = useJeansContext();
  let remove = async () => {
    await removeFromCart(product.id);
    dispatch({ type: REMOVE_FROM_CART, payload: product });
  };
  let addTocart = async () => {
    let userId = JSON.parse(localStorage.getItem("user")).userId;
    await addToCart({ ...product });
    dispatch({ type: ADD_TO_CART, payload: { ...product } });
  };
  return (
    <div className="cart-item">
      <img src={product.image} alt="" />
      <p>{product.size}</p>
      <p className="product-name">{product.name}</p>
      <p className="product-brand">{product.brand}</p>
      <p className="product-category">{product.category}</p>
      <p className="product-price">{product.price}$</p>
      <p>{(Number(product.qty) * Number(product.price)).toFixed(2)}$</p>
      <div className="qty-btns">
        <button onClick={remove}>-</button>
        <p>{product.qty}</p>
        <button onClick={addTocart}>+</button>
      </div>
    </div>
  );
};
export default CartItem;
