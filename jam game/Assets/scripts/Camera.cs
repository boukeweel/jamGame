using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform Target;


    private void Update()
    {
        if (transform.position.x - Target.position.x >= 9.5f)
            StartMove(-19.55f, 0);
        if (transform.position.x - Target.position.x <= -9.5f)
            StartMove(19.55f, 0);
        if (transform.position.y - Target.position.y >= 5.5f)
            StartMove(0, -11);
        if (transform.position.y - Target.position.y <= -5.5f)
            StartMove(0, 11);
    }

    public void StartMove(float x,float y)
    {
        transform.position += new Vector3(x, y, 0);
    }
}
