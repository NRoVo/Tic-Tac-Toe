# Tic-Tac-Toe
A simple console version of a famous classic game Tic Tac Toe. 

# What
A console based game without a GUI. Two players take turns using the same keyboard. To choose the position on 3x3 board use the numpad, it looks exactly like 3x3 grid. So the 7 is
the top left corner, the 5 is the center etc. The game ensures that only legal moves could be made. You cannot play in a square that already has something. The wrong player cannot 
take a turn. If the player makes an illegal move, the board remains unchanged. Only a single round of the game could be played. The project should be relaunched to start a new 
round.

# Features
This project has nothing special in sense of used technologies, only basic C# functionality. Here is the information about the code structure:
* ```enum State```. Lists the states that a single square can be in: X, O, and Undecided (empty).
* ```class Position```. Represent a location on the board, with ```Row``` and ```Column``` properties.
* ```class Board```. This class is the fundamental, central data structure for the game as a whole. It contains a 3x3 array of ```State``` values to represent the board, along with
ways to request the current state of a position on the board and request placing a new value on the board. It also keeps track of whose turn it was.
* ```class Player```. A class that is designed to translate input from the player into a board position to play on. It handles the keyboard input.
* ```class WinChecker```. This class has the responsibility of analyzing a board and determining if it has resulted in a win for a player or not yet. Also checks the draw result.
* ```class Renderer```. This class has the responsibility of drawing the game’s current state, including displaying the final results of the game when it is over. Probably will be 
swapped for a GUI in the future. 
* ```class Game```. Assembles a functioning game out of all pieces mentioned above and tie them all together to make it work. Has an input validation mechanism to ensure that only
the numbers from 1 to 9 could be prompted. 
