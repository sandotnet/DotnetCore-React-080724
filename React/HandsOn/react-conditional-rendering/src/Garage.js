import React from "react";

export default function Garage(props) {
  const cars = props.cars;
  return (
    <div>
      Garage
      {cars.length > 0 ? (
        <h2>you have {cars.length} 
        cars in Garage</h2>
      ) : (
        <h2>No cars!! in Garage</h2>
      )}
    </div>
  );
}
