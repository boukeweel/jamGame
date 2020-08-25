using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public pressurpat Prp;

    private SpriteRenderer spr;
    private BoxCollider2D BC2d;
    public Color color;

    private void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        BC2d = GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        if(Prp.SomeThingOn == true)
        {
            BC2d.enabled = false;
            spr.color = color;
        }
        else
        {
            BC2d.enabled = true;
            spr.color = Color.white;
        }
    }
}
