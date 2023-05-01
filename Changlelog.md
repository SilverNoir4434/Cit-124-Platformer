<h1>CIT 124 Platformer Documentation</h1>

<h2>First Unity Assignment Complete (02/06/23)</h2>
<p>Tasks accomplished in this assignment:</p>
<ul>
  <li>Created Unity Project</li>
  <li>Created tiles to make up the ground, which are made of dirt and grass</li>
  <ul>
    <li>The dirt and grass are split between two objects with different materials, but the grass
      was made a child of the dirt object</li>
  </ul>
  <li>Created Dirt, Grass, and Player materials</li>
  <ul>
    <li>These are used to color their respective game objects</li>
  </ul>
  <li>Created FloorTile prefab</li>
  <ul>
    <li>This ensures we don't have to copy + paste every time we need a new FloorTile, and also
      allows us to sync up changes we make across all instances of the FloorTile object</li>
  </ul>
  <li>Placed FloorTile objects and Player object into the game world</li>
</ul>
<h2>Second Unity Assignment Complete (02/20/23)</h2>
<p>Tasks accomplished in this assignment:</p>
<ul>
  <li>Added RigidBody to Player (forgot to do that in last assignment)</li>
  <li>Added a script to Player</li>
  <ul>
    <li>This script allows the player to jump and move horizontally using the RigidBody component</li>
  </ul>
  <li>Moved FloorTiles so that the player will move properly on platforms</li>
  <ul>
    <li>Beforehand, FloorTiles were not put on X axis so when the player tried to move on the
      X axis they would fall off the map</li>
  </ul>
</ul>
<h2>Third Unity Assignment Complete (03/06/23)</h2>
<p>Tasks accomplished in this assignment:</p>
<ul>
  <li>Modified Player script</li>
  <ul>
    <li>Player is no longer allowed to jump infinitely into the air</li>
    <li>Added collision detection</li>
  </ul>
  <li>Added more platforms for the player to jump between</li>
</ul>
<h2>Fourth Unity Assignment Complete (03/27/23)</h2>
<p>Tasks accomplished in this assignment:</p>
<ul>
  <li>Modified Player script</li>
  <ul>
    <li>Script is now able to detect whether or not the player is touching the ground. If
      they are not, then they cannot jump again, as we do not want the player to be able
      to double jump.</li>
  </ul>
</ul>
<h2>Fifth Unity Assignment Complete(04/10/23)</h2>
<p>Tasks accomplished in this assignment:</p>
<ul>
  <li>Added Layer PlayerLayer</li>
  <ul>
    <li>This is so we can group objects the player is wearing/holding together with the 
      Player object itself</li>
    <li>Also makes sure that the player isn't counted as colliding with objects they are 
      wearing/holding so the jumping mechanic doesn't break</li>
  </ul>
  <li>Changed Player script to account for PlayerLayer</li>
</ul>
<h2>Sixth Unity Assignment Complete (04/17/23)</h2>
<p>Tasks accomplished in this assignment:</p>
<ul>
  <li>Added Game Over Trigger</li>
  <ul>
    <li>Hitting this trigger, which is located just below the platforms, brings the user
      to the Game Over screen</li>
  </ul>
  <li>Added Game Over and Victory Screens</li>
  <ul>
    <li>Victory screen is triggered when you make it to the last block in the game</li>
    <li>Buttons on both screens are currently non-functional, will be remedied in future 
      commit</li>
  </ul>
</ul>
<h2>Seventh Unity Assignment Complete (04/24/23)</h2>
<p>Tasks accomplished in this assignment:</p>
<ul>
  <li>Added functionality to end screen buttons</li>
  <ul>
    <li>Replay? and Quit buttons on both Victory & Game OVer screens now restart the level 
      and quit the application respectively</li>
  </ul>
  <li>Added halo to Victory Block to more clearly indicate it as the goal</li>
</ul>
