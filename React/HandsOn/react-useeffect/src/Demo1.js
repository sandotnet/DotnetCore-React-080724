import { useEffect } from "react";
const Demo1 = () => {
    //invokes when component is render
  useEffect(() => {
    console.log("Hello World!!");
  });
  return (
    <>
      <h1>UseEffect Demo!!</h1>
    </>
  );
};
export default Demo1;
