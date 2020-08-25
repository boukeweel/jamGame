using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D Rig;

    public int Speed;
    public int S_speed;

    private bool Sprinting = false;


    private void Start()
    {
        Rig = GetComponent<Rigidbody2D>();
        S_speed = Speed;

    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            Speed -= S_speed;

        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Speed = 8;
        }
    }
    private void FixedUpdate()
    {
        Rig.MovePosition(transform.position + M_input() * Time.deltaTime * Speed);

    }
    

    public Vector3 M_input()
    {
        return new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"),0);
    }
}
