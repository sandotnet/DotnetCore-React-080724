import {
  createContext,
  useContext,
  useEffect,
  useReducer,
  useState,
} from "react";
import { fetchJeans, getCarts } from "../../data/Api";
let JeansContext = createContext({
  items: [],
  cart: [],
  totalItems: null,
  cartTotal: null,
  totalAmount: null,
});
export let LOAD_DATA = "LOAD_DATA";
export let LOAD_DATA_SINGLE = "LOAD_DATA_SINGLE";
export let ADD_TO_CART = "ADD_TO_CART";
export let REMOVE_FROM_CART = "REMOVE_FROM_CART";
export let SEARCH_PRODUCTS = "SEARCH_PRODUCTS";
export let SET_CATEGORY = "SET_CATEGORY";
export let LOADING_STATUS = "LOADING_STATUS";
export let SET_LOGIN_TYPE = "SET_LOGIN_TYPE";
export let ADD_PRODUCT = "ADD_PRODUCT";
export let DELETE_PRODUCT = "DELETE_PRODUCT";
export let UPDATE_PRODUCT = "UPDATE_PRODUCT";
export let LOGIN_USER = "LOGIN_USER";
export let LOGOUT_USER = "LOGOUT_USER";
export let LOAD_CART = "LOAD_CART";
export let LOAD_ORDERS="LOAD_ORDERS"
let initialState = {

  items: [],
  cart: [],
  totalItems: null,
  cartTotal: null,
  totalAmount: null,
  Product: {},
  searchItems: [],
  loading: false,
  login_type: "customer",
  user: {},
};

function reducer(state, action) {
  switch (action.type) {
    case LOAD_CART:
      console.log("pauload", action.payload);
      return { ...state, cart: action.payload };
    case LOGOUT_USER:
      return { ...state, user: {} };
    case LOGIN_USER:
      return { ...state, user: action.payload };
    case UPDATE_PRODUCT:
      // let modifiedProducts = state.items.map((p) =>
      //   p.id == action.payload.id ? action.payload : p
      // );
      return {
        ...state,
        searchItems: action.payload,
        items: action.payload,
      };
    case DELETE_PRODUCT:
      let updatedProducts = state.items.filter((p) => p.id != action.payload);
      return {
        ...state,
        items: updatedProducts,
        searchItems: updatedProducts,
      };
    case ADD_PRODUCT:
      return {
        ...state,
        items: [...action.payload],
        searchItems: [...action.payload],
      };
    // case SET_LOGIN_TYPE:
    //   return { ...state, login_type: action.payload };
    case LOAD_ORDERS:
      return {...state,orders:action.payload}
    case LOADING_STATUS:
      return { ...state, loading: action.payload };
    case LOAD_DATA:
      return { ...state, items: action.payload, searchItems: action.payload };
    case LOAD_DATA_SINGLE:
      return { ...state, Product: action.payload };
    case ADD_TO_CART:
      const isProductInCart = state.cart.find(
        (p) => p.id === action.payload.id
      );
      if (isProductInCart) {
        const updatedCart = state.cart.map((p) =>
          p.id === action.payload.id ? { ...p, qty: p.qty + 1 } : p
        );
        return { ...state, cart: updatedCart };
      } else {
        return {
          ...state,
          cart: [...state.cart, { qty: 1, ...action.payload }],
        };
      }
    case REMOVE_FROM_CART:
      const updatedCart = state.cart
        .map((product) =>
          product.id === action.payload.id
            ? { ...product, qty: product.qty - 1 }
            : product
        )
        .filter((product) => product.qty > 0);
      return { ...state, cart: updatedCart };
    case SEARCH_PRODUCTS:
      let filteredProducts = state.items.filter(
        (p) =>
          p.name.toLowerCase().includes(action.payload.toLowerCase()) ||
          p.brand.toLowerCase().includes(action.payload.toLowerCase())
      );
      console.log("filter", filteredProducts);
      return { ...state, searchItems: filteredProducts };
    case SET_CATEGORY:
      if (action.payload == "All") {
        return { ...state, searchItems: [...state.items] };
      }
      let filterProducts = state.items.filter(
        (p) => p.category == action.payload
      );
      return { ...state, searchItems: filterProducts };
    default:
      return state;
  }
}
export let JeansContextProvider = ({ children }) => {
  let [state, dispatch] = useReducer(reducer, initialState);
  let [cart, setCart] = useState([]);
  console.log(state);

  useEffect(() => {
    let fetchData = async () => {
      dispatch({ type: LOADING_STATUS, payload: true });
      let data = await fetchJeans();

      console.log(data);
      setTimeout(() => {
        dispatch({ payload: data, type: LOAD_DATA });
        dispatch({ type: LOADING_STATUS, payload: false });
      }, 1000);
    };
    if (state?.user?.token) {
      fetchData();
    }
  }, [state.user]);
  useEffect(() => {
    let user = JSON.parse(localStorage.getItem("user"));
    dispatch({ type: LOGIN_USER, payload: user });
  }, []);
  useEffect(() => {
    let fetchCart = async () => {
      let carts = await getCarts();
      console.log("wkejc", carts);
      setCart(carts);
      dispatch({
        type: LOAD_CART,
        payload: carts.filter((item) => item?.userId == state?.user?.userId),
      });
    };
    if (state?.user?.token) {
      fetchCart();
    }
  }, [state.user]);
  return (
    <>
      <JeansContext.Provider value={{ ...state, dispatch }}>
        {children}
      </JeansContext.Provider>
    </>
  );
};
export let useJeansContext = () => useContext(JeansContext);
