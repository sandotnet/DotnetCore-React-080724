import React from "react";

export default function Cricket() {
  //Handler
  const Shot = () => {
    alert("Great Shot!!");
  };
  const Shot1 = (a) => {
    alert("Great Shot!! " + a);
  };
  return (
    <div>
      <button onClick={Shot}>Take the Shot!</button>
      <button onClick={() => Shot()}>Take the Shot!</button>
      <button onClick={() => Shot1("Virat")}>Take the Shot!</button>
      <br></br>
      <button onClick={() => Shot1("Rohith")}>Take the Shot!</button>
    </div>
  );
}
