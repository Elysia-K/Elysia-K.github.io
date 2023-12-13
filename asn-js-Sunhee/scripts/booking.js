/********* create variables *********/
// useful variables might be: the cost per day, the number of days selected, and elements on the screen that will be clicked or will need to be modified.
// Do any of these variables need to be initialized when the page is loaded?
// When do they need to be reset or updated?

let dailyCost = 0;
let totalCost = 0;
let selectedDays = [];

/********* colour change days of week *********/
// when the day buttons are clicked, we will apply the "clicked" class to that element, and update any other relevant variables. Then, we can recalculate the total cost.
// added challenge: don't update the dayCounter if the same day is clicked more than once. hint: .classList.contains() might be helpful here!
const selectDays = document.getElementsByTagName('li');
Array.from(selectDays).forEach(function (element) {
  element.addEventListener('click', function () {
    if (!element.classList.contains('clicked')) {
      element.classList.add('clicked');
      selectedDays.push(element.id);
      calculateTotalCost();
    }
  });
});
/********* clear days *********/
// when the clear-button is clicked, the "clicked" class is removed from all days, any other relevant variables are reset, and the calculated cost is set to 0.
const clear = document.getElementById('clear-button');

clear.addEventListener('click', function () {
  Array.from(selectDays).forEach(function (element) {
    element.classList.remove('clicked');
  });

  dailyCost = 0;
  totalCost = 0;
  selectedDays = [];
  calculateTotalCost();
});
/********* change rate *********/

function handleDayButtonClick(rate, clickedElement, unclickedElement) {
  dailyCost = rate;
  clickedElement.classList.add('clicked');
  unclickedElement.classList.remove('clicked');
  calculateTotalCost();
}

// when the half-day button is clicked, set the daily rate to $20, add the "clicked" class to the "half" element, remove it from the "full" element, and recalculate the total cost.

document.getElementById('half').addEventListener('click', function () {
  handleDayButtonClick(20, this, document.getElementById('full'));
});

// when the full-day button is clicked, the daily rate is set back to $35, the clicked class is added to "full" and removed from "half", and the total cost is recalculated.

document.getElementById('full').addEventListener('click', function () {
  handleDayButtonClick(35, this, document.getElementById('half'));
});

/********* calculate *********/
// when a calculation is needed, set the innerHTML of the calculated-cost element to the appropriate value
function calculateTotalCost() {
  const calculateCost = document.getElementById('calculated-cost');
  const totalCost = dailyCost * selectedDays.length;
  calculateCost.innerHTML = totalCost;
}
