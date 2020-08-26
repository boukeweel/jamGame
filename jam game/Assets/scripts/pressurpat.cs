using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressurpat : MonoBehaviour
{

    public bool SomeThingOn = false;

     private AudioSource sound;

    private SpriteRenderer Spr;

    public Color color_;

    private bool playonce;
    private void Start()
    {
        Spr = GetComponent<SpriteRenderer>();
        sound = GetComponent<AudioSource>();
    }
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log(SomeThingOn);
        }
        if(SomeThingOn == true)
        {
            //Spr.color = color_;
            if(playonce == true)
            {
                sound.Play();
                playonce = false;
            }
            
        }
        else
        {
            //Spr.color = Color.white;
            playonce = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("yep");
        SomeThingOn = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        SomeThingOn = false;
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        SomeThingOn = true;
    }
}
