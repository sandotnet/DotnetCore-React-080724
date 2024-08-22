import React from "react";

function User() {
  return (
    <div>
      <h1>Welcome User..</h1>
    </div>
  );
}

function Guest() {
  return (
    <div>
      <h1>Welcome Guest..</h1>
    </div>
  );
}
function Login(props) {
  const isLogged = props.isLoggedIn;

  //   if (isLogged) {
  //     return <User />;
  //   } else {
  //     return <Guest />;
  //   }
  return isLogged ? <User /> : <Guest />;
}
export default Login;
