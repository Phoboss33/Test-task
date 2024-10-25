using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouseControll : MonoBehaviour
{
    public float sensitvity;

    private Transform _playerCamera;
    private Vector2 XYRotation;

    void Start()
    {
        _playerCamera = Camera.main.transform;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        Vector2 MouseInput = new Vector2 {
            x = Input.GetAxis("Mouse X"),
            y = Input.GetAxis("Mouse Y")
        };

        XYRotation.x -= MouseInput.y * sensitvity;
        XYRotation.y += MouseInput.x * sensitvity;

        XYRotation.x = Mathf.Clamp(XYRotation.x, -90f, 90f);

        transform.eulerAngles = new Vector3(0f, XYRotation.y, 0f);
        _playerCamera.localEulerAngles = new Vector3(XYRotation.x, 0f, 0f);
    }
}
