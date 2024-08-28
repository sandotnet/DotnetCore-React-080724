import logo from "./logo.svg";
import "./App.css";
import GetProducts from "./GetProducts";
import AddProduct from "./AddProduct";
import UpdateProduct from "./UpdateProduct";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import Login from "./login";
import AdminDashboard from "./admin-dashboard";
import UserDashboard from "./user-dashboard";
function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Routes>
          <Route index element={<GetProducts />} />
          <Route path="add" element={<AddProduct />} />
          <Route path="update" element={<UpdateProduct />} />
          <Route path="login" element={<Login />} />
          <Route path="getall" element={<GetProducts />} />
          <Route path="admin-dashboard" element={<AdminDashboard />} />
          <Route path="user-dashboard" element={<UserDashboard />} />
        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
