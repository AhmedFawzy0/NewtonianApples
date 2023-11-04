import { ReactDOM } from "react";
import { BrowserRouter } from "react-router-dom";
import Menu from "./components/SideMenu";
import HomePage from "./components/HomePage";
import { Link } from "react-router-dom";

const App = () => {
  return (
    <BrowserRouter>
      <HomePage />
    </BrowserRouter>
  )
}

export default App