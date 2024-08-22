import logo from "./logo.svg";
import "./App.css";
import Demo1 from "./Demo1";
import Demo2 from "./Demo2";
import Demo3 from "./Demo3";
import Garage from "./Demo4";
import Demo5 from "./Demo5";
import Demo6 from "./Demo6";
import Demo7 from "./Demo7";

function App() {
  let cities = ["Bangalore", "Hyderabad", "Trivendram"];
  return (
    <div>
      {/* <Demo2 /> */}
      {/* <Demo3 /> */}
      {/* <Garage /> */}
      {/* <Demo5 /> */}
      {/* <Demo6 /> */}
<Demo7 cities={["Delhi", "Chennai", "Kochi", "Pune"]} />
      <hr />
      <Demo7 cities={cities} />
    </div>
  );
}

export default App;
