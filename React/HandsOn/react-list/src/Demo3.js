import React from "react";

export default function Demo3() {
  let employees = ["Rabinson", "Sagar", "Saranya", "Reshma"];
  return (
    <div>
      <table className="table table-striped">
        <thead className="table-primary">
          <tr>
            <th>Employee</th>
          </tr>
        </thead>
        <tbody>
          {employees.map((emp) => (
            <tr>
              <td>{emp}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}
