import { useEffect } from "react";
import { getOrders } from "../../data/Api";
import OrderList from "../Components/OrderList";
import { LOAD_ORDERS, useJeansContext } from "../context/JeansContext";

const OrdersPage = () => {
  let { dispatch } = useJeansContext();
  useEffect(() => {
    let fetchOrders = async () => {
      let data = await getOrders();
      console.log(data);
      dispatch({ type: LOAD_ORDERS, payload: data });
    };
    fetchOrders();
  }, []);
  return (
    <div>
      <OrderList />
    </div>
  );
};
export default OrdersPage;
