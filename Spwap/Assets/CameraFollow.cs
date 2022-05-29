using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private float smoothSpeed;
    [SerializeField] Vector3 offset;
    [SerializeField] private Transform _main;
    [SerializeField] private Vector3 minValues, maxValues;

    private void FixedUpdate()
    {
        Vector3 pos = _main.position + offset;
        Vector3 boundPos = new Vector3(
            Mathf.Clamp(pos.x, minValues.x, maxValues.x),
            Mathf.Clamp(pos.y, minValues.y, maxValues.y),
            Mathf.Clamp(pos.z, minValues.z, maxValues.z));
        Vector3 smoothPos = Vector3.Lerp(transform.position, boundPos, smoothSpeed);
        transform.position = smoothPos;

        transform.LookAt(_main);
    }
}
