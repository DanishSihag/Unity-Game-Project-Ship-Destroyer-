# Unity-Game-Project-Ship-Destroyer-
A project made in Unity for Game development 

This game is about controlling a ship, with ‘W’, ‘A’ and ‘D’ keys. There is no ‘S’ key because it is not allowed to go back.
The ship can shoot cannon balls (prefabs) using the Spacebar key. 
There is a 1.5-second delay between firing successive cannon balls, so that you cannot just spam the spacebar as it would make the game too easy.
There will be enemy ships (prefabs) that keep spawning in front of the player ship.
There are 2 types of ships, the only difference is their colour (one is white, other is black, to make it visually appealing). 
The objective of the game is to shoot the cannon balls and make them collide with the enemy ships.
You will have a total of approximately 3 minutes (190 seconds to be precise) to earn a maximum score, after that the game will stop.
You get one point for collision with an enemy ship, and the points keep stacking as you hit more enemies.
You can look at your current number of points on the top left corner of the game screen.
To make it more interesting, there will be a text bar alongside the points text, which tells the player which level they are currently on.
There will be 5 levels, each dependent on time since you start the game.
With each increasing level, the speed of enemy ships will also increase, making them harder to hit, thus increasing the difficulty of the game.
For example, when you start the game, the ‘level’ text will show as level 1, after 35 seconds, it will show level 2, and the speed of enemies will increase.
One more important asset is the ocean floor prefab, which keeps spawning with respect to the current position of the ship (to be precise, using the player ships’ Z-coordinate).
The Game Over happens when the time is up, as mentioned before, 190 seconds. 
Also, if the player ship collides with enemy ships OR if the player tries to go back at the starting of the game OR if the player collides with the left or right boundaries of the current ocean prefab where the player is.

Assets used: All the assets have been downloaded from unity asset store(assetstore.unity.com).
The assets have not been used directly, there were modifications made before adding them to the scene.
No scripts or scenes have been used from 3rd party asset store, only objects as assets.
