import React from "react";
import { Link, Outlet } from "react-router-dom";
const TeacherDashboard = () => {
  return (
    <div>
      <header>
        <h1>ABC School</h1>
      </header>
      <nav>
        <ul>
          <li>
            <Link to="schedule-exam">ScheduleExam</Link>
          </li>
          <li>
            <Link to="get-marks">Get Marks</Link>
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
export default TeacherDashboard;
