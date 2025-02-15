
// -----CHALLENGE 1-----


let counter = 0;

counter++;

counter++;
counter++;
counter++;
counter++;
counter++;
counter++;
counter++;
counter++;
counter++;

console.log(counter);

let anotherCounter = 0;

while (anotherCounter < 10) {
  anotherCounter++;
}
console.log(anotherCounter);


// -----CHALLENGE 2-----


let bigNumber = 100;
const smallNumber = 5;

while (bigNumber != smallNumber) {
  bigNumber--;
}

console.log(`big num: ${bigNumber} || smallNumber: ${smallNumber}`);


// -----CHALLENGE 3-----


let fundsAvailable = 100;
const giftPrice = 15;
let numberOfGiftsPurchased = 0;
let overbudget = false;

while (!overbudget) {
  numberOfGiftsPurchased++;
  fundsAvailable -= giftPrice;

  if (fundsAvailable < giftPrice) {
    overbudget = true;
  }
}

console.log(`funds available: ${fundsAvailable} || number of gifts purchased: ${numberOfGiftsPurchased}`);


// -----CHALLENGE 4-----


let myArray = [1,7,3,8]
let x = 0;
while (x < myArray.length) {
  console.log(myArray[x]);
  x++;
}


// -----CHALLENGE 5-----


let anotherArray = [86,75,30,9]
for (let i = 0; i < anotherArray.length; i++) {
  console.log(anotherArray[i]);
}


// -----CHALLENGE 6-----


let randomNums = [1,2,100,4,5,6,7,8,9,10];
let overFive = 0;

for (let i=0; i<randomNums.length; i++) {
  if (randomNums[i] > 5) {
    overFive++;
  }
}

console.log(overFive[0]);


// -----CHALLENGE 7-----


let favLanguage = "Javascript";
let aTotal = 0;

for (let i=0; i<favLanguage.length; i++) {
  if (favLanguage[i] == 'a') {
    aTotal++;
  }
}

console.log(aTotal);


// -----CHALLENGE 8-----

const messyMessage = [6, 3,'j',1, 3, 's', 5, 9, 2,'b', ' ', 3, 3, 'i', 's', 7, 0, ' ', 2, 'f', 1, 1, 1, 'u', 'n', 4, '!'];

let cleanMessage = "";

for (let i=0; i<messyMessage.length; i++) {
  if (typeof messyMessage[i] === "string") {
    cleanMessage += messyMessage[i];
  }
}

console.log(cleanMessage);
