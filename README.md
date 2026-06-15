# Endless Courier 2D Driving Game

## Description

Endless Courier is a 2D top-down driving game built in Unity where the player drives through a procedurally generated world, picks up packages, and delivers them to randomly spawned delivery points before the timer runs out.

The game features a full gameplay loop, obstacles, sound effects, and background music.

---

## Features

- Top-down car driving with acceleration and turning
- Procedural infinite road generation
- Package pickup system
- Delivery target system
- Pickup → Delivery gameplay loop
- Countdown timer
- Delivery score system
- Arrow pointing to current objective
- Oil spill obstacles that slow the player
- Background music system
- Sound effects (pickup and delivery)
- Restart game with R key

---

## Controls

- Move: WASD / Input System
- Restart: R

---

## Gameplay Loop

1. Drive through the world
2. Pick up a package (trophy icon)
3. Arrow points to delivery location (home icon)
4. Deliver package to gain score of plus +1
5. New package spawns after delivery
6. Repeat until timer reaches 0

---

## Win / Lose Condition

- Game ends when the timer reaches 0
- Press R to restart

---

## Scripts

- CarController.cs
Handles vehicle movement, acceleration, and rotation.
- CameraFollow.cs
Follows player through the game.
- WorldSpawner.cs
Generates and removes road chunks dynamically for an infinite map.
- TargetSpawner.cs
Spawns package pickup locations and delivery destinations.
- TargetArrow.cs
Points to the current active objective.
- Game Manager.cs
Handles:
- Timer
- Delivery score
- Game over state
- Restart system
- Audio (music and sound effects)

- ChunkData.cs
handles data points.
- MusicToggle.cs
plays background music.
- PlayerTriggers.cs
pickup up when player has pickup and delivered packages.


### 
---

## Audio

- Background music plays during gameplay
- Sound effects for pickup and delivery
- Music stops on game over
- Music restarts when the game is restarted

---

## How to Play

1. Open the project in Unity
2. Press Play
3. Drive and collect packages
4. Deliver them before time runs out
5. Press R to restart after game over

---

## Objective

Deliver as many packages as possible before time runs out.
