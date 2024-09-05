import React, { useState } from "react";
import { FaUserCircle, FaSignInAlt } from "react-icons/fa";
import { RiLockPasswordLine } from "react-icons/ri";
import { MdMarkEmailUnread } from "react-icons/md";
import "./Login.css";
import { useJeansContext } from "../context/JeansContext";
import { PostUser } from "../../data/Api";
import { useNavigate } from "react-router-dom";
import { toast } from "react-toastify";

const SignUp = () => {
  let navigate = useNavigate();
  const { dispatch } = useJeansContext();
  const [username, setUsername] = useState("");
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");

  let [type, setType] = useState("admin");
  const signUpHandler = async (e) => {
    e.preventDefault();
    let res = await PostUser({ email, password, type, username });
    toast.info("user created");
    navigate("/login");
  };

  const handleLoginType = (e) => {
    dispatch({ type: SET_LOGIN_TYPE, payload: e.target.value });
  };

  return (
    <div className="login-container">
      <form onSubmit={signUpHandler}>
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
          <label htmlFor="email">Enter Email Id</label>
          <div className="input-container">
            <input
              type="text"
              id="email"
              value={email}
              onChange={(e) => setEmail(e.target.value)}
            />
            <MdMarkEmailUnread />
          </div>
        </div>
        <div>
          <label htmlFor="password">Enter New Password</label>
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
        <div className="login-type">
          <label>Choose Type:</label>
          <select value={type} onChange={(e) => setType(e.target.value)}>
            <option value="admin">admin</option>
            <option value="customer">customer</option>
          </select>
        </div>
        <button className="login-btn btn" type="submit">
          signup <FaSignInAlt />
        </button>
      </form>
    </div>
  );
};

export default SignUp;
