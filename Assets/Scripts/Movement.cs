using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private Transform Player;

    private void Start()
    {
        Player = GetComponent<Transform>();
    }

    private void Update()
    {

        if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            Player.position += new Vector3(-3.5f, 0, 0);
        }

        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            Player.position += new Vector3(3.5f, 0, 0);
        }
        /*if (Lane3 == true)
        {
            Player.position += new Vector3(5f, 0, 0);
        }
        else if (Lane1 == true)
        {
            Player.position += new Vector3(-5f, 0, 0);
        }
        else if (Lane2 == true && Keyboard.current.dKey.isPressed)
        {
            Player.position += new Vector3(10.5f, 0, 0);
        }
        else if (Lane2 == true && Player.position.x >= 0.1f)
        {
            Player.position += new Vector3(0, 0, 0);
        }



        if (Keyboard.current.dKey.isPressed && Lane3 == false && Lane1 == true)
        {
            Lane2 = true;
            Lane1 = false;
            Lane3 = false;
        }
        else if (Keyboard.current.aKey.isPressed && Lane2 == true)
        {
            Lane1 = true;
            Lane2 = false;
            Lane3 = false;
        }
        else if (Keyboard.current.dKey.isPressed && Lane2 == true)
        {
            Lane3 = true;
            Lane1 = false;
            Lane2 = false;
        }
        else if (Keyboard.current.aKey.isPressed && Lane1 == false && Lane3 == true)
        {
            Lane2 = true;
            Lane1 = false;
            Lane3 = false;
        }*/
    }
}