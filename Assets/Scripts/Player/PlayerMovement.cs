using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    public float moveSmoothTime;
    public float walkSpeed;

    private CharacterController _charController;
    private Vector3 _currentMoveVelocity;
    private Vector3 _moveDampVelocity;

    void Start()
    {
        _charController = GetComponent<CharacterController>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = 0f;
        float z = Input.GetAxisRaw("Vertical");

        Vector3 PlayerInput = new Vector3(x, y, z);

        if (PlayerInput.magnitude > 1f) {
            PlayerInput.Normalize();
        }

        Vector3 MoveVector = transform.TransformDirection(PlayerInput);

        _currentMoveVelocity = Vector3.SmoothDamp(_currentMoveVelocity, MoveVector * walkSpeed, ref _moveDampVelocity, moveSmoothTime);
        _charController.Move(_currentMoveVelocity * Time.deltaTime);

    }
}
