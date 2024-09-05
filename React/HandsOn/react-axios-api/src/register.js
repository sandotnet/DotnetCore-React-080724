import { useState, useContext } from "react";
import axios from "axios";
import { useNavigate } from "react-router-dom";
import { RoleContext } from "./MyContexts";
const Register = () => {
  let role = useContext(RoleContext);
  const [user, SetUser] = useState({
    userId: 0,
    name: "",
    email: "",
    password: "",
    role: role,
  });
  const navigate = useNavigate();
  const registerHandler = () => {
    console.log(user);
    axios
      .post("http://localhost:5005/api/User/Register", user)
      .then((response) => {
        console.log(response);
      })
      .catch((error) => console.log(error));
    //navigate to login
    navigate("/login");
  };
  return (
    <form onSubmit={registerHandler}>
      <div class="container">
        <table>
          <tr>
            <td>Name</td>
            <td>
              <input
                type="text"
                value={user.name}
                onChange={(e) =>
                  SetUser((prevObj) => ({
                    ...prevObj,
                    name: e.target.value,
                  }))
                }
              />
            </td>
          </tr>
          <tr>
            <td>Email</td>
            <td>
              <input
                type="text"
                value={user.email}
                onChange={(e) =>
                  SetUser((prevObj) => ({
                    ...prevObj,
                    email: e.target.value,
                  }))
                }
              />
            </td>
          </tr>
          <tr>
            <td>Password</td>
            <td>
              <input
                type="text"
                value={user.password}
                onChange={(e) =>
                  SetUser((prevObj) => ({
                    ...prevObj,
                    password: e.target.value,
                  }))
                }
              />
            </td>
          </tr>
          <tr>
            <td>Role</td>
            <td>
              <select
                value={user.role}
                onChange={(e) =>
                  SetUser((prevObj) => ({
                    ...prevObj,
                    role: e.target.value,
                  }))
                }
              >
                <option value="User">User</option>
                <option value="Admin">Admin</option>
              </select>
            </td>
          </tr>
          <tr>
            <td colSpan={2}>
              <button>Submit</button>
            </td>
          </tr>
        </table>
      </div>
    </form>
  );
};
export default Register;
