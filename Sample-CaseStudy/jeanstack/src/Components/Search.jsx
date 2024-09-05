import { useEffect, useRef, useState } from "react";
import {
  SEARCH_PRODUCTS,
  SET_CATEGORY,
  useJeansContext,
} from "../context/JeansContext";
import "./Search.css";
import { FaSearch } from "react-icons/fa";
const Search = () => {
  let inputRef = useRef();
  let [searchVal, setSearchVal] = useState("");
  let { dispatch } = useJeansContext();
  let handleSearch = (e) => {
    e.preventDefault();
    dispatch({ type: SEARCH_PRODUCTS, payload: searchVal });
  };
  let handleCategory = (e) => {
    dispatch({ type: SET_CATEGORY, payload: e.target.value });
  };
  useEffect(() => {
    inputRef.current.focus();
  }, []);
  return (
    <div className="search-container">
      <form onSubmit={handleSearch}>
        <div className="form-search">
          <input
            type="text"
            placeholder="search products..."
            ref={inputRef}
            value={searchVal}
            onChange={(e) => setSearchVal(e.target.value)}
          />
          <button className="search-btn">
            <FaSearch />
          </button>
        </div>
      </form>
      <div>
        <label htmlFor="category">Choose Category:</label>
        <select id="category" onChange={handleCategory}>
          <option value="All">All</option>
          <option value="Men's">Men's</option>
          <option value="Women's">Women's</option>
        </select>
      </div>
    </div>
  );
};
export default Search;
