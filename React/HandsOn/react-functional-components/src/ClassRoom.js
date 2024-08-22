import Student from "./Student";
const Classroom = () => {
  return (
    <div className="container">
      <table className="table table-stripped">
        <thead className="table-dark">
          <tr>
            <th>Name</th>
            <th>Age</th>
            <th>Class</th>
            <th>Section</th>
          </tr>
        </thead>
        <tbody className="table-primary">
          <Student name="Jismon" age="10" std="4" section="A" />
          <Student name="Faris" age="10" std="4" section="B" />
          <Student name="Harsha" age="10" std="4" section="A" />
        </tbody>
      </table>
    </div>
  );
};
export default Classroom;
