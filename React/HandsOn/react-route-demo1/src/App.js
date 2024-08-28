import React from "react";
<<<<<<< HEAD
import { BrowserRouter,Routes ,Route} from "react-router-dom";
=======
import { BrowserRouter, Routes, Route } from "react-router-dom";
>>>>>>> 677218714a056dce1702e3b29ad3cb084d4edde3
import logo from "./logo.svg";
import  Home from "./Pages/home";
import  Blogs from "./Pages/blogs";
import  Contact from "./Pages/contact";
import  NoPage from "./Pages/nopage";
import  Layout from "./Pages/layout";




import "./App.css";
import Home from "./Pages/home";
import Blogs from "./Pages/blogs";
import Contact from "./Pages/contact";
import NoPage from "./Pages/nopage";
import Layout from "./Pages/layout";
function App() {
  return (
<<<<<<< HEAD
  <>
  <BrowserRouter>
  <Routes>
        <Route path ="/" element={<Layout/>}>

        <Route index element={<Home/>}/>
        <Route path="contact" element={<Contact/>}/>

        <Route path="blogs" element={<Blogs/>}/>
        </Route>
        <Route path="*" element={<NoPage/>}/>



  </Routes>
  
  </BrowserRouter>
  
  
  </>)
=======
    <>
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<Layout />}>
            <Route index element={<Home />} />
            <Route path="blogs" element={<Blogs />} />
            <Route path="contact" element={<Contact />} />
          </Route>
          <Route path="*" element={<NoPage />} />
        </Routes>
      </BrowserRouter>
    </>
  );
>>>>>>> 677218714a056dce1702e3b29ad3cb084d4edde3
}

export default App;
