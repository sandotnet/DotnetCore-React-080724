import React, { Fragment, useRef } from "react";
const Demo = () => {
  const msgRef = useRef("GoodMorning!!");
  return (
    <Fragment>
      <div>
        <h1>{msgRef.current}</h1>
      </div>
    </Fragment>
  );
};
export default Demo;
