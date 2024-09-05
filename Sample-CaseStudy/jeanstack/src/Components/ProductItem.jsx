import { Link } from "react-router-dom";
import StarRating from "../utils/Star";
import { motion } from "framer-motion";
import { animated } from "react-spring";
const ProductItem = ({ product }) => {
  console.log(product);
  return (
    <Link to={`/products/${product.id}`} className="product">
      <img src={product.image} alt={product.name} />
      <div className="content">
        <div className="titles">
          <h3>{product.brand}</h3>
          <h4>{product.name}</h4>
        </div>
        <div>
          <p>{product.price}$</p>
          <StarRating rating={product.rating} />
        </div>
      </div>
    </Link>
  );
};
export default ProductItem;
