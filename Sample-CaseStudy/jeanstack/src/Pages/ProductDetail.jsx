import { useEffect } from "react";
import { useParams } from "react-router-dom";
import { fetchJeansById } from "../../data/Api";
import { LOAD_DATA_SINGLE, useJeansContext } from "../context/JeansContext";
import ProductSingle from "../Components/ProductSingle";
const ProductDetail = () => {
  let { id } = useParams();
  let { dispatch, Product } = useJeansContext();
  useEffect(() => {
    let fetchJean = async () => {
      let product = await fetchJeansById(id);
      console.log(product);
      dispatch({ type: LOAD_DATA_SINGLE, payload: product });
    };
    fetchJean();
  }, [id]);
  return (
    <>
      <ProductSingle product={Product} />
    </>
  );
};
export default ProductDetail;
