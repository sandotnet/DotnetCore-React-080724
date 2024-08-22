import logo from "./logo.svg";
import "./App.css";
import Message from "./Message";
import Greet from "./Greet";
import Shop from "./Product";
import Garage from "./Car";
import Classroom from "./ClassRoom";
function App() {
  return (
    <div className="App">
      {/* <Message name="Sachin" sport="Cricketer" 
      age={45} />
      <Message name="Virat" sport="Cricketer" 
      age={35} />
      <Message name="Manu" sport="Shooter" 
      age={22} /> */}
      {/* <Greet name="Virat" age="35" city="Delhi">
        <h1>Virat is a Cricketer</h1>
      </Greet> */}
      {/* <Shop /> */}
      {/* <Garage brand="Range Rover" color="black" /> */}
      <Classroom />
    </div>
  );
}

export default App;
