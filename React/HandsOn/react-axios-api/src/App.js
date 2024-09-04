import logo from "./logo.svg";
import "./App.css";
import GetProducts from "./GetProducts";
import AddProduct from "./AddProduct";
import UpdateProduct from "./UpdateProduct";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import Login from "./login";
import AdminDashboard from "./admin-dashboard";
import UserDashboard from "./user-dashboard";
import Register from "./register";
import Layout from "./Layout";
import Search from "./search";
import ViewCart from "./viewcart";
import Transaction from "./transaction";
function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Routes>
          {/* Anonymous User */}
          <Route path="/" element={<Layout />}>
            <Route path="login" element={<Login />} />
            <Route path="register" element={<Register />} />
          </Route>
          {/* Admin Dashboard */}
          <Route path="admin-dashboard" element={<AdminDashboard />}>
            <Route path="getall" element={<GetProducts />} />
            <Route path="add" element={<AddProduct />} />
            <Route path="update" element={<UpdateProduct />} />
          </Route>
          {/* User Dashboard */}
          <Route path="user-dashboard" element={<UserDashboard />}>
            <Route path="search" element={<Search />} />
            <Route path="view-cart" element={<ViewCart />} />
            <Route path="tran" element={<Transaction />} />
          </Route>
        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
