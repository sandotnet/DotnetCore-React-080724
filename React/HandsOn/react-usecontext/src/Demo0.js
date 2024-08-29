import { useState } from "react";
function Component1() {
  const [user, setUser] = useState("Santhosh");
  return (
    <>
      <h1>Hello, {user}</h1>
      <Component2 user={user} />
    </>
  );
}
function Component2({ user }) {
  return (
    <>
      <h2>Component2</h2>
      <Component3 user={user} />
    </>
  );
}
function Component3({ user }) {
  return (
    <>
      <h2>Component3</h2>
      <Component4 user={user} />
    </>
  );
}
function Component4({ user }) {
  return (
    <>
      <h2>Component4</h2>
      <Component5 user={user} />
    </>
  );
}
function Component5({ user }) {
  return (
    <>
      <h2>Component5</h2>
      <h2>Hello {user} again!!</h2>
    </>
  );
}

export default Component1;
