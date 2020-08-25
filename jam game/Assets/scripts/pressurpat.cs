using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressurpat : MonoBehaviour
{

    private bool SomeThingOn = false;

    private SpriteRenderer Spr;

    public Color color_;

    private void Start()
    {
        Spr = GetComponent<SpriteRenderer>();  
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log(SomeThingOn);
        }
        if(SomeThingOn == true)
        {
            Spr.color = color_;
        }
        else
        {
            Spr.color = Color.white;
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
