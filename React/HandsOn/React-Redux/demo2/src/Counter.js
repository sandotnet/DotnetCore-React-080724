import Reducer from "./reducer";
import { createStore } from "redux";
import { useState } from "react";
//create store
const store = createStore(Reducer);

const Counter = () => {
  const [count, setCount] = useState(0);
  const increment = () => {
    store.dispatch({ type: "INCREMENT" });
    console.log(store.getState());
    setCount(store.getState());
  };
  const decrement = () => {
    store.dispatch({ type: "DECREMENT" });
    console.log(store.getState());
    setCount(store.getState());
  };
  return (
    <>
      <h1>{count}</h1>
      <button onClick={increment}>Increment</button>
      <button onClick={decrement}>Decrement</button>
    </>
  );
};
export default Counter;
