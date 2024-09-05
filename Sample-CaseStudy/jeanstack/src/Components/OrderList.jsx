import { Link } from "react-router-dom";
import { useJeansContext } from "../context/JeansContext";
import "./OrderList.css"; // Import CSS file for styling

const OrderList = () => {
  let { orders, user } = useJeansContext();
  let updatedOrders =
    orders?.filter((order) => order.userId == user.userId) || [];
  if (updatedOrders.length == 0) {
    return (
      <div className="cart-message">
        <p>Hey:) please Order something</p>
        <Link to="/products">Browse Products</Link>
      </div>
    );
  }
  return (
    <div className="order-list-container">
      {updatedOrders?.map((order) => (
        <div key={order.id} className="order-card">
          <h2>Order ID: {order.id}</h2>
          <h3>Total: ${order.totalAmount}</h3>
          <p>Order Date: {new Date(order.orderDate).toDateString()}</p>
        </div>
      ))}
    </div>
  );
};

export default OrderList;
