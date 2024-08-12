//callback functions
function fn(f1, f2) {
  console.log(f1());
  console.log(f2());
}
function a() {
  return "Hello Dotnet Learners!!!";
}
function b() {
  return "Happy Morning every one";
}
fn(a, b); //here a,b are the functions that we pass as paramters to fn
//pass as anonymous functions
fn(
  function () {
    return "Hello";
  },
  function () {
    return "Hi";
  }
);
