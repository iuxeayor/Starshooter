# Starshooter
A 3rd-Person, 3D Flight-Sim, Space Shooter game built using the Unity3D Engine v4.6.

# Creator:  Iuxeayor
I designed this game mostly as a learning experience for myself.  With it I hope to learn more about Unity3D and Game Design and Development in general, including useful techniques and common algorithms.  I am more of a designer than a developer even though I have a Bachelor's in Computer Science and am currently employed as a Software Engineer.  I work on this game in my spare time.  Since I consider myself more of a designer, I prefer to focus more on gameplay and rules rather than on code optimization and low-level programming (ie: re-inventing the wheel).  Thus, I use tools like RAIN AI and other various useful scripts and packages when I can and feel that they do not hinder my progress or understanding of how the game components work together.

# Rules
This game is a simple game where the player flies a starfighter around in 3D space alongside Wingmen, fighting against Bogeys.  The game is over when the Player shoots and destroys enough Bogeys to satisfy the final score.  

Asteroids are destructible, even the large ones; and they offer small amounts of points toward the score.  Crashing into Asteroids at this point does no damage to anyone, including the Asteroids.  In fact, nothing damages anyone except for Blasters.

The Player does not respawn at this point, though soon, after some modification, it will be able to.  The Player is the only ship able to regenerate HP.  

Wingmen and Bogeys spawn at their respective Frigates (Red = Enemy (Astropyre), Green = Allies (Starshooters)).  After some tuning, the Starshooter faction will be more focused on being stronger, both in Armor and in Weapons, while the Astropyre faction will rely more heavily on numbers

If Wingmen are killed, they subtract points from the Player's score.  They are the only possible detriment to the Player's score right now.

# Controls
Click on the ship to gain control of the Starshooter.
Use the mouse to move the Starshooter (inverted Y-axis).  Left-Right performs Yaw, not Roll.
Use Left-Mouse-Button to fire primary Blasters - no auto-fire or charging yet.
Use A and D to Roll Left and Right respectively.
Use W and S to Boost and Brake respectively.
Use Esc to release control of the Starshooter to exit the game.

