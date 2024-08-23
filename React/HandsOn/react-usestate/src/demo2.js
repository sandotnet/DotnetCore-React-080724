import React, { useState } from "react";

export default function Demo2() {
  const [cities, setCities] = useState(["Pune", "Chennai", "Mubmai"]);
  const [city, setCity] = useState("");
  const updateCities = () => {
    //setCities([...cities, "Banglore"]);
    setCities([...cities, city]);
    setCity("");
  };
  const handler = (e) => {
    setCity(e.target.value);
  };
  return (
    <div>
      <table>
        <tr>
          <th>City</th>
        </tr>
        {cities.map((c) => (
          <tr>
            <td>{c}</td>
          </tr>
        ))}
      </table>
      {/* Enter City:<input type="text" onChange={(e) => handler(e)}></input> */}
      Enter City:
      <input
        type="text"
        value={city}
        onChange={(e) => setCity(e.target.value)}
      ></input>
      <button onClick={updateCities}>ClickMe</button>
    </div>
  );
}
