class Product {
  constructor() {
    this.Pid = 0;
    this.Pname = "";
    this.Price = 0;
    this.Stock = 0;
  }
  details() {
    //method
    console.log(
      `Id:${this.Pid} Name:${this.Pname} Price:${this.Price} Stock:${this.Stock}`
    );
  }
  //arrow function
   show = () => {
    console.log("Hello");
  };
}
let product = new Product();
product.Pid = 1;
product.Pname = "Mouse";
product.Price = 400;
product.Stock = 10;
product.details();
product.show();
