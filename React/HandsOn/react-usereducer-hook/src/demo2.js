import React, { useReducer } from "react";
import "./demo2.css";
const cartReducer = (state, action) => {
  switch (action.type) {
    case "ADD_ITEM":
      return {
        ...state,
        items: [...state.items, action.payload],
      };
    case "REMOVE_ITEM":
      return {
        ...state,
        items: state.items.filter((item) => item.id !== action.payload.id),
      };
    case "CLEAR_CART":
      return {
        ...state,
        items: [],
      };
    default:
      return state;
  }
};
const Demo2 = () => {
  //Initial state for the shopping cart
  const initialState = {
    items: [],
  };
  //useReducer hook to manage state
  const [cartState, dispacth] = useReducer(cartReducer, initialState);
  //Function to add item to cart
  const addItemToCart = (item) => {
    dispacth({ type: "ADD_ITEM", payload: item });
  };
  //Function to remove the item from the cart
  const removeItemFromCart = (item) => {
    dispacth({ type: "REMOVE_ITEM", payload: item });
  };
  //Function to clear cart
  const clearCart = () => {
    dispacth({ type: "CLEAR_CART" });
  };
  return (
    <>
      <div className="shopping-cart">
        <h2>shopping Cart</h2>
        <ul className="product-list">
          {cartState.items.map((item) => (
            <li key={item.id} className="product-item">
              {item.name}- Rs {item.price}
              <button
                className="removeBtn"
                onClick={() => removeItemFromCart(item)}
              >
                Remove
              </button>
            </li>
          ))}
        </ul>
        <button onClick={() => clearCart()}>Clear</button>
        <hr />
        {/* Product list */}
        <h2>Avaialbe Products</h2>
        <ul className="product-list">
          <li className="product-item">
            <button
              onClick={() =>
                addItemToCart({
                  id: 1,
                  name: "Mouse",
                  price: 100,
                })
              }
            >
              Add Product 1 to cart
            </button>
          </li>
          <li className="product-item">
            <button
              onClick={() =>
                addItemToCart({
                  id: 2,
                  name: "Keyboard",
                  price: 200,
                })
              }
            >
              Add Product 2 to cart
            </button>
          </li>
          <li className="product-item">
            <button
              onClick={() =>
                addItemToCart({
                  id: 3,
                  name: "Speaker",
                  price: 1000,
                })
              }
            >
              Add Product 3 to cart
            </button>
          </li>
        </ul>
      </div>
    </>
  );
};

export default Demo2;
