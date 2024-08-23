import React, { useState } from "react";

export default function Demo1() {
  const [color, setColor] = useState("Red");
  const handler = () => {
    if (color === "Red") setColor("Green"); //update the color state
    else setColor("Red");
  };
  return (
    <>
      <h1 style={{ color: `${color}` }}>My favourite Color:{color}</h1>
      <button onClick={handler}>Change</button>
    </>
  );
}
