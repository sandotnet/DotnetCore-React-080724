import { useState } from "react";
import axios from "axios";
const AddProduct = () => {
  const [product, SetProduct] = useState({
    productId: 0,
    name: "",
    stock: 0,
    price: 0,
  });
  const save = () => {
    console.log(product);
    axios
      .post("http://localhost:5005/api/Product/AddProduct", product)
      .then((res) => {
        console.log(res.data);
      })
      .catch((err) => console.log(err));
  };
  return (
    <div className="container">
      <form onSubmit={save}>
        <table className="table">
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
              <button type="submit">Save</button>
            </td>
          </tr>
        </table>
      </form>
    </div>
  );
};
export default AddProduct;
