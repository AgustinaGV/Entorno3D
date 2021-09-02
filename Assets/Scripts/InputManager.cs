using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public float verticalAxis;
    public float horizontalAxis;

    public KeyCode keyUp, keyDown, keyRight, keyLeft, keyJump;

    void Update()
    {
        //establezco cómo se mueve el personaje, cuánto avanza con la presión de qué teclas. Son variables así el codigo puede usarse para distintos characters;
        if (Input.GetKey(keyUp)) {
            verticalAxis = 1;
        } else if (Input.GetKey(keyDown)) {
            verticalAxis = -1;
        } else {
            verticalAxis = 0;
        }

         if (Input.GetKey(keyRight)) {
            horizontalAxis = 1;
        } else if (Input.GetKey(keyLeft)) {
            horizontalAxis = -1;
        } else {
            horizontalAxis = 0;
        } 
    }
    
    
}
