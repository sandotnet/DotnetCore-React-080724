import React from "react";
import { Link, Outlet } from "react-router-dom";
export default function Layout() {
  return (
    <div>
      <header>
        <h1>ABC School</h1>
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
            <Link to="/contact">Contact</Link>
          </li>
        </ul>
      </nav>
      <main>
        {/* Outlet is like a placeholder all the requested componentes are render to Outlet component */}
        <Outlet />
      </main>
      <footer>
        <h2>All Rights Reserved @ABC School 2024-25</h2>
      </footer>
    </div>
  );
}
