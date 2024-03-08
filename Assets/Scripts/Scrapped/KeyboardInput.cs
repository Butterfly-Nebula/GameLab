using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            InputManager.Instance.moveRight = true;
        } else
        {
            InputManager.Instance.moveRight = false;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            InputManager.Instance.moveLeft = true;
        }
        else
        {
            InputManager.Instance.moveLeft = false;
        }
    }
}
