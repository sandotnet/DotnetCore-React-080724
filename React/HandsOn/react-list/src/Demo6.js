import React from "react";

export default function Demo6() {
  let students = [
    { id: 3424309, name: "Nidhi", age: 11, std: 5, section: "A" },
    { id: 9098909, name: "Faris", age: 11, std: 5, section: "A" },
    { id: 2134567, name: "Sagar", age: 10, std: 5, section: "B" },
    { id: 9878987, name: "Aditya", age: 11, std: 5, section: "A" },
    { id: 3423123, name: "Ann Mary", age: 10, std: 5, section: "B" },
  ];
  return (
    <div className="container">
      <table className="table table-striped">
        <thead>
          <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Age</th>
            <th>Class</th>
            <th>Section</th>
          </tr>
        </thead>
        <tbody>
          {students.map((student) => (
            <tr>
              <td>{student.id}</td>
              <td>{student.name}</td>
              <td>{student.age}</td>
              <td>{student.std}</td>
              <td>{student.section}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}
