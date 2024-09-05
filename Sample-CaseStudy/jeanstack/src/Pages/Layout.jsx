import { ToastContainer } from "react-toastify";
import Navbar from "../Components/Navbar";
import { Outlet } from "react-router-dom";
const Layout = () => {
  return (
    <>
      <ToastContainer autoClose={1000} />
      <Navbar />
      <main>
        <Outlet />
      </main>
    </>
  );
};
export default Layout;
