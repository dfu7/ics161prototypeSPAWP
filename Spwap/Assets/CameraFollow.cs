using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _main;
    [SerializeField] private float smoothSpeed;
    [SerializeField] Vector3 offset;

    private void FixedUpdate()
    {
        Vector3 pos = _main.position + offset;
        Vector3 smoothPos = Vector3.Lerp(transform.position, pos, smoothSpeed);
        transform.position = smoothPos;

        transform.LookAt(_main);
    }
}
