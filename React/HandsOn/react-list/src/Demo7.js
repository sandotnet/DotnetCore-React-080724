import React from "react";

export default function Demo7(props) {
  return (
    <div>
      <ul>
        {props.cities.map((city) => (
          <li>{city}</li>
        ))}
      </ul>
    </div>
  );
}
