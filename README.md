# The Cube Dodger

## Project Overview

3D level-based platformer game made in a frictionless virtual game environment with cube meshes and the main purpose of the game is to dodge the obstacles to get to the finish line of the current level. This project developed to get a grasp on Unity's physics engine and applying fundamental game loop principles.

## Technical Stack

**Engine:** Unity 2022.3.17f

**Language:** C#

**Key Components:** Rigidbody (Physics), BoxCollider, UI Canvas, TextMesh Pro

## Key Features and Implementations

**Movement System:** Movement of the cube is controlled by ```RigidBody.AddForce``` instead of ```transform.Translate```; and provided by an initial force on positive z direction, and impulse force applied on positive and negative x directions with the control buttons to control the left and right movements. Implemented a linear velocity increment logic that increases the forward force over time to enhance the difficulty curve and the Cube doesn't decelerate throughout the game because of the frictionless ground.

**Collision Logic:** The game ends when there is an interaction with the obstacles and the cube, this case controlled with OnCollisionEnter function.

**Level System:** A finish line is placed as a trigger at the end of the level which controlled with OnTriggerEnter function. _More levels in progress to be added to game._

**UI:** Created with TextMesh Pro elements in Unity to navigate through the game and to inform the player, basically two menus and a score display. Score displayed in the screen is based on the distance the cube travelled on the platform; one of the menus is the main menu, activated when the player starts the game, and the other one, pause menu is activated when the player presses ESC.

**Camera Follow:** Offset logic implemented to the camera with a script to make it follow behind the cube.

**Game Manager:** Game states such as Restart and End Game are managed by GameManager script using Unity's SceneManager.

## Challenges & Learning Outcomes

**Physics Management:** Balancing the movement of the cube was challenging due to the frictionless ground, ran multiple tests to balance applied forces to maintain entertainment in a precise difficulty level.

**Level Design:** To separate the project from the tutorial it's based on, more complicated and longer level structure implemented. Took more time, creativity and level testing as the outcome of this.

These challenges made me learn arranging the controls based on the game environment, adjusting difficulty level and core designs of gameplay levels.

## How to Play

Clone The Project.

Run the game in Unity Editor.

Control the cube with A-D for the left and right movement.

## Acknowledgments

This project is based on the "How to make a Video Game in Unity" tutorial videos of Brackeys in YouTube, enhanced with more complex level design and linear velocity increment feature.

**Source:** https://www.youtube.com/watch?v=j48LtUkZRjU&list=PLPV2KyIb3jR53Jce9hP7G5xC4O9AgnOuL
