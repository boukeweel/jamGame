using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class door : MonoBehaviour
{
    public pressurpat Prp;

    private SpriteRenderer spr;
    private BoxCollider2D BC2d;
    
    public Color lightred;
    public Color darkred;

    public Image images;

    public List<Sprite> sprites = new List<Sprite>();


    private AudioSource AuS;
    public List<AudioClip> Audios = new List<AudioClip>();

    public SpriteRenderer spritedoor1;
    public SpriteRenderer spritedoor2;


    public bool playonce, playonce2;
    public bool dooropen = false;
    private void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        AuS = GetComponent<AudioSource>();
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
            if(playonce == true)
            {
                AuS.clip = Audios[0];
                AuS.Play();
                playonce = false;
                playonce2 = true;
            }
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
            if(playonce2 == true)
            {
                AuS.clip = Audios[1];
                AuS.Play();
                playonce = true;
                playonce2 = false;
            }
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
