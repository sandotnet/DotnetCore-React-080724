import { useState } from "react";

const Counter = ({ counter, increment, decrement, reset }) => {
  return (
    <>
      <h1>{counter}</h1>
      <button onClick={increment}>Increment</button>
      <button onClick={decrement}>Decrement</button>
      <button onClick={reset}>Reset</button>
    </>
  );
};
export default Counter;
