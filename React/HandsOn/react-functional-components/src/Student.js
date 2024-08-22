const Student = ({ name, age, std, section }) => {
  return (
    <tr>
      <td>{name}</td>
      <td>{age}</td>
      <td>{std}</td>
      <td>{section}</td>
    </tr>
  );
};

export default Student;
