import React, { useEffect, useState } from "react";
import axios from "axios";
import { Card, Icon, Grid, Image } from "semantic-ui-react";
const styleLink = document.createElement("link");
styleLink.rel = "stylesheet";
styleLink.href = "https://cdn.jsdelivr.net/npm/semantic-ui/dist/semantic.min.css";
document.head.appendChild(styleLink);

export const Movies = () => {
  const API_URL = "https://localhost:5001/api/movies";
  const [movies, setMovies] = useState([]);

  /*useEffect(() => {
    axios.get(API_URL).then((response) => {
      const data = res.data;
      setMovies(data);
    });
  }, []);*/
  useEffect(()=>)
  
  // Se agrega un array vacio para que se ejecute una sola vez

  return (
<Card>
    
    <Card.Content>
      {movies.map((m)=><Card.Header>{m.Titulo}</Card.Header>)}
      
      <Card.Meta>Joined in 2016</Card.Meta>
      
        {Movies.map((m)=> <Card.Description>{m.Descripcion} </Card.Description>)}
      
    </Card.Content>
    <Card.Content extra>
      <a>
        <Icon name='user' />
        10 Friends
      </a>
    </Card.Content>
  </Card>
  );
};
