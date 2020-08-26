using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class specailbox : MonoBehaviour
{

    public Vector3 startpos;


    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("door"))
        {
            transform.position = startpos;
        }
    }
}
