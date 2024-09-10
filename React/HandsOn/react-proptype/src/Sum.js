import React from "react";
import propTypes from "prop-types";
export default function Sum({ a, b }) {
  return <div>{a + b}</div>;
}
Sum.propTypes = {
  a: propTypes.number,
  b: propTypes.number,
};
