# unity
방향키 조작
```
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class d : MonoBehaviour
{
    public Rigidbody body;
    public float speed = 10f;
    float x = 0
        , y = 0;
    
    

        Vector2 vt = new Vector2(0, 0);

    

    
    void Update()
    {
        if (Input.anyKeyDown)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
               
                this.transform.Translate(0.0f, 0.1f, 0.0f);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
              
                this.transform.Translate(0.0f, -0.1f, 0.0f);

            }

            else if (Input.GetKey(KeyCode.LeftArrow))
            {
               
                this.transform.Translate(-0.1f,0.0f, 0.0f);
            }

            else if (Input.GetKey(KeyCode.RightArrow))
            {
                this.transform.Translate(0.1f, 0.0f, 0.0f);
            }


        }
    }
}



```
