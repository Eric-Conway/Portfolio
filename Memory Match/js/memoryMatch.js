let isFirstSelection = true;
let firstCard;
let secondCard;
let numberOfAttempts = 0;
let displayNumberOfAttempts;
let cardArray = [1,1,2,2,3,3,4,4,5,5,6,6,7,7,8,8,9,9,10,10];

// add event listener for when the DOM is loaded
document.addEventListener('DOMContentLoaded', () => {
  let allCards = document.querySelectorAll('.card');
  displayNumberOfAttempts = document.getElementById('display');
  shuffle(allCards);
  allCards.forEach((card) => {
    card.addEventListener('click', (event) => {flipCard(event.target);});});

});

function shuffle(allCards)
{
  cardArray.sort(function (a, b) { return Math.random() - 0.5 });

  for (let i=0; i < cardArray.length; i++)
  {
    console.log(allCards);
    //console.log(allCards[i]);
    allCards[i].innerText = cardArray[i];
    allCards[i].value = cardArray[i];
  }
}

function flipCard(clickCard)
{
  if (isFirstSelection === true)
  {
    clickCard.classList.remove('hidden');
    firstCard = clickCard;
    isFirstSelection = false;
  }
  else
  {
    clickCard.classList.remove('hidden');
    secondCard = clickCard;
    isFirstSelection = true;

    if (firstCard.value !== secondCard.value)
    {
      //wait until click
      setTimeout( () =>  {
        firstCard.classList.add('hidden');
        secondCard.classList.add('hidden');
      }, 750 // need to work out time bugs
      )
      
    }
    numberOfAttempts++;
    displayNumberOfAttempts.value = 'No. Attempts ' + numberOfAttempts;
  }
}













// Only for display
function clickNumber(event) {
  const val = event.target.value;

  if( operatorClicked ) {
    display.value = val;
    operatorClicked = false;
  } else {
    display.value == 0 ? display.value = val : display.value += val;
  }
}