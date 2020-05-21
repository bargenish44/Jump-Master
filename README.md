
# Jump Master

## Link to ITCH.IO
[Play game -> itch.io](https://bargenish.itch.io/unity-jump-master)



<img src="https://github.com/bargenish44/Jump-Master/blob/master/Pictures/Background.JPG>
![alt text](https://github.com/bargenish44/Jump-Master/blob/master/Pictures/Background.JPG)


We created a game based on one of the games taught on Unity courses.  
The game is 3D when the player is supposed to use the space bar to jump over obstacles that been creating each time period and been destroyed when they come out of frame.  
We added music and player effects.  
We added colliders with a trigger to the player and object of the barrier when the player collides with the obstacle the game is over and there is a blast sound with a special effect.  
We have added a boolean variable that prevents the player from making a double jump.  
We added a rolling stone behind the player, but it can't really hurt us.  
The player actually not moving when only the background gets forward and comes back and we get a real sense of running so we can continue to play as much as we can without the background ends.



This piece of code shows how the animation and sound are activated when the player jumps..


<img src="https://github.com/ShimonMimoun/Unity_Demo_Tools/blob/master/Document/player%20animation.JPG">



This code shows the animation and sound is activated when the player hits the obstacles.

<img src="https://github.com/ShimonMimoun/Unity_Demo_Tools/blob/master/Document/explosion%20animation.JPG">



This code prevents the player from double jumping

<img src="https://github.com/ShimonMimoun/Unity_Demo_Tools/blob/master/Document/Prevents%20double%20jumping.JPG">



This code returns the background back

<img src="https://github.com/ShimonMimoun/Unity_Demo_Tools/blob/master/Document/RepeatBackground.JPG">



This code moves the background and rotates the rock

<img src="https://github.com/ShimonMimoun/Unity_Demo_Tools/blob/master/Document/Moves%20background%20and%20rotates%20rock.JPG">



This code spwans new obstacles

<img src="https://github.com/ShimonMimoun/Unity_Demo_Tools/blob/master/Document/SpawnManager.JPG">

## Audio

The game has 3 types of audio components:

- The background music: plays throughout the game.
- The jump: plays when the player jump.
- The explosion: plays when the player hits the obstacle.

