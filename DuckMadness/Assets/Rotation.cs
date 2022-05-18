using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
     public GameObject[] targets;
     int current = 0;
     float rotSpeed;
     public float Speed;
     float WPradius = 1;
     bool alive = true;
     void OnCollisionEnter(Collision collision)
        {
            if(alive == true)
                {
                     transform.Rotate(new Vector3(0, 0, 90));
                     alive = false;  
                }      
        }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(targets[current].transform.position, transform.position) < WPradius)
        {
            current++;

            if(current >= targets.Length)
            {
                current = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, targets[current].transform.position, Time.deltaTime * Speed);
    }
        
}
