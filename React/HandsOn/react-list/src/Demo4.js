const Car = (props) => {
  return <li>I am a {props.brand}</li>;
};
const Garage = () => {
  let cars = ["Audi", "Hundai", "Maruti", "Tata"];
  return (
    <div>
      {cars.map((c) => (
        <Car brand={c} />
      ))}
    </div>
  );
};
export default Garage;
