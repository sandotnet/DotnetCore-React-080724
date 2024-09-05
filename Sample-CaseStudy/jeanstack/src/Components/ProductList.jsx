// import { Suspense } from "react";
// import { useJeansContext } from "../context/JeansContext";
// import { motion } from "framer-motion";
// import ProductItem from "./ProductItem";

// const ProductList = () => {
//   let { searchItems: items, loading } = useJeansContext();
//   if (loading) {
//     return <p className="loader">Loading...</p>;
//   }

//   return (
//     <div className="list">
//       {items.map((product) => (
//         <ProductItem product={product} key={product.id} />
//       ))}
//     </div>
//   );
// };

// export default ProductList;

import { Suspense } from "react";
import { useJeansContext } from "../context/JeansContext";
import { useSpring, animated } from "react-spring";

import ProductItem from "./ProductItem";

const ProductList = () => {
  let { searchItems: items, loading } = useJeansContext();
  if ( loading || items.length==0) {
    return <p className="loader">Loading...</p>;
  }

 
  return (
    <div className="list">
      {items?.map((product, index) => (
        <ProductItem product={product} key={product.id} />
      ))}
    </div>
  );
};

export default ProductList;
