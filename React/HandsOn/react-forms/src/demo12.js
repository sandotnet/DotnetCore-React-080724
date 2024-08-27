import { useState } from "react";
const Demo12 = () => {
  const [item, setItem] = useState({
    id: 0,
    name: "",
    price: 0,
    stock: 0,
  });
  const [items, setItems] = useState([]);
  const SaveItem = (e) => {
    console.log(item);

    setItems((prv) => [...prv, item]);

    console.log(items);
    e.preventDefault();
  };
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
                  setItem((prevObj) => ({
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
                  setItem((prevObj) => ({
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
                  setItem((prevObj) => ({
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
                  setItem((prevObj) => ({
                    ...prevObj,
                    stock: e.target.value,
                  }))
                }
              />
            </td>
          </tr>
          <tr>
            <td colSpan={2}>
              <button onClick={SaveItem}>Save</button>
            </td>
          </tr>
        </table>
        <hr />
        <table border={1} className="table table-bordered">
          <thead>
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
                <td>{i.id}</td>
                <td>{i.name}</td>
                <td>{i.price}</td>
                <td>{i.stock}</td>
              </tr>
            ))}
          </tbody>
        </table>
      </form>
    </>
  );
};
export default Demo12;
