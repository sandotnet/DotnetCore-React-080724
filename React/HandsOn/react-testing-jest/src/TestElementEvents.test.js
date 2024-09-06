import { render, screen, fireEvent } from "@testing-library/react";
import TestElementEvents from "./TestElementEvents";
test("increments counter", () => {
  render(<TestElementEvents />);
  fireEvent.click(screen.getByTestId("button-up"));
  expect(screen.getByTestId("counter")).toHaveTextContent("1");
});
test("decrement counter", () => {
  render(<TestElementEvents />);
  fireEvent.click(screen.getByTestId("button-down"));
  expect(screen.getByTestId("counter")).toHaveTextContent("-1");
});
