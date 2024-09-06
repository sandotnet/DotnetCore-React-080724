import { render, screen } from "@testing-library/react";
import Welcome from "./Welcome";
//test block
test("welcome render suncessfully", () => {
  render(<Welcome />);
  const element = screen.getByText(/Welcome to React/i);
  expect(element).toBeInTheDocument();
});
