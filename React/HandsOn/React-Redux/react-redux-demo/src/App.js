import logo from "./logo.svg";
import "./App.css";
import { createStore } from "redux";
import Counter from "./Counter";
import { useState } from "react";

const reducer = (state = 0, action) => {
  switch (action.type) {
    case "INCREMENT":
      return state + 1;
    case "DECREMENT":
      return state - 1;
    case "RESET":
      return 0;
    default:
      return state;
  }
};
const store = createStore(reducer);

function App() {
  const [state, setState] = useState(0);
  function increment() {
    store.dispatch({ type: "INCREMENT" });
    console.log(store.getState());
    setState(store.getState());
  }
  function decrement() {
    store.dispatch({ type: "DECREMENT" });
    console.log(store.getState());
    setState(store.getState());
  }
  function reset() {
    store.dispatch({ type: "RESET" });
    console.log(store.getState());
    setState(store.getState());
  }
  return (
    <div className="App">
      <Counter
        counter={state}
        increment={() => increment()}
        decrement={decrement}
        reset={reset}
      />
    </div>
  );
}

export default App;
