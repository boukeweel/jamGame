﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text_time : MonoBehaviour
{
    public float time;

    private void Update()
    {
        time -= Time.deltaTime;
        if(time <= 0)
        {
            Destroy(gameObject);
        }
    }
}
