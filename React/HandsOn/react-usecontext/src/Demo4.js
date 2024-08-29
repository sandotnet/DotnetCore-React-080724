import React from "react";
import { useContext } from "react";
import { Context } from "./context";
export default function MyComponent() {
  const value = useContext(Context);
  return <div>{value}</div>;
}
