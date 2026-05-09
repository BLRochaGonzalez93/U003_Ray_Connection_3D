# U003_Ray_Connection_3D

[English](README.en.md) | [Español](README.md)

## Resumen

Prototipo técnico jugable de puzzle 3D desarrollado en Unity con C#. El jugador debe colocar espejos en un tablero para dirigir un rayo principal hasta el punto final del nivel mediante rebotes.

La interacción principal consiste en colocar espejos con clic izquierdo, rotarlos con `A` y `D`, y rotar el tablero 90º con `Q` y `E`. Cada nivel limita el número máximo de espejos disponibles, lo que obliga al jugador a encontrar una solución eficiente. El prototipo actual incluye dos niveles.

## Tecnologías

- Unity
- C#
- Sistema de físicas 3D de Unity
- Collider / Rigidbody
- Raycast
- Line Renderer
- Particle System
- UI básica
- Post Processing
- Git LFS
- GitHub Releases

## Características principales

- Puzzle 3D basado en raycasts.
- Vista top-down en 3D.
- Colocación de espejos con clic izquierdo.
- Rotación de espejos con `A` y `D`.
- Rotación del tablero 90º con `Q` y `E`.
- Rayo inicial como emisor principal.
- Objeto final como receptor del rayo.
- Sistema de reflexión y rebote.
- Límite máximo de espejos por nivel.
- Interacción con objetos.
- Objetos movibles y rotables.
- Activadores / triggers.
- Sistema de puzzle.
- Validación de solución.
- Feedback visual.
- UI básica.
- Sistema de niveles.
- Victoria al resolver el puzzle.
- Partículas.
- Build jugable para Windows.

## Capturas

> Pendiente de añadir capturas finales.

Ruta prevista:

![Gameplay](./Media/screenshots/gameplay-01.png)

## Arquitectura

La lógica principal se divide en:

- `GameManager` — control global del nivel, estado del puzzle, validación de solución y victoria.
- `Repeater` — comportamiento de los espejos, reflexión del rayo y continuidad de la conexión.

Más información en:

[`Docs/Architecture.md`](./Docs/Architecture.md)

## Código recomendado para revisar

[`Project/Assets/Scripts/Repeater.cs`](./Project/Assets/Scripts/Repeater.cs)

## Build

La build está disponible en GitHub Releases.

[`Releases/Download.md`](./Releases/Download.md)

[Descargar build U003-v1.0.0](https://github.com/BLRochaGonzalez93/U003_Ray_Connection_3D/releases/tag/U003-v1.0.0)

## Estado

**Prototipo técnico jugable.**

El proyecto incluye interacción con objetos, raycast, emisores y receptores de rayos, reflejo de rayos, objetos rotables y movibles, activadores, sistema de puzzle, validación de solución, feedback visual, UI, sistema de niveles, victoria por puzzle completado y partículas.

Pendiente de posibles mejoras:

- Añadir más niveles.
- Añadir más tipos de puzzle.
- Añadir menú principal.
- Añadir sistema de pausa.
- Añadir feedback visual más claro.
- Añadir sonido.
- Mejorar iluminación.
- Añadir guardado de progreso.
- Añadir tutorial.
- Añadir animaciones de puertas o mecanismos.
- Añadir más objetos interactivos.

## Aprendizajes

Este proyecto me permitió practicar el uso de `Raycast` en 3D, aplicándolo a un sistema de puzzle basado en propagación, reflexión y validación de trayectorias.

También me permitió trabajar interacción con objetos, control de estados de activación y validación de puzzles mediante la conexión entre un emisor y un receptor.

Además, el proyecto me ayudó a estructurar una lógica técnica clara alrededor de un sistema reducido pero ampliable: emisor, espejos, receptor, manager global y feedback visual.
