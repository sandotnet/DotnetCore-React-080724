import { useState } from "react";
import axios from "axios";
import { useNavigate } from "react-router-dom";
import { createContext } from "react";
const Login = () => {
  const [email, setEmail] = useState("");
  const [pwd, setpwd] = useState("");
  const [err, seterr] = useState("");

  const navigate = useNavigate(); //return navigate method
  const Validate = (e) => {
    let user = { email: email, password: pwd };
    console.log(user);
    axios
      .post("http://localhost:5005/api/User/Validate", user)
      .then((response) => {
        console.log(response);
        if (response.data.token === null) {
          seterr("Invalid User Credentials");
        } else {
          let user = response.data;
          console.log(user.token);
          //store taken data
          sessionStorage.setItem("token", user.token);
          console.log(user.usreId);
          sessionStorage.setItem("userId", user.usreId);
          console.log(user);
          if (user.role === "Admin") {
            //navigate to admin dashboard here
            navigate("/admin-dashboard");
            //navigate("/getall");
          } else if (user.role === "User") {
            //navigate to User dashboard hre
            navigate("/user-dashboard");
            //navigate("/getall");
          }
        }
      });
    e.preventDefault();
  };
  return (
    <>
      <form onSubmit={Validate}>
        <table className="table">
          <tr>
            <td>Email</td>
            <td>
              <input
                type="text"
                value={email}
                onChange={(e) => setEmail(e.target.value)}
              />
            </td>
          </tr>
          <tr>
            <td>Password</td>
            <td>
              <input
                type="password"
                value={pwd}
                onChange={(e) => setpwd(e.target.value)}
              />
            </td>
          </tr>
          <tr>
            <td colSpan={2}>
              <button type="submit">Login</button>
            </td>
          </tr>
          <tr>
            <td colSpan={2}>
              <span>{err}</span>
            </td>
          </tr>
        </table>
      </form>
    </>
  );
};
export default Login;
//export const UserContext = createContext(sessionStorage.setItem("userId"));
