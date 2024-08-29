//useRef allows you to persist values between renders
//It can be use to access a DOM elements directly
// ex: use UseRef to track application renders
import React, { useState, useEffect, useRef } from "react";

export default function Demo2() {
  const [inputValue, setInputValue] = useState("");
  const count = useRef(0);
  useEffect(() => {
    count.current = count.current + 1;
  });
  return (
    <div>
      <input
        type="text"
        value={inputValue}
        onChange={(e) => setInputValue(e.target.value)}
      />
      <h1>Render Count:{count.current}</h1>
    </div>
  );
}
