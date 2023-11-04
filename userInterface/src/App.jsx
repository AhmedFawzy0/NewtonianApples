import { ReactDOM } from "react";
import { BrowserRouter } from "react-router-dom";
import Menu from "./components/Menu";

const App = () => {
  return (
    <BrowserRouter>
      <Menu />
      
    </BrowserRouter>
  )
}

export default App