function fn(f1, f2) {
  console.log(f1());
  console.log(f2());
}
fn(
  () => "Happy Morning!!",
  () => "Happy Evening!!"
);
//Callback function in Javascript
setTimeout(function () {
  console.log("Hello Javascript learners");
}, 5000);
//passing arrow function as a value to the callback function setTimeOut()
setTimeout(() => console.log("Hello Javascript learners"),
 5000); // it delays function execution in given millisecn of time
