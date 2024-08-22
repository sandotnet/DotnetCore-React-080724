const Product = (props) => {
  return (
    <div>
      <pre>
        Name:{props.item.name}
        Price:{props.item.price}
        Stock:{props.item.stock}
      </pre>
    </div>
  );
};
const Shop = () => {
  const product = { name: "Iphone", price: 134000, stock: 3 };
  return (
    <>
      <Product item={product} />
      <Product item={{ name: "Bottle", price: 560, stock: 20 }} />
    </>
  );
};
export default Shop;
