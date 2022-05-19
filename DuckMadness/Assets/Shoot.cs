using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    Vector3 shoot_ = new Vector3 (0, 0, 0.5f);


    void OnCollisionEnter(Collision collision)
        {
            Destroy (gameObject);
         
        }
   
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         transform.position = transform.position +shoot_;
    }
}
