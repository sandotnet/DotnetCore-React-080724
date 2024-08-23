import { useState } from "react";
let items = [
  { id: 1, name: "Hani", std: 1, section: "A" },
  { id: 2, name: "Harsha", std: 2, section: "A" },
  { id: 3, name: "Usama", std: 3, section: "B" },
  { id: 4, name: "Alfia", std: 1, section: "C" },
];
let sections = ["A", "B", "C"];
const MyForm = () => {
  const [id, setId] = useState(0);
  const [name, setName] = useState("");
  const [std, setStd] = useState(0);
  const [section, setSection] = useState("");
  const [students, setStudents] = useState(items);
  const save = (e) => {
    setStudents([ //update student list with new student
      ...students,
      {
        id: id,
        name: name,
        std: std,
        section: section,
      },
    ]);
    e.preventDefault();
  };

  return (
    <div className="container">
      <form onSubmit={save}>
        <table>
          <tr>
            <td>Enter Id</td>
            <td>
              <input
                type="number"
                value={id}
                onChange={(e) => setId(e.target.value)}
              />
            </td>
          </tr>
          <tr>
            <td>Enter Name</td>
            <td>
              <input
                type="text"
                value={name}
                onChange={(e) => setName(e.target.value)}
              />
            </td>
          </tr>
          <tr>
            <td>Enter Std</td>
            <td>
              <input
                type="number"
                value={std}
                onChange={(e) => setStd(e.target.value)}
              />
            </td>
          </tr>
          <tr>
            <td>Enter Section</td>
            <td>
              <select
                value={section}
                onChange={(e) => setSection(e.target.value)}
              >
                {sections.map((section) => (
                  <option>{section}</option>
                ))}
              </select>
            </td>
          </tr>
          <tr>
            <td colSpan={2}>
              <button type="submit">Add</button>
            </td>
          </tr>
        </table>
        <hr />
        <table className="table table-striped">
          <thead>
            <tr>
              <th>Id</th>
              <th>Name</th>
              <th>Class</th>
              <th>Section</th>
            </tr>
          </thead>
          <tbody>
            {students.map((student) => {
              return (
                <tr>
                  <td>{student.id}</td>
                  <td>{student.name}</td>
                  <td>{student.std}</td>
                  <td>{student.section}</td>
                </tr>
              );
            })}
          </tbody>
        </table>
      </form>
    </div>
  );
};
export default MyForm;
