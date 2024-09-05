import React from "react";
import { Link, Outlet } from "react-router-dom";

export default function Layout() {
  return (
    <div>
      <header>
        <h1>E APP</h1>
      </header>
      <nav>
        <ul>
          <li>
            <Link to="/">Home</Link>
          </li>
          <li>
            <Link to="/about">About</Link>
          </li>
          <li>
            <Link to="/products">products</Link>
          </li>
          <li>
            <Link to="/contact">Contact</Link>
          </li>
          <li>
            <Link to="/login">Login</Link>
          </li>
          <li>
            <Link to="/register">Register</Link>
          </li>
        </ul>
      </nav>
      <main>
        <Outlet />
        {/* Outlet is like a placeholder and all requested routes are render to Outlet element  */}
      </main>
      <footer>
        <h2>
          All Rights Reserver@<a href="#">AbcShool</a> 2024-25
        </h2>
      </footer>
    </div>
  );
}
