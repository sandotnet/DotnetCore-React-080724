import React from "react";
import { Link, Outlet } from "react-router-dom";
const UserDashboard = () => {
  return (
    <div>
      <header>
        <h1>E App</h1>
      </header>
      <nav>
        <ul>
          <li>
            <Link to="search">Search</Link>
          </li>
          <li>
            <Link to="view-cart">ViewCart</Link>
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
export default UserDashboard;
