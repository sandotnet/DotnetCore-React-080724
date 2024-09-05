import logo from "./logo.svg";
const Item = ({ productId, name, price, stock, handler }) => {
  return (
    <tr>
      <td>
        <img src={logo} width={40} height={40} />
      </td>
      <td>{productId}</td>
      <td>{name}</td>
      <td>{price}</td>
      <td>{stock}</td>
      <td>
        <button onClick={handler}>Add To Cart</button>
      </td>
    </tr>
  );
};
export default Item;
