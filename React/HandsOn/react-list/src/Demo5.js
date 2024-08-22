import React from "react";

export default function Demo5() {
  let item = { id: 3424309, name: "Nidhi", age: 11, std: 5, section: "A" };
  return (
    <div className="container">
      <pre className="text-primary">
        Id:{item.id}
        Name:{item.name}
        Age:{item.age}
        Class:{item.std}
        Section:{item.section}
      </pre>
    </div>
  );
}
