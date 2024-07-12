using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private float _rotateSpeedCam = 10.0f, speed = 10.0f;

    private float _mult = 1f;
    private void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float rotate = 0f;

        if (Input.GetKey(KeyCode.Q))
            rotate = -1f;

        else if (Input.GetKey(KeyCode.E))
            rotate = 1f;

        _mult = Input.GetKey(KeyCode.LeftShift) ? 2f :1f;

        transform.Rotate(Vector3.up * _rotateSpeedCam * Time.deltaTime * rotate * _mult, Space.Self);
        transform.Translate(new Vector3(horizontal, 0, vertical)*Time.deltaTime * _mult * speed,Space.Self);
    }
}
