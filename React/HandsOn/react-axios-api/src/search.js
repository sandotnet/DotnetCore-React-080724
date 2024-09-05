import { useState, useEffect } from "react";
import axios from "axios";
import Item from "./item";
const Search = () => {
  const [items, GetItems] = useState([]);
  useEffect(() => {
    axios
      .get("http://localhost:5005/api/Product/GetProducts", {
        headers: {
          Authorization: `Bearer ${sessionStorage.getItem("token")}`,
        },
      })
      .then((response) => {
        console.log(response.data);
        GetItems(response.data); //adding response data to items
      })
      .catch((error) => console.log(error));
  }, []);
  const addToCart = (pId) => {
    console.log(sessionStorage.getItem("userId"));

    // e.preventDefault();
    let cart = {
      cartId: "0",
      productId: pId,
      userId: sessionStorage.getItem("userId"),
    };
    console.log(cart);
    axios
      .post("http://localhost:5005/api/Cart/AddToCart", cart)
      .then((response) => {
        console.log(response);
      })
      .catch((error) => console.log(error));
  };
  return (
    <div className="container">
      <table className="table table-bordered table-hover">
        <thead className="table-primary">
          <tr>
            <td>Pic</td>
            <td>Id</td>
            <td>Name</td>
            <td>Price</td>
            <td>Stock</td>
          </tr>
        </thead>
        <tbody>
          {items.map((i) => (
            <Item
              productId={i.productId}
              price={i.price}
              name={i.name}
              stock={i.stock}
              handler={() => addToCart(i.productId)}
            ></Item>
          ))}
        </tbody>
      </table>
    </div>
  );
};
export default Search;
