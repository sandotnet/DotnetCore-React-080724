import axios from "axios";
import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
const ViewCart = () => {
  const [cartItems, setCartItems] = useState([]);
  const [totalPrice, setTotalPrice] = useState(0);
  const navigate = useNavigate();
  useEffect(() => {
    let userId = sessionStorage.getItem("userId");

    axios
      .get("http://localhost:5005/api/Cart/GetAllCartItems?userId=" + userId)
      .then((response) => {
        console.log(response.data);
        setCartItems(response.data);
        let tot = 0;
        for (let item of response.data) {
          let totalprice = item.price * item.qty;
          console.log(totalprice);

          tot = tot + totalprice;
          console.log(tot);
          setTotalPrice(tot);
        }
      })
      .catch((error) => console.log(error));
  }, []);
  const removeCartItem = (cartId) => {};
  const makeOrder = () => {
    const order = {
      productId: 4,
      orderDate: new Date(),
      userId: sessionStorage.getItem("userId"),
      totalPrice: totalPrice,
    };
    sessionStorage.setItem("totalprice", totalPrice);

    console.log(order);
    axios
      .post("http://localhost:5005/api/Order/MakeOrder", order)
      .then((response) => {
        console.log(response);
        // for (let item of cartItems) {
        //   AddOrdreItem(item, response.data.orderId);
        // }
        sessionStorage.setItem("orderId", response.data.orderId);
      })
      .catch((error) => console.log(error));
    navigate("/user-dashboard/tran");
  };
  const AddOrdreItem = (item, orderId) => {};
  return (
    <>
      <table className="table table-hover">
        <thead>
          <tr>
            <th>ProductId</th>
            <th>Name</th>
            <th>Price</th>
            <th>Qty</th>
            <th>Total Price</th>
          </tr>
        </thead>
        <tbody>
          {cartItems.map((cart) => (
            <tr>
              <td>{cart.productId}</td>
              <td>{cart.name}</td>
              <td>{cart.price}</td>
              <td>{cart.qty}</td>
              <td>{cart.price * cart.qty}</td>
              <td>
                <button onClick={() => removeCartItem(cart.cartId)}>
                  Remove
                </button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
      <div>Total Price:{totalPrice}</div>
      <button onClick={makeOrder}>Make Order</button>
    </>
  );
};
export default ViewCart;
