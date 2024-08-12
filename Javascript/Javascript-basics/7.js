//grouping case value
let weekday = 16;
switch (weekday) {
  case 1:
  case 2:
  case 3:
  case 4:
  case 5:
    console.log("WeekDay");
    break;
  case 6:
  case 7:
    console.log("WeekEnd");
    break;
  default:
    console.log("Invalid Day");
    break;
}
