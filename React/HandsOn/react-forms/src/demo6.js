import { React, useState } from "react";
let stds = [1, 2, 3, 4, 5];
const MyForm = () => {
  const [std, setStd] = useState(1);

  return (
    <div className="container">
      <label>Select Class</label>
      <div className="col">
        <select value={std} onChange={(e) => setStd(e.target.value)}>
          {stds.map((s) => (
            <option value={s}>{s}</option>
          ))}
        </select>
      </div>
      <span>Selected Class:{std}</span>
    </div>
  );
};
export default MyForm;
