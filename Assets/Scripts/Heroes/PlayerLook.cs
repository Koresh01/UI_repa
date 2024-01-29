using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
  
    private Quaternion LookDirection;

    void Start()
    {
        LookDirection = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = LookDirection;
    }
}
