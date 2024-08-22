import React from "react";
//expression with conditional statements
const Ex5 = () => {
  const x = 4;
  let message = "";
  if (x > 4) message = "Good Morning Students";
  else message = "Good Night Students";
  const myElement = <h1>{message}</h1>;
  const myElement1 = (
    <h2>{x > 4 ? "Good Morning Students" : "Good Night Students"}</h2>
  );
  return (
    <>
      {myElement}
      {myElement1}
    </>
  );
};
export default Ex5;
