import React from "react";
//expression with conditional statements
const Ex4 = () => {
  const x = 4;
  let message = "";
  if (x > 4) message = "Good Morning Students";
  else message = "Good Night Students";

  return (
    <>
      <h1>{message}</h1>
      <h2>{x > 4 ? "Good Morning Students" : "Good Night Students"}</h2>
      
    </>
  );
};
export default Ex4;
