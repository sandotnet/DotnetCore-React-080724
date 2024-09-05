import { Link, useNavigate, NavLink } from "react-router-dom";
import { GiHamburgerMenu } from "react-icons/gi";
import { useState } from "react";
import { LOGOUT_USER, useJeansContext } from "../context/JeansContext";
import { toast } from "react-toastify";
const Navbar = () => {
  let navigate = useNavigate();
  let [isOpen, setIsOpen] = useState(false);
  let { user, dispatch } = useJeansContext();
  let handleLogout = () => {
    toast.info(`${user?.username} logged out`);
    localStorage.removeItem("user");
    dispatch({ type: LOGOUT_USER });
    navigate("/");
  };
  return (
    <header>
      <h1>Jean Station</h1>
      <button className="open-btn" onClick={() => setIsOpen(true)}>
        <GiHamburgerMenu />
      </button>
      <nav className={isOpen ? "open" : ""}>
        <button className="close-btn" onClick={() => setIsOpen(false)}>
          X
        </button>
        <ul onClick={() => setIsOpen(false)}>
          <li>
            <NavLink to="/">Home</NavLink>
          </li>
          {user?.username && (
            <>
              <li>
                <NavLink to="/products" end>
                  products
                </NavLink>
              </li>
              <li>
                <NavLink to="/cart">cart</NavLink>
              </li>
              <li>
                <NavLink to="/orders">orders</NavLink>
              </li>
              <li>
                <NavLink to="/editProfile">EditProfile</NavLink>
              </li>
              <li className="flex-button">
                <button className="logout-btn" onClick={handleLogout}>
                  Logout
                </button>
              </li>
            </>
          )}
          {!user?.username && (
            <>
              <li>
                <NavLink to="/login">login</NavLink>
              </li>
              <li>
                <NavLink to="/signup">signup</NavLink>
              </li>
            </>
          )}
          {user?.username && user.type == "admin" && (
            <li>
              <NavLink to="/products/add" end>
                Add Product
              </NavLink>
            </li>
          )}
        </ul>
      </nav>
    </header>
  );
};
export default Navbar;
