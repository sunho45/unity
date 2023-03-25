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

```
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class d : MonoBehaviour
{
    public Rigidbody body;
    public float speed = 10f;
   public static  float x = 0
        , y = 0;
    
    

        Vector2 vt = new Vector2(0, 0);
    Vector2 velo = Vector2.zero;



    void Update()
    {
        if (Input.anyKeyDown)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
               
                this.transform.Translate(0.0f, 1f, 0.0f);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
              
                this.transform.Translate(0.0f, -1f, 0.0f);

            }

            else if (Input.GetKey(KeyCode.LeftArrow))
            {
               
                this.transform.Translate(-1f,0.0f, 0.0f);
            }

            else if (Input.GetKey(KeyCode.RightArrow))
            {
                Debug.Log(x);
                x++;
                
                
                Vector2 target = new Vector2(0.3f + vt.x, vt.y);
                transform.position = Vector2.SmoothDamp(transform.position, target,ref velo, 0.3f);
            }


        }
    }
}


```
변수 rigid에 rigidbody 속성부여
```
Rigidbody rigid;
    void Start()
    {
        rigid =GetComponent<Rigidbody>();
        rigid.velocity = Vector3.left;//왼쪽 방향으로 이동
        rigid.velocity = Vector3.right; //오른쪽 방향으로 
        rigid.AddForce(Vector3.up * 5, ForceMode.Impulse); //위로 힘을 
    }
void FixedUpdate()
    {
        
    }// 속력 관련해서는 fixedupdate에 써야 한다.

```
물체에 힘을 
```
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Rigidbody rigid;
    void Start()
    {
        rigid =GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log(3);
            rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }
    }
}
```
