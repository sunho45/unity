using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int itemcount = 0;
    Rigidbody rt;
    public bool Isjump;
    // Start is called before the first frame update
    AudioSource Audio;
    void Awake()
    {
        rt=GetComponent<Rigidbody>();
        Audio= GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (Isjump)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    rt.AddForce(new Vector3(0, 6, 0), ForceMode.Impulse);
                    
                }

            }
        }

       



    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");


        float v = Input.GetAxisRaw("Vertical");
        

        rt.AddForce(new Vector3(h, 0, v),ForceMode.Impulse);

    }
    void OnTriggerEnter(Collider other)
    {

        if (other.name=="coin")
        {
            Console.Write(3);

            Audio.Play();
            itemcount++;
            
            other.gameObject.SetActive(false);
        }
    }
}
