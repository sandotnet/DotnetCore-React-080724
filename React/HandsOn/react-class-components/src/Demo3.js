import React from "react";
class Demo3 extends React.Component {
  constructor() {
    super();
    this.state = {
      id: 1,
      name: "keyboard",
      price: 400,
      stock: 10,
    };
  }
  Handler = () => {
    this.setState({
      price: 600,
    });
  };
  render() {
    return (
      <>
        <pre>
          Id:{this.state.id} <br />
          name:{this.state.name} <br />
          price:{this.state.price} <br />
          stock:{this.state.stock} <br />
        </pre>
        <button onClick={this.Handler}>Click</button>
      </>
    );
  }
}
export default Demo3;
