import React from "react";
import "./App.css";
import { Context } from "./context";
import MyComponent from "./MyComponent";
import Application from "./Application";
import Component1 from "./Demo2";
import Demo5 from "./Demo5";
function App() {
  const value = "My Context Value";
  return (
    // <Context.Provider value={value}>
    //   <MyComponent />
    // </Context.Provider>
    <Application />
    // <Component1 />
    // <Demo5 />
  );
}

export default App;
