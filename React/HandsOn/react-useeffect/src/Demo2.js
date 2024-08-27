import { useState, useEffect } from "react";
const Demo2 = () => {
  const [count, setCount] = useState(1);
  //it invokes every time when state is updated
  useEffect(() => {
    setCount(count + 1);
  });
  return <h1>The Dom Render {count} times</h1>;
};
export default Demo2;
