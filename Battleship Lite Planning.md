#### Battleship Lite Planning



##### \--- **Basic requirements** ---

To build a small, two-player console game that

has it's roots in the game Battleship from Mattel.

There will be a 25-spot grid (A1-E5).

Each player will place five pegs on the board to

represent their five ships. Players will then take

turns firing on their opponent's ships. The first

person to sink all five ships wins.

###### \--------------------------



###### **W - walk through the steps**



Two players open up the console

Ask player 1 where their battleships are located on the grid

Store

Ask player 2 the same.

Store

Loop

{

Ask player 1 for a cell

Check if it's a hit or miss and print

Check if the game is over (all ships sunk)

Ask player 2 for a cell

Check if it's a hit or miss and print

Check if the game is over (all ships sunk)

} until one of the players has hit all of the opponents ships



Identify who the winner is.

Exit the game.



###### **O - open up the requirements (additional questions)**



Questions

1\. Is it the same console or two different consoles working together? - **Same**

2\. Does the other player get one last chance after being sunk? - **No**

3\. Do we want to capture/display statistics such as hit/miss ratio, etc.? - **Just how many shots it took to win.**

4\. Only one ship per spot. (requirement)

5\. Do we allow a player to shoot the same spot twice? - **No**

6\. Do we show a visual of the grid? - **Yes**

7\. Do we store game data? (keep track of past games) - **No**

8\. Are we ever going to change the number of players? - **Maybe**

9\. Will we add a computer player? - **Maybe**





###### **Full requirements**



1. 2-players game
2. 25 spot grid (A1-E5)
3. Each player gets 5 ships
4. Each ship takes up 1 spot
5. Players take turns firing
6. First player to sink all 5 wins
7. One console for everyone
8. No completing the round after 5 sunk ships
9. Show a visual of the grid with hits and misses
10. Do not allow the user to shoot the same spot twice





###### **U - user interface design**



&#x20;    Starting look	  One hit - 5 misses	    Game finished	



&#x09;A1 A2 A3 A4 A5		A1 A2 A3 O A5		X A2 O A3 O A5

&#x09;B1 B2 B3 B4 B5		B1 B2 B3 B4 B5		O B2 X B4 B5 X

&#x09;C1 C2 C3 C4 C5		O C2 X C4 C5		O C2 X C4 C5

&#x09;D1 D2 D3 D4 D5		D1 D2 O O D5		O D2 O O D5

&#x09;E1 E2 E3 E4 E5		E1 E2 E3 E4 O		E1 O E3 E4 O





Welcome message

Ask player 1 for their name

Ask player 1 for their 5 ship locations

&#x09;Ask for placement

&#x09;Determine if it's a valid spot

&#x09;Store

&#x09;Clear console

Ask player 2 for their name

Ask player 2 for their 5 ship locations

&#x09;Ask for placement

&#x09;Determine if it's a valid spot

&#x09;Store

&#x09;Clear console

Display grid of where player 1 has fired

Ask player 1: Where would you like to fire on?

&#x09;Verify a valid spot

&#x09;Check results

&#x09;Store shot

&#x09;Clear console

Display the score (player1: 2 ships left, player2: 4 ships left)

Repeat with player 2

Loop until someone wins

Print out winner's name and number of shots taken

Wait for user to say they are done

Exit



###### **L - logic design**



Method: Asking for name

enum

Method: Get ship placement

Method: Determine if valid spot for ship

Storing Ship information: List per user?

Storing Shot information: List per user?

Method: Create the grid for each user

Method: Print out grid

Method: Fire on opponent

Method: Determine if a shot can be taken \& outcome

Method: Display score

Method: Print winner and shots taken





###### **D - data design**



PlayerInfo

Player name - string

Player ship location - List<GridSpot>

Player shot grid - List<GridSpot>





**GridSpot**

SpotLetter - string

SpotNumber - int

Status - string (possible enum)

