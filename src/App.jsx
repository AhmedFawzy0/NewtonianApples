import { ReactDOM } from "react";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import HomePage from "./components/HomePage";
import { Link } from "react-router-dom";
import Kinematics from "./components/Kinematics";
import { Collisions, Dynamics } from "./components";

const App = () => {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<HomePage />} key={"home"}/>
        <Route path="/kinematics" element={<Kinematics />} key={"kin"}/>
        <Route path="/dynamics" element={<Dynamics />} key={"dynamics"}/>     
        <Route path="/collisions" element={<Collisions />} key={"collisions"}/>
      </Routes>
    </BrowserRouter>
  )
}

export default App