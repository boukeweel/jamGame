using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class door : MonoBehaviour
{
    public pressurpat Prp;

    private SpriteRenderer spr;
    private BoxCollider2D BC2d;
    public Color color;
    public Color lightred;
    public Color darkred;

    public Image images;

    public bool dooropen = false;
    private void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        BC2d = GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        if (Prp.SomeThingOn == true)
        {
            BC2d.enabled = false;
            spr.color = color;
            dooropen = true;
        }
        else
        {
            BC2d.enabled = true;
            spr.color = Color.white;
            dooropen = false;
        }
        if (dooropen == true)
        {
            images.color = lightred;
        }
        if (dooropen == false)
        {
            images.color = darkred;
        }
        
    }
}
