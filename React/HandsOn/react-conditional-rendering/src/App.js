import logo from "./logo.svg";
import "./App.css";
import Login from "./demo1";
import Garage from "./Garage";
import Mailbox from "./Mailbox";

function App() {
  //const cars = ["Audi", "Hundai"];
  const cars = [];
  return (
    <div className="App">
      <Login isLoggedIn={true} />
      <Garage cars={cars} />
      <Mailbox unreadMessage={0} />
    </div>
  );
}

export default App;
