const Greet = (props) => {
  return (
    <>
      <h1>Hello {props.name}</h1>
      <p>Your are {props.age}</p>
      <p>You living in {props.city}</p>
      {props.children} {/* to render children in the component  */}
    </>
  );
};
export default Greet;
