import { render, fireEvent, screen } from "@testing-library/react";
import Counter from "./counter";
//test-block
test("increment counter", () => {
  //render the componenet on virtual dom
  render(<Counter />);
  //select the elements you want to interact with
  const counter = screen.getByTestId("counter");
  const incrementButton = screen.getByTestId("increment");
  //interact with these elements
  fireEvent.click(incrementButton);
  //assert the expected result
  expect(counter).toHaveTextContent("1");
});
