CMPM 121 Fall 2021
William Lee
Project 3 - Cameras and Lighting

Documentation for Project Criteria
- WASD to move character (AD turns player)
- I added a dim baked light onto the scene with lots of realtime torch lights. (There seems to be a bug where only some torches are active,
but being near them tends to fix it)
- I have 3 different main rooms the first hallway, the intersection, and the second hallway. Each have their own cameras, with the first hallway
having a 3rd person player camera and the other two having external cameras
- Unique Addition: I created torches instead of a flash light because I wanted to play around with Unity's particle system! The player holds a torch,
along with multiple torches that are on the wall. I created a specific torch prefab so that it was easy to copy and paste the game objects. You can
toggle the torch on/off with the F key.