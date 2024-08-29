import React from "react";
class Demo4 extends React.Component {
  constructor() {
    super();
    this.state = {
      uname: "",
    };
  }
  Handler = (e) => {
    this.setState({
      uname: e.target.value,
    });
  };
  Greet = () => {
    alert("Hello " + this.state.uname);
  };
  render() {
    return (
      <>
        <from>
          Enter Name
          <input
            type="text"
            value={this.state.uname}
            onChange={(e) => this.Handler(e)}
          />
          <button onClick={this.Greet}>Greet</button>
        </from>
      </>
    );
  }
}
export default Demo4;
