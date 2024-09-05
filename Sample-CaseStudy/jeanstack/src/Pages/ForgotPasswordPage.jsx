import axios from "axios";
import { useEffect, useState } from "react";
import { MdMarkEmailUnread } from "react-icons/md";
import { PiPassword } from "react-icons/pi";
import { RiLockPasswordLine } from "react-icons/ri";
import { useNavigate } from "react-router-dom";
import "../Components/Login.css";
const ForgotPasswordPage = () => {
  let [oldPassword, setOldPassword] = useState("");
  let [newPassword, setNewPassword] = useState("");
  let [email, setEmail] = useState("");
  let [status, setStatus] = useState("update");
  let navigate = useNavigate();
  let handleSubmit = async (e) => {
    e.preventDefault();
    setStatus("updating...");
    try {
      await axios.put("http://localhost:5287/user/update-password", {
        email,
        old_password: oldPassword,
        new_password: newPassword,
      });
      setStatus("updated");
    } catch (err) {
      console.log(err);
    }
  };
  useEffect(() => {
    if (status == "updated") {
      setTimeout(() => {
        navigate("/login");
      }, 1000);
    }
  }, [status]);
  return (
    <div className="login-container">
      <form onSubmit={handleSubmit}>
        <div>
          <label htmlFor="email">Enter Email Id</label>
          <div className="input-container">
            <input
              type="text"
              id="email"
              name="email"
              value={email}
              onChange={(e) => setEmail(e.target.value)}
            />
            <MdMarkEmailUnread />
          </div>
        </div>
        <div>
          <label htmlFor="password">Enter Old Password</label>
          <div className="input-container">
            <input
              type="password"
              id="password"
              onChange={(e) => setOldPassword(e.target.value)}
              value={oldPassword}
            />
            <RiLockPasswordLine />
          </div>
        </div>
        <div>
          <label htmlFor="password">Enter New Password</label>
          <div className="input-container">
            <input
              type="password"
              id="password"
              onChange={(e) => setNewPassword(e.target.value)}
              value={newPassword}
            />
            <RiLockPasswordLine />
          </div>
        </div>
        <button className="btn login-btn">{status}</button>
      </form>
    </div>
  );
};
export default ForgotPasswordPage;
