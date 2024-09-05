import { useState, useEffect } from "react";
import { useNavigate } from "react-router-dom";
import axios from "axios";
import { RoleContext } from "./MyContexts";
const GetProducts = () => {
  const [items, GetItems] = useState([]);
  const navigate = useNavigate();
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
  const Update = (productId) => {
    sessionStorage.setItem("Pid", productId);
    navigate("/admin-dashboard/update");
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
                  <button onClick={() => Update(i.productId)}>Update</button>
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
