import { useEffect, useState } from "react";
import "./AddProduct.css";
import {
  ADD_PRODUCT,
  //LOAD_DATA,
  useJeansContext,
} from "../context/JeansContext";
import { PostProduct } from "../../data/Api";
import { useNavigate } from "react-router-dom";
import ImageUpload from "./ImageUpload";
import { toast } from "react-toastify";
const AddProduct = () => {
  let { dispatch } = useJeansContext();
  let [addProductStatus, setAddProductStatus] = useState("Add Product");
  const [image, setImage] = useState(null);

  let Navigate = useNavigate();
  const [product, setProduct] = useState({
    brand: "",
    name: "",
    price: "",
    color: "",
    size: "",
    image: "",
    description: "",
    quantity: "",
    category: "",
    rating: "",
  });

  const handleChange = (e) => {
    const { name, value } = e.target;
    setProduct({
      ...product,
      [name]: value,
    });
  };
  let handleSubmit = async (e) => {
    e.preventDefault();
    if (!image) {
      toast.error("Please Upload a image to Add Product");
      return;
    }
    let response = await PostProduct({ ...product, image });
    toast.info("New Item Added");
    dispatch({ type: ADD_PRODUCT, payload: response });
    // dispatch( { type:LOAD_DATA})
    setAddProductStatus("Added");
  };
  useEffect(() => {
    if (addProductStatus === "Added") {
      const timeout = setTimeout(() => {
        Navigate("/products");
        setAddProductStatus("Add Product");
      }, 1500);

      return () => clearTimeout(timeout);
    }
  }, [addProductStatus, Navigate]);
  return (
    <div className="add-product">
      <h2>Enter Details</h2>
      <form onSubmit={handleSubmit}>
        <div className="form">
          <div>
            <label htmlFor="brand">Enter brand name</label>
            <input
              type="text"
              id="brand"
              onChange={handleChange}
              name="brand"
              value={product.brand}
            />
          </div>
          <div>
            <label htmlFor="name">Enter product name</label>
            <input
              type="text"
              id="name"
              onChange={handleChange}
              name="name"
              value={product.name}
            />
          </div>
          <div>
            <label htmlFor="price">Enter price</label>
            <input
              type="text"
              id="price"
              onChange={handleChange}
              name="price"
              value={product.price}
            />
          </div>
          <div>
            <label htmlFor="color">Enter color</label>
            <input
              type="text"
              id="color"
              onChange={handleChange}
              name="color"
              value={product.color}
            />
          </div>
          <div>
            <label htmlFor="size">Enter size</label>
            <input
              type="text"
              id="size"
              onChange={handleChange}
              name="size"
              value={product.size}
            />
          </div>
          <ImageUpload setImage={setImage} image={image} />
          <div>
            <label htmlFor="description">Enter description</label>
            <textarea
              id="description"
              onChange={handleChange}
              name="description"
              value={product.description}
            />
          </div>
          <div>
            <label htmlFor="quantity">Enter quantity</label>
            <input
              type="text"
              id="quantity"
              onChange={handleChange}
              name="quantity"
              value={product.quantity}
            />
          </div>
          <div>
            <label htmlFor="category">Enter category</label>
            <input
              type="text"
              id="category"
              onChange={handleChange}
              name="category"
              value={product.category}
            />
          </div>
          <div>
            <label htmlFor="rating">Enter rating</label>
            <input
              type="text"
              id="rating"
              onChange={handleChange}
              name="rating"
              value={product.rating}
            />
          </div>
        </div>

        <button className="add-product-btn">{addProductStatus}</button>
      </form>
    </div>
  );
};

export default AddProduct;
