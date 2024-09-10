import propTypes from "prop-types";
const Greeting = (props) => {
  return <h1>Hello,
    {props.name}</h1>;
};
Greeting.propTypes = {
  name: propTypes.string
};
Greeting.defaultProps = {
  name: "Sachin",
};
export default Greeting;
