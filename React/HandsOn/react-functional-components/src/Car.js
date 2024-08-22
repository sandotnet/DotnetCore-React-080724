function Car({ brand, color }) {
  return (
    <>
      <h2>I am a {brand}</h2>
      <h3>with color {color}</h3>
    </>
  );
}
function Garage(props) {
  const brand = "Audi";
  return (
    <>
      <Car brand={brand} color="Red"></Car>
      <hr />
      <Car brand={brand} color="Black"></Car>
      <hr />
      <Car brand={props.brand} color={props.color}></Car>
    </>
  );
}
export default Garage;
