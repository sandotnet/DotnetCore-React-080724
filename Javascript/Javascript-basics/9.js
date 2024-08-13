//for loop
for (i = 1; i <= 100; i++) {
  console.log(i);
  i++;
}

for (i = 1; i <= 100; i++) {
  if (i == 10) break; //termincate loop
  console.log(i);
  i++;
}
for (j = 1; j <= 100; j++) {
  if (j % 2 == 1) continue; //it cancel the current iteration
  console.log(j); //skip this statements when continue statement execute
}
