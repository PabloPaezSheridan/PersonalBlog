import { useState } from "react";
import { Index } from "./Components/Pages";
import "./App.css";
import { Articles } from "./Components/Pages/articles";
import { Create } from "./Components/Pages/Create";
import { MyRoutes } from "./Routing/Routes";

function App() {
  return (
    <div className="layout">
      <MyRoutes />
    </div>
  );
}

export default App;
