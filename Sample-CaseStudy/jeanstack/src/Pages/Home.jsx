import { Link, useNavigate } from "react-router-dom";
import { useJeansContext } from "../context/JeansContext";
import { useEffect } from "react";

const Home = () => {
  
  return (
    <div className="home">
      <img
        src="https://images.unsplash.com/photo-1576995853123-5a10305d93c0?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8M3x8amVhbnN8ZW58MHx8MHx8fDA%3D"
        alt=""
      />
      <div className="home-content">
        <h2>Find Your Perfect Fit: Jeans for Every Body, Every Style.</h2>
        <p>
          Welcome to JeanStation, your denim destination where style meets
          comfort. Explore our curated collection of jeans crafted for every
          body and every occasion. Find your perfect fit and step into
          fashion-forward confidence at JeanStation.
        </p>
        <Link to="/products">Explore Products</Link>
      </div>
    </div>
  );
};
export default Home;
