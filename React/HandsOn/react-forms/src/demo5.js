import { React, useState } from "react";
const MyForm = () => {
  const [uname, setName] = useState("");
  const [age, setAge] = useState(0);
  const [msg, setMessage] = useState("");
  const handleName = (event) => {
    setName(event.target.value);
  };
  const handleAge = (event) => {
    setAge(event.target.value);
  };
  const handleSubmit = (event) => {
    event.preventDefault();
    setMessage(`Hello ${uname} you are ${age} years Old!!`);
  };

  return (
    <div className="container">
      <form onSubmit={handleSubmit}>
        <table className="table">
          <tr>
            <td>Enter Name</td>
            <td>
              <input
                type="text"
                value={uname}
                onChange={(e) => setName(e.target.value)} //e.target.value returns textbox value
              />
            </td>
          </tr>
          <tr>
            <td>Enter Age</td>
            <td>
              <input
                type="text"
                value={age}
                onChange={(e) => setAge(e.target.value)} //e.target.value returns textbox value
              />
            </td>
          </tr>
          <tr>
            <td colSpan={2}>
              <button>Greet</button>
            </td>
          </tr>
          <tr>
            <td colSpan={2}>
              <span className="text-primary">{msg}</span>
            </td>
          </tr>
        </table>
      </form>
    </div>
  );
};
export default MyForm;
