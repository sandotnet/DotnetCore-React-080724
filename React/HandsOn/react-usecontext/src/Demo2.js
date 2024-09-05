import { createContext, useState, useContext } from "react";
const userContext = createContext("Raj"); //create context object
function Component1() {
  const [user, setUser] = useState("Santhosh");
  return (
    <>
      <userContext.Provider value={user}>
        {/* set value to the userContext */}
        <h1>Hello, {user}</h1>
        <button onClick={() => setUser("Virat")}>Click</button>
        <Component2 />
      </userContext.Provider>
    </>
  );
}
function Component2() {
  const user = useContext(userContext);
  return (
    <>
      <h2>"Hello "+{user}</h2>
    </>
  );
}

export default Component1;
