import { ReactDOM } from "react";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import HomePage from "./components/HomePage";
import { Link } from "react-router-dom";
import Kinematics from "./components/Kinematics";

const App = () => {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<HomePage />} key={"home"}/>
        <Route path="/kinematics" element={<Kinematics />} key={"kin"}/>
        <Route path="/dynamics" element={<></>} key={"dynamics"}/>     
        <Route path="/collisions" element={<></>} key={"collisions"}/>
      </Routes>
    </BrowserRouter>
  )
}

export default App