using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float _speed;
    [SerializeField]
    float _distanceToGround; // snapping distance to the ground

    public LayerMask terrainLayer;
    public Rigidbody rb;
    public SpriteRenderer sr;
    
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        // -------------------------------------------------ADJUST POS----------------------------------------------------------------------
        RaycastHit hit; 
        Vector3 castPos = transform.position;
        castPos.y += 1; // shoot a line from the player downwards that only detects the terrain layer
        if (Physics.Raycast(castPos, -transform.up, out hit, Mathf.Infinity, terrainLayer))
        {
            if(hit.collider != null)
            {
                Vector3 movePos = transform.position;
                movePos.y = hit.point.y + _distanceToGround;
                transform.position = movePos; // move the player a set height above the point it hit
            }
        }

        // --------------------------------------------------MOVEMENT-----------------------------------------------------------------------
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 moveDir = new Vector3(x, 0, y);
        rb.velocity = moveDir * _speed;

        if(x != 0 && x < 0)
        {
            sr.flipX = true;
        }
        else if(x != 0 && x > 0)
        {
            sr.flipX = false;
        }
    }
}
