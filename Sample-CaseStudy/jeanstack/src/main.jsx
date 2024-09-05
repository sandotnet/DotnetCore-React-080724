import React from "react";
import ReactDOM from "react-dom/client";
import App from "./App.jsx";
import "./index.css";
import { JeansContextProvider } from "./context/JeansContext.jsx";

ReactDOM.createRoot(document.getElementById("root")).render(
  <JeansContextProvider>
    <App />
  </JeansContextProvider>
);
