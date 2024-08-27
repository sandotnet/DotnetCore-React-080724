import React, { useEffect, useState } from "react";
import axios from "axios";
const Demo5 = () => {
  const [obj, setObj] = useState({});
  useEffect(() => {
    axios("https://reqres.in/api/users/2") //invoke the api
      .then((response) => {
        console.log(response.data);
        setObj(response.data);
      })
      .catch((error) => console.log(error));
  }, []);
  console.log(obj);
};
export default Demo5;
