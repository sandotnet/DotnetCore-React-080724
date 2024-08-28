import logo from "./logo.svg";
import "./App.css";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import Home from "./Home";
import About from "./About";
import Contact from "./Contact";
import Invalid from "./Invalid";
import Layout from "./Layout";

function App() {
  return (
    <div className="App">
      {/* define the routers */}
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<Layout />}>
            <Route index element={<Home />} />
            <Route path="about" element={<About />} />
            <Route path="contact" element={<Contact />} />
          </Route>
          <Route path="*" element={<Invalid />} />
        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
