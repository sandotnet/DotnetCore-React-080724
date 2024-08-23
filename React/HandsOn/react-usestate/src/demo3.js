import React, { useState } from "react";

export default function Demo3() {
  const [item, setItems] = useState({
    id: 1,
    name: "mouse",
    price: 400,
    stock: 10,
  });
  const updateHandler = () => { //prevstate holds the previous object data while updating the object
    setItems((prevstate) => ({
      ...prevstate,
      price: 500,
      stock: 20,
    }));
  };
  return (
    <div>
      <h1>Id:{item.id}</h1>
      <h1>Name:{item.name}</h1>
      <h1>Price:{item.price}</h1>
      <h1>Stock:{item.stock}</h1>
      <br />
      <button onClick={updateHandler}>Update</button>
    </div>
  );
}
