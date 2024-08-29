import React, { Fragment, useRef } from "react";
const Demo0 = () => {
  const focusPoint = useRef(null);
  const onclickHandler = () => {
    focusPoint.current.value = "The quick brown fox jumps over the lazy dog";
    focusPoint.current.focus();
  };
  return (
    <Fragment>
      <div>
        <button onClick={onclickHandler}>Action</button>
      </div>
      <label>Click on the action button to focus and populate the text.</label>
      <br />
      <textarea ref={focusPoint} />
    </Fragment>
  );
};
export default Demo0;
