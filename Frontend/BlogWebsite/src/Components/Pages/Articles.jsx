import React from "react";
import { useState, useEffect } from "react";
import { Global } from "../../Helpers/Global";

export const Articles = () => {
  const [articles, setArticles] = useState([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    retrieveArticle();
  }, []);

  const retrieveArticle = async () => {
    let response = await fetch(Global.apiBaseUrl + "/Article", {
      method: "GET",
    });
    let data = await response.json();
    if (response.ok) {
      setLoading(false);
      setArticles(data);
    }
  };
  return (
    <>
      {loading == true ? (
        "Cargando..."
      ) : articles.length >= 1 ? (
        articles.map((article) => {
          return (
            <article className="article-item" key={article.id}>
              <div className="img-mask">
                <img src={article.imagePath} />
              </div>
              <div className="data">
                <div className="title">{article.title}</div>
                <div className="summary">{article.summary}</div>
                <button className="edit">Editar</button>
                <button className="delete">Eliminar</button>
              </div>
            </article>
          );
        })
      ) : (
        <h1>No hay articulos</h1>
      )}
    </>
  );
};
