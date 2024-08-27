import { useState, useEffect } from "react";
import axios from "axios";
const UpdateProduct = () => {
  const [product, SetProduct] = useState({
    productId: 0,
    name: "",
    stock: 0,
    price: 0,
  });
  const [err, setError] = useState("");
  //   useEffect(() => {
  //     axios.get("http://localhost:5005/api/Product/GetProduct/5").then((res) => {
  //       console.log(res);
  //       SetProduct(res.data);
  //     });
  //   }, []);
  const save = () => {
    console.log(product);
    axios
      .put("http://localhost:5005/api/Product/EditProduct", product)
      .then((res) => {
        console.log(res.data);
      })
      .catch((err) => console.log(err));
  };
  const remove = () => {
    axios
      .delete("http://localhost:5005/api/Product/DeleteProduct?id=3")
      .then((res) => {})
      .catch((err) => console.log(err));
  };
  const search = (e) => {
    let productId = product.productId;
    console.log(productId);
    axios
      .get("http://localhost:5005/api/Product/GetProduct/" + productId)
      .then((res) => {
        console.log(res);
        if (res.statusText !== "No Content") SetProduct(res.data);
        else {
          setError("Invalid Id");
        }
      });
    e.preventDefault();
  };
  return (
    <div className="container">
      <form onSubmit={save}>
        <table className="table">
          <tr>
            <td>Id</td>
            <td>
              <input
                type="text"
                value={product.productId}
                onChange={(e) =>
                  SetProduct((prevObj) => ({
                    ...prevObj,
                    productId: e.target.value,
                  }))
                }
              />
            </td>
          </tr>
          <tr>
            <td>Name</td>
            <td>
              <input
                type="text"
                value={product.name}
                onChange={(e) =>
                  SetProduct((prevObj) => ({
                    ...prevObj,
                    name: e.target.value,
                  }))
                }
              />
            </td>
          </tr>
          <tr>
            <td>Price</td>
            <td>
              <input
                type="text"
                value={product.price}
                onChange={(e) =>
                  SetProduct((prevObj) => ({
                    ...prevObj,
                    price: e.target.value,
                  }))
                }
              />
            </td>
          </tr>
          <tr>
            <td>Stock</td>
            <td>
              <input
                type="text"
                value={product.stock}
                onChange={(e) =>
                  SetProduct((prevObj) => ({
                    ...prevObj,
                    stock: e.target.value,
                  }))
                }
              />
            </td>
          </tr>
          <tr>
            <td colSpan={2}>
              <button type="submit">Edit</button>
              <button onClick={remove}>Delete</button>
              <button onClick={search}>Search</button>
            </td>
          </tr>
          <tr>
            <td colSpan={2}>
              <span>{err}</span>
            </td>
          </tr>
        </table>
      </form>
    </div>
  );
};
export default UpdateProduct;
