// Challenge #1 -----------------------------------------------------------------------------
const students = {
Alice: "A",
Bob: "B",
Charlie: "A",
David: "C",
Eva: "B"
};

const countStudentsByGrade = (students, grade) => {
  const output = {}

  output.totalStudents = 0;
  output[`grade${grade}Count`] = 0;

  const keys = Object.keys(students)
  output.totalStudents = keys.length;

  for (let i=0; i<keys.length; i++){
    if (students[keys[i]] === grade) {
      output[`grade${grade}Count`]++;
    }
  }
  return output;
}
console.log(countStudentsByGrade(students, "C"))


// Challenge #2 -----------------------------------------------------------------------------
const inventory = {
apple: 4,
banana: 2,
orange: 7,
mango: 5
};

const findMostCommonItem = (inventory) => {
  const output = {};
  output.allItems = [];
  output.mostCommon = {item: "", count: 0};

  const keys = Object.keys(inventory);
  for (let i=0; i<keys.length; i++) {
    // insert to all items list
    output.allItems.push(keys[i]);

    // check if greater than current most mostCommon
    // if yes then change
    if (inventory[keys[i]] > output.mostCommon.count) {
      output.mostCommon.item = keys[i];
      output.mostCommon.count = inventory[keys[i]]
    }
  }

  return output
}
console.log(findMostCommonItem(inventory))


// Challenge #3 -----------------------------------------------------------------------------
const employees = [
{ name: "Alice", hoursWorked: 40, hourlyRate: 15 },
{ name: "Bob", hoursWorked: 35, hourlyRate: 20 },
{ name: "Charlie", hoursWorked: 25, hourlyRate: 18 },
{ name: "David", hoursWorked: 30, hourlyRate: 22 }
];

const getTotalSalary = (employees) => {
  let totalSalary = 0;

  for (let i=0; i<employees.length; i++) {
    totalSalary += employees[i].hoursWorked * employees[i].hourlyRate;
  }

  return totalSalary;
}

console.log(getTotalSalary(employees))

