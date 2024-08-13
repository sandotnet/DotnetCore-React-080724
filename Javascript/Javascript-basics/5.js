//if-else-if
let m1 = 89,
  m2 = 78,
  m3 = 67,
  m4 = 66,
  m5 = 78;
let total = m1 + m2 + m3 + m4 + m5;
let avg = total / 5;
let grade = "";
if (m1 > 40 && m2 > 40 && m3 > 40 && m4 > 40 && m5 > 40) {
  if (avg >= 70) grade = "Distinction";
  else if (avg >= 60) grade = "FirstClass";
  else if (avg >= 50) grade = "SecondClass";
  else grade = "Third Class";
  console.log(`Grade:${grade}\nTotal Marks:${total}
  \nPercentage:${avg}%`);
} else {
  console.log("Result: Fail");
}
