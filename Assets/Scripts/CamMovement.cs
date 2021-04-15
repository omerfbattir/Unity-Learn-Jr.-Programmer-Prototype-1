using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    [SerializeField] private Transform vhcl;
    [SerializeField] private Vector3 offset;

    void Update()
    {
        transform.position = vhcl.transform.position + offset;
    }
}
