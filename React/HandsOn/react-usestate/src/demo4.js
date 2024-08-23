import React, { useState } from "react";

export default function Demo4() {
  const [item, setItems] = useState({
    id: 0,
    name: "",
    price: 0,
    stock: 0,
  });
  return (
    <div>
      <form>
        <table>
          <tr>
            <td>Id</td>
            <td>
              <input
                type="number"
                onChange={(e) =>
                  setItems((prv) => ({
                    ...prv,
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
                onChange={(e) =>
                  setItems((prv) => ({
                    ...prv,
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
                onChange={(e) =>
                  setItems((prv) => ({
                    ...prv,
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
                onChange={(e) =>
                  setItems((prv) => ({
                    ...prv,
                    stock: e.target.value,
                  }))
                }
              />
            </td>
          </tr>
        </table>
        <hr />
        <div>
          <h1>Id:{item.id}</h1>
          <h1>Name:{item.name}</h1>
          <h1>Price:{item.price}</h1>
          <h1>Stock:{item.stock}</h1>
        </div>
      </form>
    </div>
  );
}
