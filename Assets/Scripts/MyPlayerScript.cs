using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class MyPlayerScript : MonoBehaviour
{
    public bool pressed;
    public bool north;
    public bool west;
    public bool east;
    Gamepad controller;
    ButtonControl south;

    public InputAction testAction;

    void Start()
    {
        controller = Gamepad.current;
        south = controller.buttonSouth;
    }

    // Update is called once per frame
    void Update()
    {
        pressed = south.isPressed;
        if (controller.buttonNorth.isPressed)
        {
            north = true;
        }
        if (controller.buttonWest.wasPressedThisFrame)
        {
            west = !west;
        }
        if (controller.buttonEast.wasReleasedThisFrame)
        {
            east = !east;
            if (east)
            {
                testAction.Enable();
            }
            else
            {
                testAction.Disable();
            }
        }





        if (testAction.triggered)
        {
            Pause();
        }
    }

    void Pause()
    {
        Debug.Log("Pasued the Game");

    }
}
