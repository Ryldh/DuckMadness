using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunMovement : MonoBehaviour
{
    Vector3 movement = new Vector3 (-0.01f, 0, 0);
    public GameObject cannon;
    public GameObject shoot;
    Quaternion rotation = Quaternion.Euler(90, 0, 0);
    bool ammo = true;

    
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 position = cannon.transform.position;
        if(Input.GetKey(KeyCode.A))
        {
            if(transform.position.x > -6.6f)
            {
                transform.position = transform.position +movement;
             }
        }
        if(Input.GetKey(KeyCode.D))
        {
            if(transform.position.x < 6.6f)
            {
                transform.position = transform.position -movement;
            }
        }
        
             if (ammo == true)
            {
                    if(Input.GetKeyDown(KeyCode.Space))
                     {
                        Instantiate(shoot, position, rotation);
                        Puntuacion.ammo -= 1;
                        Debug.Log ("<color=red>Te quedan: " +Puntuacion.ammo +" balas</color>");
                     }
                 if(Puntuacion.ammo == 0)
            {
                 Debug.Log ("<color=red>No te queda municion</color>");
                 ammo = false;
            }
            }
    }
}
