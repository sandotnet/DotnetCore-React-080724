import React from "react";
class Demo2 extends React.Component {
  constructor() {
    super();
    this.state = {
      count: 1,
    };
  }
  onHandler = () => {
    this.setState({
      count: this.state.count + 1,
    });
  };
  render() {
    return (
      <>
        <h1>Count Value:{this.state.count}</h1>
        <button onClick={this.onHandler}>Click</button>
      </>
    );
  }
}
export default Demo2;
