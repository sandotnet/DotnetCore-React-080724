import { React, useState } from "react";
const MyForm = () => {
  const [uname, setName] = useState("");
  const [names, setNames] = useState([]);
  const save = (e) => {
    setNames([...names, uname]);
    e.preventDefault();
  };
  return (
    <div className="container">
      <form onSubmit={save}>
        <table
          className="table table-bordered"
          style={{ width: "400px", marginTop: "20px" }}
        >
          <tbody>
            <tr>
              <td>Enter Name</td>
              <td>
                <input
                  type="text"
                  value={uname}
                  onChange={(e) => setName(e.target.value)} //e.target.value returns textbox value
                  className="form-control"
                />
              </td>
            </tr>
            <tr>
              <td colSpan={2}>
                <button
                  type="submit"
                  className="btn btn-primary"
                  //   onClick={save}
                >
                  Submit
                </button>
              </td>
            </tr>
          </tbody>
        </table>

        <hr />
        <ul>
          {names.map((n) => (
            <li>{n}</li>
          ))}
        </ul>
        <hr />
        <table className="table table-striped">
          <thead>
            <tr>
              <th>Name</th>
            </tr>
          </thead>
          <tbody>
            {names.map((n) => (
              <tr>
                <td>{n}</td>
              </tr>
            ))}
          </tbody>
        </table>
      </form>
    </div>
  );
};
export default MyForm;
