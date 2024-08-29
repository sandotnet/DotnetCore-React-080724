import logo from "./logo.svg";
import "./App.css";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import Home from "./User/home";
import About from "./User/about";
import Contact from "./User/contact";
import Courses from "./User/courses";
import NoPage from "./nopage";
import Layout from "./User/Layout";
import Login from "./User/Login";
import AdminDashboard from "./Admin/admin-dashboard";
import AddStudent from "./Admin/add-student";
import AddTeacher from "./Admin/add-teacher";
import StudentDashboard from "./Student/student-dashboard";
import TeacherDashboard from "./Teacher/teacher-dashboard";
import TakeExam from "./Student/take-exam";
import ShowMarks from "./Student/show-marks";
import GetMarks from "./Teacher/get-marks";
import ScheduleExam from "./Teacher/schedule-exam";
import Template from "./User/template";

function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<Layout />}>
            <Route index element={<Home />} />
            <Route path="about" element={<About />} />
            <Route path="contact" element={<Contact />} />
            <Route path="courses" element={<Courses />} />
            <Route path="login" element={<Login />} />
            <Route path="template" element={<Template />} />
          </Route>
          <Route path="admin-dashboard" element={<AdminDashboard />}>
            <Route path="add-student" element={<AddStudent />} />
            <Route path="add-teacher" element={<AddTeacher />} />
          </Route>
          <Route path="student-dashboard" element={<StudentDashboard />}>
            <Route path="take-exam" element={<TakeExam />} />
            <Route path="show-marks" element={<ShowMarks />} />
          </Route>
          <Route path="teacher-dashboard" element={<TeacherDashboard />}>
            <Route path="schedule-exam" element={<ScheduleExam />} />
            <Route path="get-marks" element={<GetMarks />} />
          </Route>
          <Route path="*" element={<NoPage />} />
        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
