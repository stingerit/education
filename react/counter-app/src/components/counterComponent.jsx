import React, { Component } from "react";

class Counter extends Component {
  state = {
    count: 0
  };

  render() {
    return (
      <React.Fragment>
        <span className={this.getBargeClasses()}>{this.formatCount()}</span>
        <button className="btn btn-secondary btn-sm">Increment</button>
      </React.Fragment>
    );
  }

  getBargeClasses() {
    return `badge m-2 badge-${this.state.count === 0 ? "warning" : "primary"}`;
  }

  formatCount() {
    const { count } = this.state; // object destructuring
    return count === 0 ? "Zero" : count;
  }
}

export default Counter;
