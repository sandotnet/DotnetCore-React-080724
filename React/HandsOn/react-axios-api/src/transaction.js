import axios from "axios";
import { useRef } from "react";
const Transaction = () => {
  const payMode = useRef();
  const transactionAmt = useRef();
  const orderId = useRef();
  const transactionHandler = (e) => {
    let tran = {
      paymentMode: payMode.current.value,
      transactionAmt: sessionStorage.getItem("totalprice"),
      orderId: sessionStorage.getItem("orderId"),
      transactionId: "3fa85f64-5717-4562-b3fc-2c963f66afa6",
      transactionDate: new Date(),
    };
    console.log(tran);
    axios
      .post("http://localhost:5005/api/Transaction/AddTran", tran)
      .then((response) => {})
      .catch((error) => console.log(error));
    e.preventDefault();
  };
  return (
    <div className="container">
      <form onSubmit={transactionHandler}>
        <table className="table">
          <tr>
            <td colSpan={2}>orerId:{sessionStorage.getItem("orderId")}</td>
          </tr>
          <tr>
            <td colSpan={2}>
              transactionAmount:{sessionStorage.getItem("totalprice")}
            </td>
          </tr>
          <tr>
            <td>Mode</td>
            <td>
              <select ref={payMode}>
                <option>Debit</option>
                <option>Credit</option>
              </select>
            </td>
          </tr>
          <tr>
            <td colSpan={2}>
              <button>Make Transaction</button>
            </td>
          </tr>
        </table>
      </form>
    </div>
  );
};
export default Transaction;
