import React, { useState } from "react";

export default function Demo5() {
  const [items, setItems] = useState([
    {
      id: 1,
      name: "Mouse",
      price: 100,
    },
  ]);
  const [item, setItem] = useState({
    id: 0,
    name: "",
    price: 0,
  });
  const updatehandler = () => {
    console.log(item);
    setItems((prv) => [...prv, item]);
    //setItems([...items,item])
  };

  return (
    <div className="container">
      <table>
        <tr>
          <td>Id</td>
          <td>
            <input
              type="number"
              className="form-control"
              value={item.id}
              onChange={(e) =>
                setItem((pre) => ({ ...pre, id: e.target.value }))
              }
            />
          </td>
        </tr>
        <tr>
          <td>Name</td>
          <td>
            <input
              type="text"
              className="form-control"
              value={item.name}
              onChange={(e) =>
                setItem((pre) => ({ ...pre, name: e.target.value }))
              }
            />
          </td>
        </tr>
        <tr>
          <td>Price</td>
          <td>
            <input
              type="number"
              className="form-control"
              value={item.price}
              onChange={(e) =>
                setItem((pre) => ({ ...pre, price: e.target.value }))
              }
            />
          </td>
        </tr>
        <tr>
          <td colSpan={2}>
            <button onClick={updatehandler}>Add</button>
          </td>
        </tr>
      </table>
      <hr />
      <table className="table table-striped">
        <thead className="table-info">
          <th>Id</th>
          <th>Name</th>
          <th>Price</th>
        </thead>
        <tbody>
          {items.map((i) => (
            <tr key={i.id}>
              <td>{i.id}</td>
              <td>{i.name}</td>
              <td>{i.price}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}
