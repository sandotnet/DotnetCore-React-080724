import React from "react";

export default function Count() {
  let count = 1;
  const CountIt = () => {
    count++;
    console.log(count);
  };
  return (
    <div>
      <h1>{count}</h1>
      <button onClick={CountIt}>Click</button>
    </div>
  );
}
