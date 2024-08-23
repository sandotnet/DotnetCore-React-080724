import { useState } from "react";
const Demo = () => {
  //set state
  const [count, SetCount] = useState(1);
  const Increment = () => {
    SetCount(count + 1); //updating state count value
  };
  const Decrement = () => {
    SetCount(count - 1); //updating state count value
  };
  return (
    <>
      <h1>{count}</h1>
      <button onClick={Increment}>Increment</button>
      <button onClick={Decrement}>Decrement</button>
    </>
  );
};
export default Demo;
