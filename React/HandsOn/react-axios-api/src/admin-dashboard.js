import React, { useState, useEffect } from "react";
import { Link, Outlet } from "react-router-dom";
const AdminDashboard = () => {
  const [uname, setUname] = useState("");
  useEffect(() => {
    let u = sessionStorage.getItem("uname"); //return value from session storage using key
    setUname(u);
  }, []);
  return (
    <div>
      <header>
        <h1>E App</h1>
        <h4 style={{ float: "right", padding: "10px" }}>Welcome {uname}</h4>
      </header>
      <nav>
        <ul>
          <li>
            <Link to="getall">ViewProducts</Link>
          </li>
          <li>
            <Link to="add">Add Products</Link>
          </li>
          <li>
            <Link to="/login">LogOut</Link>
          </li>
        </ul>
      </nav>
      <main>
        <Outlet />
      </main>
      <footer>
        <h2>
          All Rights Reserver@<a href="#">AbcShool</a> 2024-25
        </h2>
      </footer>
      {/* Outlet is like a placeholder and all requested routes are render to Outlet element  */}
    </div>
  );
};
export default AdminDashboard;
