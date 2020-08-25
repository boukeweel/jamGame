using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doos : MonoBehaviour
{

    public bool Holding;
    private Collider2D col_;
    private void Update()
    {
        if(Holding == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                this.transform.parent = col_.transform;

            }
            if (Input.GetKeyUp(KeyCode.Space))
                this.transform.parent = null;
        }
        else
        {
            this.transform.parent = null;
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("au");
        
        if (col.gameObject.tag == "Player")
        {
            col_ = col.collider;
            Holding = true;
        }
        
    }
    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
            Holding = false;
    }
}
