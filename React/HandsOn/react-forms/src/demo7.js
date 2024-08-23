import { React, useState } from "react";
let courses = [
  { id: 1, cname: "React" },
  { id: 2, cname: "SqlServer" },
  { id: 3, cname: "C#.Net" },
  { id: 4, cname: "Asp.net Core" },
];
let course = { id: 0, cname: "" };
const MyForm = () => {
  const [couse, setCourse] = useState(course);

  return (
    <div className="container">
      <label>Select Course</label>
      <div className="col">
        <select
          onChange={(e) =>
            setCourse({
              id: e.target[e.target.selectedIndex].value,
              cname: e.target[e.target.selectedIndex].text,
            })
          }
        >
          {courses.map((course) => (
            <option value={course.id}>{course.cname}</option>
          ))}
        </select>
      </div>
      <span>
        Selected Course for Exam id:{couse.id} Name:{couse.cname}
      </span>
    </div>
  );
};
export default MyForm;
