using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float movSpeed;
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
            Vector2 touchPos = Camera.main.ScreenToWorldPoint ( Input.mousePosition); // Screen gets partitioned at centre is 0 ,left is negative, right is positive
            if(touchPos.x < 0)
            {
                rb.AddForce(Vector2.left * movSpeed);
            }
            else
            {
                rb.AddForce(Vector2.right * movSpeed);
            }
           


        }
        else
        {
            rb.velocity = Vector2.zero;

        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Block")
        {
            SceneManager.LoadScene("Level1");
        }
    }
}
