import React, { useState } from "react";
import { FaUserCircle, FaSignInAlt } from "react-icons/fa";
import { RiLockPasswordLine } from "react-icons/ri";
import "./Login.css";
import {
  LOAD_CART,
  LOGIN_USER,
  useJeansContext,
} from "../context/JeansContext";
import { fetchUsers, getCarts } from "../../data/Api";
import { Link } from "react-router-dom";
import { toast } from "react-toastify";

const Login = () => {
  const { dispatch } = useJeansContext();
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");
  // let [type, setType] = useState("admin");
  const loginHandler = async (e) => {
    e.preventDefault();
    // Perform login logic with username and password
    let user = await fetchUsers({ username, password });
    // let isUser = users.find((user) => user.username === username);
    if (!user.ok) {
      toast.error(user.msg);
      return;
    }
    console.log(user);
    toast.success(`${user?.data.username} logged in`);
    localStorage.setItem("user", JSON.stringify(user.data));
    dispatch({
      type: LOGIN_USER,
      payload: user.data,
    });
    let cart = await getCarts();
    console.log("cart", cart);
    dispatch({ type: LOAD_CART, payload: cart });
  };

  return (
    <div className="login-container">
      <form onSubmit={loginHandler}>
        <div>
          <label htmlFor="username">Enter Username</label>
          <div className="input-container">
            <input
              type="text"
              id="username"
              value={username}
              onChange={(e) => setUsername(e.target.value)}
            />
            <FaUserCircle />
          </div>
        </div>
        <div>
          <label htmlFor="password">Enter Password</label>
          <div className="input-container">
            <input
              type="password"
              id="password"
              value={password}
              onChange={(e) => setPassword(e.target.value)}
            />
            <RiLockPasswordLine />
          </div>
        </div>
        {/* <div className="login-type">
          <label>Choose Type:</label>
          <select value={type} onChange={(e) => setType(e.target.value)}>
            <option value="admin">admin</option>
            <option value="customer">customer</option>
          </select>
        </div> */}
        <Link className="forgot" to="/updatePassword">
          Forgot Password
        </Link>
        <button className="login-btn btn" type="submit">
          Login <FaSignInAlt />
        </button>
      </form>
    </div>
  );
};

export default Login;
