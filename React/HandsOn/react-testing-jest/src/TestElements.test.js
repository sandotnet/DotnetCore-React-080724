import { render, screen } from "@testing-library/react";
import TestElements from "./TestElements";
test("should equal to 0", () => {
  render(<TestElements />);
  const counter = screen.getByTestId("counter");
  expect(counter).toHaveTextContent(0);
});
test("it should be disabled", () => {
  render(<TestElements />);
  const element = screen.getByTestId("button-down");
  expect(element).toBeDisabled();
});
test("should be enabled", () => {
  render(<TestElements />);
  const element = screen.getByTestId("button-up");
  expect(element).not.toHaveAttribute("disabled");
});
