import React from "react";
import { BrowserRouter,Routes ,Route} from "react-router-dom";
import logo from "./logo.svg";
import  Home from "./Pages/home";
import  Blogs from "./Pages/blogs";
import  Contact from "./Pages/contact";
import  NoPage from "./Pages/nopage";
import  Layout from "./Pages/layout";




import "./App.css";
function App() {
  return (
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
}

export default App;
