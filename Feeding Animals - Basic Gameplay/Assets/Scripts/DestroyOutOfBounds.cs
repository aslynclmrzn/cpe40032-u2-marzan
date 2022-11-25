using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 45f;
    public float lowerBound = 14f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -lowerBound)
        {
            Destroy(gameObject);
            Time.timeScale = 0;
        }
        else if (transform.position.z > topBound)
        {
            
            Destroy(gameObject);
        }

     
    }
    
}
