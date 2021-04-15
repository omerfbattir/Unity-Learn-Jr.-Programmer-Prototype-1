using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] private float rotateSpeed;
    
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.forward * speed * vertical);
        transform.Rotate(Vector3.up, rotateSpeed * horizontal);
    }
}
