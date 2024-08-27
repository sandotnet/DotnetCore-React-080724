import { useState, useEffect } from "react";
const Demo4 = () => {
  const [count, setCount] = useState(1);
  const [tick, setTick] = useState(0);
  //useEffence invokes every time when tick value is updated
  useEffect(() => {
    setCount(count + 2);
  }, [tick]);
  const HandleTick = () => {
    setTick(tick + 1);
  };
  return (
    <>
      <h1>Your Dom Render {count} times</h1>
      <button onClick={HandleTick}>Click</button>
    </>
  );
};
export default Demo4;
