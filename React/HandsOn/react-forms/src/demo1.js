import { React, useState } from "react";
const MyForm = () => {
  //initialize the state
  let [uname, setName] = useState("");
  const Greet = () => {
    alert("Hello " + uname);
  };
  return (
    <div>
      <form>
        <table>
          <tr>
            <td>Enter Name</td>
            <td>
              <input type="text" value={uname} onChange={(e) => setName(e.target.value)} />
            </td>
          </tr>
          <tr>
            <td colSpan={2}>
              <button onClick={Greet}>Greet</button>
            </td>
          </tr>
        </table>
      </form>
    </div>
  );
};
export default MyForm;
