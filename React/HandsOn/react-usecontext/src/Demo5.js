import { Context } from "./context";
import { useContext } from "react";
const Demo5 = () => {
  const user = useContext(Context);
  return <h1>Hello,{user}</h1>;
};
export default Demo5;
