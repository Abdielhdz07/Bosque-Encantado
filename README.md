# Bosque Encantado

**Videojuego de plataformas 2D desarrollado en Unity**

**Autor:** Abdiel Hernández  
**Universidad:** Tecmilenio  
**Carrera:** Ingeniería en Desarrollo de Software  
**Proyecto:** Proyecto integrador de programación de videojuegos – Fase III  
**Año:** 2026

---

## Descripción del proyecto

Bosque Encantado es un videojuego de plataformas en 2D desarrollado con Unity y programado en C#.

El proyecto consiste en recorrer un bosque de fantasía, controlar a un personaje, superar obstáculos y enfrentarse a enemigos mientras se administra la vida del jugador y se acumulan puntos.

El videojuego utiliza una ambientación de tonos morados, árboles, plataformas y elementos visuales que buscan crear una experiencia sencilla y entretenida.

Este prototipo fue desarrollado como parte de un proyecto académico de la carrera de Ingeniería en Desarrollo de Software de la Universidad Tecmilenio.

## Objetivo del videojuego

El objetivo principal es avanzar por el escenario del bosque, evitar o enfrentar enemigos y conservar la vida del personaje.

Durante el recorrido, el jugador utiliza movimientos básicos para desplazarse y saltar entre las plataformas.

## Personaje principal

### Bolita

Bolita es el personaje principal del videojuego.

Se representa mediante una pequeña esfera blanca que puede desplazarse horizontalmente y realizar saltos.

**Características:**
- Movimiento hacia la izquierda y derecha.
- Capacidad de salto.
- Sistema de vida.
- Interacción con plataformas y enemigos.

Actualmente, el personaje cuenta con movimiento funcional, pero todavía no tiene animaciones visuales propias.

## Enemigos

### Esqueleto

El esqueleto es uno de los enemigos presentes en el escenario.

Su comportamiento se controla mediante scripts de C# que permiten gestionar el movimiento, las interacciones y el daño.

El sistema contempla la reducción de vida del enemigo y la asignación de puntos cuando es derrotado.

## Funcionalidades del prototipo

El videojuego incorpora las siguientes características:

- Escenario 2D con ambientación de bosque fantástico.
- Movimiento y salto del personaje.
- Plataformas y detección de colisiones.
- Enemigos con comportamiento programado.
- Sistema de vida y daño.
- Sistema de puntuación.
- Barra de vida e indicador de puntos.
- Menú principal.
- Menú de opciones.
- Gestión de audio y música.
- Iluminación y efectos ambientales.

## Tecnologías utilizadas

| Tecnología | Uso |
|---|---|
| Unity | Desarrollo del videojuego 2D |
| C# | Programación de mecánicas y sistemas |
| Visual Studio Code | Edición de código |
| GitHub | Almacenamiento y control de versiones |
| macOS | Entorno de desarrollo y generación del ejecutable |

## Organización del proyecto

El repositorio contiene las siguientes carpetas principales:

```text
Bosque-Encantado/
├── Assets/
│   ├── Scripts/
│   ├── Bosque_Level01.unity
│   ├── MainMenu.unity
│   └── OptionsMenu.unity
├── Packages/
├── ProjectSettings/
├── Scripts/
├── .gitignore
└── README.md
```

**Nota:** El repositorio contiene una versión parcial de los recursos del proyecto Unity. Algunos archivos gráficos y otros recursos utilizados por el prototipo todavía no están incluidos.

## Scripts principales

| Script | Función |
|---|---|
| PlayerMovement.cs | Controla el movimiento y salto |
| PlayerHealth.cs | Administra la vida del jugador |
| EnemyDamage.cs | Gestiona el daño del enemigo |
| EnemyPatrol.cs | Controla el patrullaje del enemigo |
| GameManager.cs | Administra la puntuación y funciones generales |
| AudioManager.cs | Gestiona el audio |
| MusicManager.cs | Controla la música |
| MenuPrincipal.cs | Administra las opciones del menú principal |
| OptionsManager.cs | Controla las opciones de configuración |
| LuzRespirante.cs | Gestiona un efecto de iluminación |

## Escenas del videojuego

**MainMenu:** pantalla principal con opciones para comenzar, acceder a la configuración y salir.

**Bosque_Level01:** escenario principal del bosque, donde se encuentran el personaje, las plataformas, los enemigos y la interfaz de juego.

**OptionsMenu:** pantalla de configuración del videojuego.

## Desarrollo del prototipo

El desarrollo se realizó de manera individual y se organizó en distintas etapas:

1. Investigación y conceptualización del videojuego.
2. Elaboración del documento de diseño (GDD).
3. Creación del escenario y selección de recursos gráficos.
4. Programación del movimiento y salto.
5. Implementación de enemigos.
6. Desarrollo de los sistemas de vida y puntuación.
7. Incorporación de menús, audio e iluminación.
8. Pruebas y correcciones.
9. Generación del ejecutable.
10. Documentación y control de versiones.

## Control de versiones

Se utilizó GitHub para registrar y almacenar avances del proyecto.

El repositorio contiene archivos de código fuente, configuraciones de Unity y escenas del videojuego.

Los cambios realizados se registran mediante commits, lo que permite consultar el historial de desarrollo.

**Repositorio:** https://github.com/Abdielhdz07/Bosque-Encantado

## Ejecutable del videojuego

Se generó una versión ejecutable del prototipo para macOS mediante las herramientas de compilación de Unity.

El ejecutable fue abierto y probado fuera del editor de Unity.

El archivo ejecutable no está incluido actualmente en este repositorio.

## Prueba del prototipo

Se realizó una prueba del videojuego con Abigail Hernández, una persona externa al desarrollo del proyecto.

La prueba permitió contar con la participación de otra persona en la evaluación del prototipo.

Como parte de la recopilación de opiniones sobre el videojuego, se identificaron propuestas de mejora relacionadas con:

- Incorporar expresiones o animaciones al personaje.
- Añadir elementos decorativos al escenario.
- Mantener controles sencillos.
- Incorporar objetos coleccionables.
- Mejorar la presentación del final del recorrido.

Estas propuestas forman parte de la retroalimentación recopilada para el proyecto.

## Plan de mejoras

| Mejora propuesta | Prioridad |
|---|---|
| Incorporar animaciones a Bolita | Alta |
| Revisar y mejorar la jugabilidad | Alta |
| Agregar objetos coleccionables | Media |
| Incorporar más elementos decorativos | Media |
| Mejorar los efectos de sonido | Media |
| Crear una pantalla de finalización | Media |
| Realizar nuevas pruebas con usuarios | Alta |

## Arte visual y narrativa

Bosque Encantado utiliza una estética de fantasía, con predominio de colores morados y elementos naturales.

La historia se desarrolla en un bosque misterioso que el personaje principal debe recorrer mientras supera los desafíos del entorno.

**Personajes principales:**

- **Bolita:** protagonista representado mediante una esfera blanca.
- **Esqueleto:** enemigo que representa uno de los obstáculos del recorrido.

El diseño del videojuego busca combinar una presentación visual llamativa con mecánicas fáciles de comprender.

## Estado actual

**Estado del proyecto: prototipo funcional en desarrollo.**

El videojuego cuenta con las mecánicas principales implementadas, un escenario jugable, sistemas de interfaz y una versión ejecutable para macOS.

Todavía existen oportunidades de mejora, especialmente en animaciones, contenido adicional y presentación visual.

## Conclusión

El desarrollo de Bosque Encantado permitió aplicar conocimientos de programación en C#, creación de videojuegos en Unity, diseño de escenarios, control de versiones y pruebas de software.

El proyecto representa una experiencia práctica de desarrollo de software, desde la conceptualización y elaboración del GDD hasta la implementación y evaluación de un prototipo funcional.

---

**Desarrollado por Abdiel Hernández**  
Ingeniería en Desarrollo de Software  
Universidad Tecmilenio — 2026
