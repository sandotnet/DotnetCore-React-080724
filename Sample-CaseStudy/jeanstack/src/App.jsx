// import { useState } from "react";
// import reactLogo from "./assets/react.svg";
// import viteLogo from "/vite.svg";
import "./App.css";
//import { useJeansContext } from "./context/JeansContext";
import Products from "./Pages/Products";
//import Navbar from "./Components/Navbar";
import "react-toastify/dist/ReactToastify.css";
import {
  createBrowserRouter,
  Route,
  RouterProvider,
  createRoutesFromElements,
} from "react-router-dom";
import Layout from "./Pages/Layout";
import Cart from "./Pages/Cart";
import Home from "./Pages/Home";
import LoginPage from "./Pages/LoginPage";
import SignUpPage from "./Pages/SignUpPage";
import ProductDetail from "./Pages/ProductDetail";
import AddProductPage from "./Pages/AddProductPage";
import EditProductPage from "./Pages/EditProductPage";
import EditProfile from "./Pages/EditProfile";
import ForgotPasswordPage from "./Pages/ForgotPasswordPage";
import OrdersPage from "./Pages/OrdersPage";
//mport { ToastContainer } from "react-toastify";
function App() {
 // let data = useJeansContext();
  let router = createBrowserRouter(
    createRoutesFromElements(
      <Route path="/" element={<Layout />}>
        <Route index element={<Home />} />
        <Route path="/products" element={<Products />} />
        <Route path="/products/:id" element={<ProductDetail />} />
        <Route path="/login" element={<LoginPage />} />
        <Route path="/signup" element={<SignUpPage />} />
        <Route path="/cart" element={<Cart />} />
        <Route path="/products/edit/:id" element={<EditProductPage />} />
        <Route path="/products/add" element={<AddProductPage />} />
        <Route path="/editprofile" element={<EditProfile />} />
        <Route path="/updatePassword" element={<ForgotPasswordPage />} />
        <Route path="/orders" element={<OrdersPage />} />
      </Route>
    )
  );
  return (
    <>
      <RouterProvider router={router} />;
    </>
  );
}

export default App;
