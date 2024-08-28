import { useState, useEffect } from "react";
import axios from "axios";
const GetProducts = () => {
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
  const Remove = (productId) => {
    console.log(productId);
    axios
      .delete("http://localhost:5005/api/Product/DeleteProduct?id=" + productId)
      .then((res) => {})
      .catch((err) => console.log(err));
  };
  return (
    <div className="container">
      <form>
        <table className="table table-bordered table-hover">
          <thead className="table-primary">
            <tr>
              <td>Id</td>
              <td>Name</td>
              <td>Price</td>
              <td>Stock</td>
            </tr>
          </thead>
          <tbody>
            {items.map((i) => (
              <tr>
                <td>{i.productId}</td>
                <td>{i.name}</td>
                <td>{i.price}</td>
                <td>{i.stock}</td>
                <td>
                  <button onClick={() => Remove(i.productId)}>Delete</button>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </form>
    </div>
  );
};
export default GetProducts;
