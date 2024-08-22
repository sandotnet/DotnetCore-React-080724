function Message(props) {
  return (
    <h1>
      Hello,
      {props.name} you are
      {props.sport}
      and your are {props.age}
      years old
    </h1>
  );
}
export default Message;
