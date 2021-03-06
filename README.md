
# Jump Master

## Link to ITCH.IO
[Play game -> itch.io](https://bargenish.itch.io/unity-jump-master)



![alt text](https://github.com/bargenish44/Jump-Master/blob/master/Pictures/Background.JPG)

Level up example :
![alt text](https://github.com/bargenish44/Jump-Master/blob/master/Pictures/leveluP.JPG)

Level 2 example : 
![alt text](https://github.com/bargenish44/Jump-Master/blob/master/Pictures/level%201.JPG)

Last scene example :
![alt text](https://github.com/bargenish44/Jump-Master/blob/master/Pictures/Lastscene.JPG)

We created a game based on one of the games taught on Unity courses.  
The game is 3D when the player is supposed to use the space bar to jump over obstacles that been creating each time period and been destroyed when they come out of frame.  
We added music and player effects.  
We added colliders with a trigger to the player and object of the barrier when the player collides with the obstacle the game is over and there is a blast sound with a special effect.  
We have added a boolean variable that prevents the player from making a double jump.  
We added a rolling stone behind the player, but it can't really hurt us.  
The player actually not moving when only the background gets forward and comes back and we get a real sense of running so we can continue to play as much as we can without the background ends.
The game has 4 stages, each stage harder than the other.
To get through the current stage, you have to survive until the timer is over.
If you do not survive, you start from the current stage.
The game is over when all the stages are completed. 



This piece of code shows how the animation and sound are activated when the player jumps..

![alt text](https://github.com/bargenish44/Jump-Master/blob/master/Pictures/KeyDown.JPG)




This code shows the animation and sound is activated when the player hits the obstacles.

<img src="https://github.com/ShimonMimoun/Unity_Demo_Tools/blob/master/Document/explosion%20animation.JPG">



This code prevents the player from double jumping

<img src="https://github.com/ShimonMimoun/Unity_Demo_Tools/blob/master/Document/Prevents%20double%20jumping.JPG">



This code returns the background back

<img src="https://github.com/ShimonMimoun/Unity_Demo_Tools/blob/master/Document/RepeatBackground.JPG">



This code moves the background and rotates the rock

<img src="https://github.com/ShimonMimoun/Unity_Demo_Tools/blob/master/Document/Moves%20background%20and%20rotates%20rock.JPG">



This code spwan new obstacles at random heights and times 

<img src="https://github.com/bargenish44/Jump-Master/blob/master/Pictures/SpawnManager.JPG">

This code is responsible for moving to the next level or replaying the current level
<img src="https://github.com/bargenish44/Jump-Master/blob/master/Pictures/LevelUp%20%26%26%20play%20again.JPG">

This code calculates the current level time, is responsible for updating the current level's graphics, and speeds up the speed of the obstacles.
It is called at each level (new or repeating)
<img src="https://github.com/bargenish44/Jump-Master/blob/master/Pictures/TimerStart.JPG">

This script updates the remaining time for the player and displays that time.
In case the time runs out he waits for 2 seconds and moves the player to the next level.
<img src="https://github.com/bargenish44/Jump-Master/blob/master/Pictures/timerUpdate.JPG">

Player rigidbody :
<img src="https://github.com/bargenish44/Jump-Master/blob/master/Pictures/Physics.JPG">

## Audio

The game has 3 types of audio components:

- The background music: plays throughout the game.
- The jump: plays when the player jump.
- The explosion: plays when the player hits the obstacle.

