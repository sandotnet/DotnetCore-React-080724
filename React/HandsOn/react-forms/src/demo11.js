import { useState } from "react";
const Demo11 = () => {
  const [item, setItems] = useState({
    id: 10,
    name: "keyboard",
    price: 400,
    stock: 10,
  });
  return (
    <>
      <form>
        <table>
          <tr>
            <td>Id</td>
            <td>
              <input
                type="number"
                value={item.id}
                onChange={(e) =>
                  setItems((prevObj) => ({
                    ...prevObj,
                    id: e.target.value,
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
                value={item.name}
                onChange={(e) =>
                  setItems((prevObj) => ({
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
                type="number"
                value={item.price}
                onChange={(e) =>
                  setItems((prevObj) => ({
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
                type="number"
                value={item.stock}
                onChange={(e) =>
                  setItems((prevObj) => ({
                    ...prevObj,
                    stock: e.target.value,
                  }))
                }
              />
            </td>
          </tr>
        </table>
        <hr />
        <pre>
          Id:{item.id} <br />
          Name:{item.name} <br />
          price:{item.price} <br />
          stock:{item.stock} <br />
        </pre>
      </form>
    </>
  );
};
export default Demo11;
