# U003_Ray_Connection_3D

[English](README.en.md) | [Español](README.md)

## Resumen

**Ray Connection 3D** es un prototipo técnico jugable de puzzle 3D desarrollado en Unity con C#. El proyecto está basado en el uso de raycasts y reflexión de rayos: el jugador debe colocar espejos sobre un tablero para hacer que el rayo principal rebote hasta alcanzar el punto final del nivel.

El jugador coloca espejos con clic izquierdo, modifica su orientación con las teclas `A` y `D`, y puede rotar el tablero 90º con `Q` y `E`. Cada nivel define un número máximo de espejos disponibles, por lo que la solución requiere pensar la colocación y orientación correcta de cada reflector. El prototipo actual incluye dos niveles.

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
- Colocación de espejos mediante clic izquierdo.
- Rotación de espejos con `A` y `D`.
- Rotación del tablero 90º con `Q` y `E`.
- Emisor de rayo principal.
- Receptor o punto final del nivel.
- Sistema de rebote y reflexión del rayo.
- Límite máximo de espejos por nivel.
- Objetos movibles y rotables.
- Activadores / triggers.
- Validación de solución del puzzle.
- Feedback visual del rayo.
- UI básica para información de nivel.
- Sistema de niveles.
- Victoria al conectar el rayo con el objetivo final.
- Partículas.
- Dos niveles incluidos en el prototipo actual.
- Build jugable para Windows.

## Visuales

> Pendiente de añadir capturas e imágenes finales.

Nombres previstos para el pack visual:

- `rayconnection-logo.png`
- `rayconnection-cover.png`
- `rayconnection-banner.png`
- `rayconnection-thumbnail-01-ray-emitter.png`
- `rayconnection-thumbnail-02-mirror-placement.png`
- `rayconnection-thumbnail-03-board-rotation.png`
- `rayconnection-thumbnail-04-completed-connection.png`

## Arquitectura

La lógica principal se divide en:

- `GameManager` — control global de nivel, estado del puzzle, validación, victoria y flujo de partida.
- `Repeater` — comportamiento de los espejos, rebote del rayo y continuidad de la conexión.

## Código recomendado para revisar

[`Project/Assets/Scripts/Repeater.cs`](./Project/PRJ_Rayos3D/Assets/Scripts/Repeater.cs)

## Build

La build está disponible en GitHub Releases.

[Descargar build U003-v1.0.0](https://github.com/BLRochaGonzalez93/U003_Ray_Connection_3D/releases/tag/U003-v1.0.0)

## Estado

**Prototipo técnico jugable.**

El proyecto incluye una base funcional de puzzle con raycast, emisor, receptor, colocación de espejos, rotación de espejos, rotación del tablero, validación de solución, feedback visual, partículas, UI básica y dos niveles jugables.

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

Este proyecto me permitió practicar el uso de `Raycast` en un entorno 3D, trabajando la propagación de un rayo, su interacción con objetos y la validación de una solución de puzzle.

También me ayudó a entender mejor cómo estructurar un sistema basado en emisores, reflectores, receptores y estado global de nivel.

Además, el proyecto me permitió trabajar con objetos movibles y rotables, feedback visual mediante línea de rayo y partículas, y control de estados de activación para determinar cuándo un puzzle está resuelto.
