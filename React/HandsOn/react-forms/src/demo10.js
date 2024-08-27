import { useState } from "react";
const Demo10 = () => {
  //define state
  const [item, setItems] = useState({
    id: 10,
    name: "keyboard",
    price: 400,
    stock: 10,
  });
  const updateHandler = () => {
    // setItems({
    //   price: 500,
    // });
    //preObj hold/preserve the current object details
    setItems((prevObj) => ({
      ...prevObj,
      price: 500,
      stock: 40,
    }));
  };
  return (
    <>
      <pre>
        Id:{item.id} <br />
        Name:{item.name} <br />
        price:{item.price} <br />
        stock:{item.stock} <br />
      </pre>
      <button onClick={updateHandler}>Update</button>
    </>
  );
};
export default Demo10;
