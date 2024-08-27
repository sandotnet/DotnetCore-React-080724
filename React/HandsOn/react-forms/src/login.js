import { useState } from "react";
const Login = () => {
  const [email, setEmail] = useState("");
  const [pwd, setpwd] = useState("");
  const [msg, setMsg] = useState("");
  const Validate = (e) => {
    if (email === "rohan@gmail.com" && pwd === "12345") {
      setMsg("Valid User");
    } else setMsg("Invalid User");
    e.preventDefault();
  };
  return (
    <form onSubmit={Validate}>
      <table border={1}>
        <tr>
          <td>Email</td>
          <td>
            <input
              type="text" value={email} onChange={(e) => setEmail(e.target.value)}/>
          </td>
        </tr>
        <tr>
          <td>Password</td>
          <td>
            <input
              type="password" value={pwd} onChange={(e) => setpwd(e.target.value)}/>
          </td>
        </tr>
        <tr>
          <td colSpan={2}>
            <input type="submit" value="SignIn" />
          </td>
        </tr>
        <tr>
          <td colSpan={2}>
            <span>{msg}</span>
          </td>
        </tr>
      </table>
    </form>
  );
};
export default Login;
