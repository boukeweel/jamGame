using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialBox : MonoBehaviour
{
    public Vector3 Startpos;

    private void Start()
    {
        Startpos = transform.position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TriggerCol"))
        {
            transform.position = Startpos;
        }
    }
}
