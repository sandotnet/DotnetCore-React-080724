import { React, useState } from "react";
const MyForm = () => {
  let [uname, setName] = useState("");
  const submitForm = (e) => {
    alert("Hello " + uname);
    e.preventDefault(); //prevents form submission to the server
  };
  return (
    <div className="container">
      <form onSubmit={submitForm}>
        <table
          className="table table-bordered"
          style={{ width: "400px", marginTop: "20px" }}
        >
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
              <button type="submit" className="btn btn-primary">
                Submit
              </button>
            </td>
          </tr>
        </table>
      </form>
    </div>
  );
};
export default MyForm;
