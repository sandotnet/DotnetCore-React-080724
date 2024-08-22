import React from "react";

const MyComponent1 = () => {
  return React.createElement(
    "div",
    null,
    React.createElement("h1", null, "Hello,JSX!!"),
    React.createElement("p", null, 
    "This is React Component using JSX!!")
  );
};
export default MyComponent1;
