using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance = null;
    public bool moveRight;
    public bool moveLeft;

    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        } else if(Instance != this)
        {
            Destroy(this.gameObject);
        }
    }

    void Update()
    {
        
    }
}
