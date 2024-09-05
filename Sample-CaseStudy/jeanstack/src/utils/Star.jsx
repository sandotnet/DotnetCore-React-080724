import React, { useState } from "react";
import { Rating } from "react-simple-star-rating";

export default function StarRating({ rating }) {
  //   const [rating, setRating] = useState(0);

  // Catch Rating value

  return (
    <div className="App">
      {/* set initial value */}
      <Rating initialValue={rating} size={15}/>
    </div>
  );
}
