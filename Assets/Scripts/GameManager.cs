using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject block;
    public Transform spawnPoint;
    public float maxX;
    public float spawnRate;
    bool notGameStarted = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && notGameStarted)
        {
            StartSpawning();
            notGameStarted = false;
            Debug.Log(notGameStarted);

        }
      

    }

    private void SpawnBlock()
    {
        Vector2 spawnPos = spawnPoint.position; 
        spawnPos.x = Random.Range(-maxX, maxX);
        Instantiate(block , spawnPos, Quaternion.identity);
    }

    private void StartSpawning()
    {
        InvokeRepeating("SpawnBlock", 0.5f, spawnRate);
    }
}


 /* invokerepeating and time.timescale

Think of a recipe for making pancakes:

methodName: This is like the recipe's name, such as "MakePancakes."

time: It's like saying, "Start making pancakes after waiting for 5 minutes."

repeatRate: Once you start making pancakes, it's like saying, "Make a new pancake every 2 minutes."

So, using InvokeRepeating is a bit like following a pancake recipe:

You're telling your chef to start making pancakes (methodName), but you're also saying, "Wait for 5 minutes before you start."

Once your chef begins, they'll keep making a new pancake (performing the action) every 2 minutes, just like you asked.

Now, about the note concerning Time.timeScale:

Time.timeScale is like adjusting how fast your kitchen's clock is ticking. If you stop the kitchen clock (timeScale = 0), your chef won't start making pancakes until you start the clock again. If you make time go faster (timeScale = 2), your chef will make pancakes at double the speed you asked for in the recipe.
So, in Unity, InvokeRepeating is like scheduling a specific action to happen after a delay and then continue repeating that action at a regular pace, much like following steps in a recipe to make pancakes at a certain rate, considering how fast time is passing.*/




