using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class door : MonoBehaviour
{
    public pressurpat Prp;

    private SpriteRenderer spr;
    private BoxCollider2D BC2d;
    
    public Color lightred;
    public Color darkred;

    public Image images;

    public List<Sprite> sprites = new List<Sprite>();

    public SpriteRenderer spritedoor1;
    public SpriteRenderer spritedoor2;

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

            spritedoor1.sprite = sprites[1];
            if(spritedoor2 != null)
            {
                spritedoor2.sprite = sprites[1];
            }
            BC2d.enabled = false;
            
            dooropen = true;
        }
        else
        {
            spritedoor1.sprite = sprites[0];
            if (spritedoor2 != null)
            {
                spritedoor2.sprite = sprites[0];
            }

            BC2d.enabled = true;
            
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
