import axios from "axios";

export let fetchJeans = async () => {
  let response = await axios.get("http://localhost:5287/products", {
    headers: {
      Authorization: `Bearer ${JSON.parse(localStorage.getItem("user")).token}`,
    },
  });
  return response.data;
};
export let fetchJeansById = async (id) => {
  let response = await axios.get(`http://localhost:5287/products/${id}`, {
    headers: {
      Authorization: `Bearer ${JSON.parse(localStorage.getItem("user")).token}`,
    },
  });
  return response.data;
};
export let PostProduct = async (product) => {
  let response = await axios.post(
    `http://localhost:5287/products`,
    {
      ...product,
    },
    {
      headers: {
        Authorization: `Bearer ${
          JSON.parse(localStorage.getItem("user")).token
        }`,
      },
    }
  );
  return response.data;
};
export let UpdateProduct = async (id, product) => {
  let response = await axios.patch(
    `http://localhost:5287/products/update`,
    product,
    {
      headers: {
        Authorization: `Bearer ${
          JSON.parse(localStorage.getItem("user")).token
        }`,
      },
    }
  );
  return response;
};
export let fetchUsers = async (user) => {
  let response;
  try {
    response = await axios.post(`http://localhost:5287/user/login`, user);
  } catch (err) {
    return err.message;
  }

  return response.data;
};
export let PostUser = async (user) => {
  let res = await axios.post("http://localhost:5287/user/signup", { ...user });
  return res;
};
export let UpdateUser = async (user) => {
  let res = await axios.put(
    `http://localhost:5287/user/editProfile`,
    {
      ...user,
    },
    {
      headers: {
        Authorization: `Bearer ${
          JSON.parse(localStorage.getItem("user")).token
        }`,
      },
    }
  );
  console.log(res);
  return res.data;
};
export let addToCart = async (cart) => {
  let res = await axios.post(
    "http://localhost:5287/addToCart",
    { ...cart },
    {
      headers: {
        Authorization: `Bearer ${
          JSON.parse(localStorage.getItem("user")).token
        }`,
      },
    }
  );
  console.log(res);
  return res;
};
export let getCarts = async () => {
  let res = await axios.get("http://localhost:5287/carts", {
    headers: {
      Authorization: `Bearer ${JSON.parse(localStorage.getItem("user")).token}`,
    },
  });
  console.log(res);
  let userId = JSON.parse(localStorage.getItem("user"))?.userId;
  return res.data
    .map((item) => ({ ...item }))
    .filter((item) => item.userId == userId);
};
export let removeFromCart = async (id) => {
  let res = await axios.delete(
    `http://localhost:5287/removeFromCart?id=${id}`,

    {
      headers: {
        Authorization: `Bearer ${
          JSON.parse(localStorage.getItem("user")).token
        }`,
      },
    }
  );
  console.log(res);
};
export let placeOrder = async (order) => {
  let res = await axios.post("http://localhost:5287/orders", order);
  console.log(res);
};

export let getOrders = async () => {
  let res = await axios.get("http://localhost:5287/orders");
  return res.data;
};
