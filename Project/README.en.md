# U003_Ray_Connection_3D

[English](README.en.md) | [Español](README.md)

## Summary

Playable 3D technical puzzle prototype developed in Unity with C#. The player must place mirrors on a board to direct a main ray to the level endpoint through bounces.

The main interaction consists of placing mirrors with left click, rotating them with `A` and `D`, and rotating the board 90º with `Q` and `E`. Each level limits the maximum number of available mirrors, forcing the player to find an efficient solution. The current prototype includes two levels.

## Technologies

- Unity
- C#
- Unity 3D physics system
- Collider / Rigidbody
- Raycast
- Line Renderer
- Particle System
- Basic UI
- Post Processing
- Git LFS
- GitHub Releases

## Main features

- 3D puzzle based on raycasts.
- 3D top-down view.
- Mirror placement with left click.
- Mirror rotation with `A` and `D`.
- 90º board rotation with `Q` and `E`.
- Initial ray as the main emitter.
- Final object as the ray receiver.
- Reflection and bounce system.
- Maximum mirror limit per level.
- Object interaction.
- Movable and rotatable objects.
- Activators / triggers.
- Puzzle system.
- Solution validation.
- Visual feedback.
- Basic UI.
- Level system.
- Victory by solving the puzzle.
- Particles.
- Playable Windows build.

## Screenshots

> Final screenshots pending.

Planned path:

![Gameplay](./Media/screenshots/gameplay-01.png)

## Architecture

The main logic is divided into:

- `GameManager` — global level control, puzzle state, solution validation and victory.
- `Repeater` — mirror behavior, ray reflection and connection continuity.

More information:

[`Docs/Architecture.md`](./Docs/Architecture.md)

## Recommended code to review

[`Project/Assets/Scripts/Repeater.cs`](./Project/Assets/Scripts/Repeater.cs)

## Build

The build is available through GitHub Releases.

[`Releases/Download.md`](./Releases/Download.md)

[Download build U003-v1.0.0](https://github.com/BLRochaGonzalez93/U003_Ray_Connection_3D/releases/tag/U003-v1.0.0)

## Status

**Playable technical prototype.**

The project includes object interaction, raycast, ray emitters and receivers, ray reflection, movable and rotatable objects, activators, puzzle system, solution validation, visual feedback, UI, level system, puzzle-completed victory and particles.

Possible pending improvements:

- Add more levels.
- Add more puzzle types.
- Add a main menu.
- Add a pause system.
- Add clearer visual feedback.
- Add sound.
- Improve lighting.
- Add progress saving.
- Add a tutorial.
- Add door or mechanism animations.
- Add more interactive objects.

## Learnings

This project allowed me to practice using `Raycast` in 3D, applying it to a puzzle system based on propagation, reflection and trajectory validation.

It also allowed me to work on object interaction, activation-state control and puzzle validation through the connection between an emitter and a receiver.

In addition, the project helped me structure clear technical logic around a small but expandable system: emitter, mirrors, receiver, global manager and visual feedback.
