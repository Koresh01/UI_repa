using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private FixedJoystick _walkJoystick;
    [SerializeField] private FixedJoystick _attackJoystick;
    [SerializeField] public float moveSpeed;
    [SerializeField] public float rotationSpeed;


    private void Update()
    {
        WalkInput();
        MouseInput();
    }

    void WalkInput()
    {
        float horizontal = _walkJoystick.Horizontal;
        float vertical = _walkJoystick.Vertical;

        Vector3 movement = new Vector3(horizontal, 0f, vertical) * moveSpeed * Time.deltaTime;
        transform.position += movement;

        if (movement != Vector3.zero)
        {
            //Quaternion toRotation = Quaternion.LookRotation(movement.normalized, Vector3.up);
            //transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }
    void MouseInput()
    {
        float horizontal = _attackJoystick.Horizontal;
        float vertical = _attackJoystick.Vertical;

        Vector3 movement = new Vector3(horizontal, 0f, vertical) * moveSpeed * Time.deltaTime;

        if (movement != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movement.normalized, Vector3.up);
            transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
