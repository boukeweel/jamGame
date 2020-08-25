using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D Rig;

    public int Speed;
    public int S_speed;

    [SerializeField] private Vector3 V_direction;

    private bool Sprinting = false;
    [SerializeField] private float Xaxis;
    [SerializeField] private float Yaxis;

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
        Xaxis = Input.GetAxis("Horizontal"); 
        Yaxis = Input.GetAxis("Vertical");
       
        if (Xaxis < -0.1f)
        {
            //left
            Yaxis = 0;
        }
        else if (Xaxis > 0.1f)
        {
            //right
            Yaxis = 0;
        }
        if (Yaxis < -0.1f)
        {
            //down
            Xaxis = 0;
        }
        else if (Yaxis > 0.1f)
        {
            //up
            Xaxis = 0;
        }


        V_direction = new Vector3(Xaxis * Speed, Yaxis * Speed);
        transform.position = transform.position + (V_direction * Time.deltaTime);

    }
    

    
}
