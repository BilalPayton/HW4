# HW4
## Devlog
The AudioSystem and UISystem classes define the view side of the model-view-control pattern
and the GameController defines the control side. The view classes help decouple the code as
the Player or GameController class doesn't need to reference them through the inspector and
changes to the view classes don't affect the code in other classes. The GameController class
is also a Singleton because would only ever need one GameController and it's also makes sense
for it to hold the Player reference for other classes to use because it controls the aspects
of the game. In the player class, I created an event for points called pointsEvent and an
event for when the game is over called gameOverEvent. The AudioSystem and UISystem classes are
subscribed to both events and both have methods pointsEventHandler() and gameOverEventHandler()
for when each event is invoked respectively. pointsEvent is invoked when the Player collides with 
the invisible point wall GameObject and gameOverEvent is invoked when the Player hits a pipe When 
pointsEvent is invoked, a point sound is played from the AudioSystem class and the point UI updates 
from the UISystem class, both classes handling the event in pointsEventHandler(). When gameOverEvent 
is invoked, a sound is played from the AudioSystem class  to indicate that the game has ended after the 
player hits a pipe and the UI UISystem class displays the text "Game Over", both classes handling the 
event in gameOverEventHandler().

## Open-Source Assets
If you added any other assets, list them here!
- [Brackey's Platformer Bundle](https://brackeysgames.itch.io/brackeys-platformer-bundle) - sound effects
- [2D pixel art seagull sprites](https://elthen.itch.io/2d-pixel-art-seagull-sprites) - seagull sprites
- [2D pipe christmas palette sprites](https://wwolf-w.itch.io/industrial-pipe-platformer-tileset) - pipe sprites
- [2D pixel art crow sprites](https://carysaurus.itch.io/bird-sprites) - crow sprites
- [2D grass ground tileset sprites](https://crispy-tofu-games.itch.io/grass-ground-tileset) - ground sprites