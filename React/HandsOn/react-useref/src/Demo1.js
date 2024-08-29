import React, { useRef } from "react";
//useRef to focus the input
// add a ref attribute to an element to access it directly in the DOM.
export default function Demo1() {
  const inputElement = useRef();
  const focusInput = () => {
    inputElement.current.focus();
    console.log(inputElement.current.value);
  };
  return (
    <>
      <input type="text" ref={inputElement} />
      <button onClick={focusInput} cols={3} rows={5}>
        Focus Input
      </button>
    </>
  );
}
