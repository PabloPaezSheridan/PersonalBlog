import React from "react";
import { Routes, Route, BrowserRouter, Navigate } from "react-router-dom";
import { Index } from "../Components/Pages";
import { Articles } from "../Components/Pages/articles";
import { Header } from "../Components/Layout/Header";
import { Nav } from "../Components/Layout/Nav";
import { Sidebar } from "../Components/Layout/Sidebar";
import { Footer } from "../Components/Layout/Footer";
import { Create } from "../Components/Pages/Create";

export const MyRoutes = () => {
  return (
    <BrowserRouter>
      {/*Layout */}
      <Header />
      <Nav />
      <section id="content" className="content">
        <Routes>
          <Route path="/" element={<Index />} />
          <Route path="/index" element={<Index />} />
          <Route path="/articles" element={<Articles />} />
          <Route path="/create" element={<Create />} />
        </Routes>
      </section>
      <Sidebar />
      <Footer />
    </BrowserRouter>
  );
};
