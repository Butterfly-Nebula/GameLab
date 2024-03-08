using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] 
    private float _speed;

    void Update()
    {
        if (InputManager.Instance.moveRight && InputManager.Instance.moveLeft)
        {
            return;
        }

        if (InputManager.Instance.moveRight)
        {
            this.gameObject.transform.Translate(Vector3.forward * _speed * Time.deltaTime);
            this.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }

        if (InputManager.Instance.moveLeft)
        {
            this.gameObject.transform.Translate(Vector3.forward * _speed * Time.deltaTime);
            this.gameObject.transform.rotation = Quaternion.Euler(0f, -180f, 0f);
        }
    }
}
