//using sring class
let title = "Welcome to Javascript World!! Javascript";
console.log(title[4]);
console.log("Count: " + title.length);
console.log(title.toUpperCase());
console.log(title.toLowerCase());
console.log(title.indexOf("J"));
console.log(title.indexOf("W"));
console.log(title.lastIndexOf("W"));
console.log(title.replace("Javascript", "C#"));
console.log(title.replace("o", "O"));
console.log(title.replace(/o/g, "O")); //global replacement
console.log(title.split(" "));

let arr = ["Welcome", "to", "Javascript", "World!!"];
console.log(arr.join(":"));
console.log(title.charAt(9));
console.log(title.substring(0, 7));
