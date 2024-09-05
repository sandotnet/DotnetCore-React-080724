import React, { useEffect, useState } from "react";
import { useNavigate, useParams } from "react-router-dom";
import { UPDATE_PRODUCT, useJeansContext } from "../context/JeansContext";
import "./AddProduct.css";
import { UpdateProduct, fetchJeansById } from "../../data/Api";
import { toast } from "react-toastify";

export const EditProduct = () => {
  const { id } = useParams();
  const { items, updateProduct, dispatch } = useJeansContext();
  const [updateProductStatus, setUpdateStatus] = useState("Update Product");
  let navigate = useNavigate();
  const [formData, setFormData] = useState({
    brand: "",
    name: "",
    price: "",
    color: "",
    size: "",
    description: "",
    quantity: "",
    category: "",
    rating: "",
  });
  let status = "product updated";
  const handleSubmit = async (e) => {
    e.preventDefault();
    let res = await UpdateProduct(id, { ...formData });
    console.log(res);
    toast.success("product updated");
    dispatch({ type: UPDATE_PRODUCT, payload: res.data });
    setUpdateStatus(status);
  };
  useEffect(() => {
    if (updateProductStatus === status) {
      setTimeout(() => {
        navigate(`/products/${id}`);
      }, 1000);
    }
  }, [updateProductStatus, id, navigate]);
  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData({
      ...formData,
      [name]: value,
    });
  };
  useEffect(() => {
    let fetchSingleProduct = async () => {
      let product = await fetchJeansById(id);
      setFormData(product);
      console.log(product);
    };
    fetchSingleProduct();
  }, [id]);
  return (
    <div>
      <div className="add-product">
        <h2>Update Details</h2>
        <form onSubmit={handleSubmit}>
          <div className="form">
            <div>
              <label htmlFor="brand">Enter brand name</label>
              <input
                type="text"
                id="brand"
                onChange={handleChange}
                name="brand"
                value={formData.brand}
              />
            </div>
            <div>
              <label htmlFor="name">Enter product name</label>
              <input
                type="text"
                id="name"
                onChange={handleChange}
                name="name"
                value={formData.name}
              />
            </div>
            <div>
              <label htmlFor="price">Enter price</label>
              <input
                type="text"
                id="price"
                onChange={handleChange}
                name="price"
                value={formData.price}
              />
            </div>
            <div>
              <label htmlFor="color">Enter color</label>
              <input
                type="text"
                id="color"
                onChange={handleChange}
                name="color"
                value={formData.color}
              />
            </div>
            <div>
              <label htmlFor="size">Enter size</label>
              <input
                type="text"
                id="size"
                onChange={handleChange}
                name="size"
                value={formData.size}
              />
            </div>
            <div>
              <label htmlFor="description">Enter description</label>
              <textarea
                id="description"
                onChange={handleChange}
                name="description"
                value={formData.description}
              />
            </div>
            <div>
              <label htmlFor="quantity">Enter quantity</label>
              <input
                type="text"
                id="quantity"
                onChange={handleChange}
                name="quantity"
                value={formData.quantity}
              />
            </div>
            <div>
              <label htmlFor="category">Enter category</label>
              <input
                type="text"
                id="category"
                onChange={handleChange}
                name="category"
                value={formData.category}
              />
            </div>
            <div>
              <label htmlFor="rating">Enter rating</label>
              <input
                type="text"
                id="rating"
                onChange={handleChange}
                name="rating"
                value={formData.rating}
              />
            </div>
          </div>

          <button className="add-product-btn">{updateProductStatus}</button>
        </form>
      </div>
    </div>
  );
};
