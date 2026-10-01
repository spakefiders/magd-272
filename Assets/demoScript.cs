using System;
using UnityEngine;

public class demoScript : MonoBehaviour
{
    int numLives = 3;
    float floatDemo = 3.14f;
    string stringDemo = "hi"; 
    
    void Start()
    {
        print(numLives);
        numLives = numLives + 1;
        print(numLives);
        print("Hello World!");
        print(floatDemo);
        print(stringDemo);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
