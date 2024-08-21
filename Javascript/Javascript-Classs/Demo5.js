class Product {
    constructor() {
        this.pid = 0;
        this.pname = '';

    }
    //set property
    set PID(value) {
        this.pid = value;
    }
    //get property
    get PID() {
        return this.pid;
    }
    set Pname(value) {
        this.pname = value;
    }
    get Pname() {
        return this.pname;
    }
}
let product = new Product();
//set accessor invoke when assign value to the prop
product.PID = 100
product.Pname = 'Mouse'
console.log(`PID:${product.PID} Pname:${product.Pname}`)