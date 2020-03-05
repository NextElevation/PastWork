# Graphics Final Project
### Jake Lahr & Christain Garcia

# Project description
This is the final project for UNR CS 480 Graphics Class. We were giving the ability to create anything that we would like, but had to include model loading, physics, lighting, textures, keyboard input, and shaders written in GLSL.

We decided to focus our project on lighting by creating a marbles like game, but the marbles are their own light sources. You can spawn up to a hundred marables. Each marble cycles through different colors.

The model loading is done with Assimp (http://www.assimp.org/)

The physics is done with Bullet Physics Engine (https://github.com/bulletphysics)

The menu system utilized imgui (https://github.com/ocornut/imgui)

Window management is done with SDL (https://www.libsdl.org/)

All lighting done in this project is fragment lighting using the Phong Lighting Model.

This was a group project done by me (Jake Lahr) and my partner Christain Garcia. I focused most of my development on the lighting, shaders, and models of the project. While my partner configured the camera movement and helped with the ball spawning. We both worked on model and texture loading and the physics. 

## Building
To build and run this program, navigate to the correct directory. Make a new 'build' directory, cmake in previous directory, then make in the build directory.

Example:
```
mkdir build
cd build
cmake ..
make
./marbles 10
```

## Controls
Move camera:

    w: up

    s: down
    
    a: left
    
    d: right
    
    up: zoom in
    
    down: zoom out
    
    left/right: change focus
