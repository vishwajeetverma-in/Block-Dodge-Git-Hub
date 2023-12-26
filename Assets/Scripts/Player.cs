using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Vector2 touchPos = Camera.main.ScreenToViewportPoint ( Input.mousePosition); // Screen gets partitioned at centre is 0 ,left is negative, right is positive
            if(touchPos.x < 0)
            {

            }
           


        }
        else
        {
            rb.velocity = Vector2.zero;

        }
        
    }
}
