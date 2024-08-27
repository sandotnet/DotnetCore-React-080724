import { useState, useEffect } from "react";
const Demo3 = () => {
  const [count, setCount] = useState(1);
  //passing dependency object can invoke the function only once
  useEffect(() => {
    setCount(count + 1);
  }, []);
  return <h1>The Dom Render {count} times</h1>;
};
export default Demo3;
