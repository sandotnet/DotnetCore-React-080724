import React, { useRef } from "react";

export default function Demo3() {
  const uname = useRef();
  const age = useRef();
  const onSubmit = (e) => {
    e.preventDefault();
    alert(`Hello ${uname.current.value} you are ${age.current.value} old!!`);
  };
  return (
    <div>
      <form>
        <table>
          <tr>
            <td>Enter Name</td>
            <td>
              <input type="text" ref={uname} />
            </td>
          </tr>
          <tr>
            <td>Enter Age</td>
            <td>
              <input type="number" ref={age} />
            </td>
          </tr>
          <tr>
            <td colSpan={2}>
              <button onClick={onSubmit}>Submit</button>
            </td>
          </tr>
        </table>
      </form>
    </div>
  );
}
