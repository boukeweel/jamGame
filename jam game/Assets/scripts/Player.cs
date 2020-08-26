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

    private SpriteRenderer Spr;

    public List<Sprite> sprites = new List<Sprite>();

    public float rollspeed;
    public float rollTimer;

    private void Start()
    {
        Rig = GetComponent<Rigidbody2D>();
        Spr = GetComponent<SpriteRenderer>();
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
            Spr.sprite = sprites[2];
            Yaxis = 0;
        }
        else if (Xaxis > 0.1f)
        {
            Spr.sprite = sprites[3];
            Yaxis = 0;
        }
        if (Yaxis < -0.1f)
        {
            Spr.sprite = sprites[0];
            Xaxis = 0;
        }
        else if (Yaxis > 0.1f)
        {
            Spr.sprite = sprites[1];
            Xaxis = 0;
        }

        //if(Input.GetKeyDown(KeyCode.Space) && rollTimer <= 0)
        //{
        //    Rig.AddForce(transform.position + new Vector3(Xaxis, Yaxis) * rollspeed, ForceMode2D.Impulse);
            
        //    rollTimer = 2f;
        //}
        


        V_direction = new Vector3(Xaxis * Speed, Yaxis * Speed);
        transform.position = transform.position + (V_direction * Time.deltaTime);

    }
    

    
}
