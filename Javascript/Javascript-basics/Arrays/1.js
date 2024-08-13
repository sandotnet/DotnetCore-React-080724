//array declaration
let citites = ["Pune", "Delhi", "Chennai", "Mumbai"];
//access value from an array
console.log(citites[1]);
citites[4]='Kochi';
console.log(citites);
let nos = []; //empty array
//assign value to array
nos[0] = 10;
nos[1] = 20;
nos[2] = 89;

console.log(nos[2]);
//display all array values
for (i = 0; i < citites.length; i++) console.log(citites[i]);
for (j = 0; j < nos.length; j++) console.log(nos[j]);
//display array values using for-of
for(let k of citites)
{
    console.log(k);
}
for(let m of nos)
{
    console.log(m);
}

