// -----CHALLENGE 1-----


// STEP 1
let favNumber = 4;
let comp1 = favNumber < 22;   // true
let comp2 = favNumber > 4;    // false
let comp3 = favNumber >= 21;  // false
let comp4 = favNumber <= 8;   // true
console.log(comp1, comp2, comp3, comp4);

// STEP 2
let name = "John Kyle";
let comp5;
let comp6;
let comp7;
let comp8;

// STEP 3
comp5 = '5' == 5;         // true
comp6 = name === "Maria"; // false
comp7 = 'cat' != 6;       // true
comp8 = '8' !== 8;        // true

// STEP 4
console.log(comp5, comp6, comp7, comp8);


// -----CHALLENGE 2-----

// VARIABLE GLOSSARY
const superManIsTheBestSuperHero = true; // 🦸
const batManIsTheBestSuperHero = false; // literally, no super powers 🙄
const gameOfThronesSeason8WasTerrible = true; // like really true
const androidIsSuperiorToApple = false; // come at me 🤷
const greatTVShow = 'The Office';
const notSoGreatTVShow = 'How I Met Your Mother';
const bestPetToOwn = 'dog';
const notBestPetToOwn = 'cat'; // I love all pets. Just cats a bit less than dogs ... sorry 😬😅
const bestTypeOfFood = 'Hispanic'; // 🌮🌮🌮
const bestMusic = undefined; // always different for me 💁


// STEP 1
let value1 = superManIsTheBestSuperHero && gameOfThronesSeason8WasTerrible;
let value2 = greatTVShow && bestPetToOwn;

// STEP 2
let value3 = androidIsSuperiorToApple || batManIsTheBestSuperHero;
let value4 = notSoGreatTVShow || bestMusic;

// STEP 3
let value5 = !batManIsTheBestSuperHero;
let value6 = !superManIsTheBestSuperHero;
console.log(value1, value2, value3, value4, value5, value6);

// STEP 4 (Bonus Step)
let guest = {};
guest.name = "Randy Random";
guest.age = 69;
guest['has identification'] = true;
guest['identification is real'] = true;
guest['face matches identification'] = true;

let nameToBeAddedToTheGuestList;

// TODO (only logicals)
// if (guest.age >= 21 && guest['has identification'] 
//   && guest['identification is real'] && guest['face matches identification']) {
//       nameToBeAddedToTheGuestList = guest.name;
//   } else {
//       nameToBeAddedToTheGuestList = `Sorry, ${guest.name} you're not getting into the event.`;
//   }
// OLD

nameToBeAddedToTheGuestList =
  ((guest.age >= 21 && guest['has identification'] && guest['identification is real'] && guest['face matches identification'])
    && guest.name) || `Sorry ${guest.name}, you're not getting itno the event`;

console.log(nameToBeAddedToTheGuestList);

// The lesson earlier about the weird stuff about logical operators
// && - same truthy, will take the right operand
// || - will take the first truthy value if present

// var_1 = (conditions required) && guest.name
// will assign guest.name to var_1 if (conditions required evaluates to true)

// var_2 =  var_1 || `Sorry ${guest.name}, you're not getting itno the event`
// if var_1 is false then it will take the `Sorry...` as the value since it is truthy
// now I see why there can be so many bugs in js ./.


// -----CHALLENGE 3-----


// STEP 1
let num = 10;

// STEP 2
if (num == 0) {
  console.log("it's zero")
}
if (num < 0) {
  console.log("it's negative")
}
if (num > 0) {
  console.log("it's positive")
}

// STEP 3
// Refactor above
if (num == 0) {
  console.log("it's zero")
} else if (num < 0) {
  console.log("it's negative")
} else if (num > 0) {
  console.log("it's positive")
}

// STEP 4
// Refactor above
if (num == 0) {
  console.log("it's zero")
} else if (num < 0) {
  console.log("it's negative")
} else {
  console.log("it's positive")
}

// -----CHALLENGE 4-----

// STEP 1
let temperature = 75;
let kindOfDay;

// STEP 2
if (temperature > 98) {
  kindOfDay = "super hot";
  console.log("I'm staying inside next to the AC");
} else if (temperature > 84 && temperature < 99) {
  kindOfDay = "a litte warm";
  console.log("I'll head out for a bit, but I'm wearing shorts");
} else if (temperature > 69 && temperature < 85) {
  kindOfDay = "perfect";
  console.log("It's perfect outside. I think I'll go to the park");
} else if (temperature > 54 && temperature < 70) {
  kindOfDay = "chilly";
  console.log("I'd better bring a jacket");
} else if (temperature < 55) {
  kindOfDay = "freezing";
  console.log("Heck no! I'm staying inside where it's warm");
}

if (kindOfDay !== undefined) {
  console.log(`Looks like it's going to be ${kindOfDay} today`);
}


// -----CHALLENGE 5 (Bonus Challenge 😮) -----

const value7 = true;
const value8 = false;
const value9 = "6";
const value10 = "cat";
const value11 = 0;


// -----Uncomment The Below Lines Of Code-----
if (value7 === true) {
  console.log('a');
}

if (value8 === false) {
  console.log('b');
}

if (value9 == 6) {
  console.log('c');
}

if (value10 != undefined) {
  console.log('d');
}

if (value11 == false) {
  console.log('e');
}