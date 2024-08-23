import React from "react";

export default function Football() {
  const shoot = (a, b) => {
    alert("Great " + a);
    alert(b.type); //b rep the react event that triggered the fun
  };
  return (
    <div>
      <button onClick={(event) => shoot("Goal", event)}>Hit!!</button>
    </div>
  );
}
