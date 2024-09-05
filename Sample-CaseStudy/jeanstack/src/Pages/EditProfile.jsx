import { useContext, useEffect, useState } from "react";
import "../Components/Login.css";
import { LOGOUT_USER, useJeansContext } from "../context/JeansContext";
import { FaSignInAlt, FaUserCircle } from "react-icons/fa";
import { MdMarkEmailUnread } from "react-icons/md";
import { RiLockPasswordLine } from "react-icons/ri";
import { UpdateUser } from "../../data/Api";
import { useNavigate } from "react-router-dom";

const EditProfile = () => {
  //   let { user: existsingUser } = useJeansContext();
  let { user, dispatch } = useJeansContext();
  let [newUser, setNewUser] = useState({});
  let handleChange = (e) => {
    setNewUser((prev) => ({ ...prev, [e.target.name]: e.target.value }));
  };

  let navigate = useNavigate();
  let updateHandler = async (e) => {
    e.preventDefault();
    let data = await UpdateUser(newUser);
    console.log(data);
    setNewUser(data);
    // localStorage.setItem( "user", JSON.stringify( data ) );
    dispatch({ type: LOGOUT_USER });
    localStorage.removeItem("user");
    navigate("/login");
  };
  let { username, email, type } = newUser;
  useEffect(() => {
    setNewUser(JSON.parse(localStorage.getItem("user")));
  }, []);
  useEffect(() => {
    if (!user?.username) {
      navigate("/");
    }
  }, [user?.username]);
  return (
    <div className="login-container">
      <form onSubmit={updateHandler}>
        <div>
          <label htmlFor="username">Enter Username</label>
          <div className="input-container">
            <input
              type="text"
              id="username"
              name="username"
              value={username}
              onChange={handleChange}
            />
            <FaUserCircle />
          </div>
        </div>
        <div>
          <label htmlFor="email">Enter Email Id</label>
          <div className="input-container">
            <input
              type="text"
              id="email"
              name="email"
              value={email}
              onChange={handleChange}
            />
            <MdMarkEmailUnread />
          </div>
        </div>
        {/* <div>
          <label htmlFor="password">Enter New Password</label>
          <div className="input-container">
            <input type="password" id="password" readOnly value={password} />
            <RiLockPasswordLine />
          </div>
        </div> */}
        <div className="login-type">
          <label>Choose Type:</label>
          <select value={type} name="type" onChange={handleChange}>
            <option value="admin">admin</option>
            <option value="customer">customer</option>
          </select>
        </div>
        <button className="login-btn btn" type="submit">
          update <FaSignInAlt />
        </button>
      </form>
    </div>
  );
};
export default EditProfile;
