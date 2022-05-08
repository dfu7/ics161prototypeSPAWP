using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swap : MonoBehaviour
{
    public Material centerMat;
    public Material rotateMat;

    [SerializeField] public GameObject controls;
    [SerializeField] public GameObject sphere1;
    [SerializeField] public GameObject connector;
    [SerializeField] public GameObject sphere2;

    private GameObject centerSphere;

    public float rotationSpeed = 100;

    private void Start()
    {
        SwapParent();
    }

    private void Update()
    {
        connector.transform.RotateAround(centerSphere.transform.position, -Vector3.forward, rotationSpeed * Time.deltaTime);
    }

    public void OnSwap()
    {
        SwapParent();
    }
    
    void SwapParent()
    {
        if (sphere1.transform.childCount == 0)
        {
            sphere1.transform.SetParent(controls.transform);
            connector.transform.SetParent(sphere1.transform);
            sphere2.transform.SetParent(connector.transform);

            sphere1.GetComponent<MeshRenderer>().material = centerMat;
            sphere2.GetComponent<MeshRenderer>().material = rotateMat;
            connector.GetComponent<MeshRenderer>().material = rotateMat;

            centerSphere = sphere1;

            Debug.Log("1");
        }
        else if (sphere2.transform.childCount == 0)
        {
            sphere2.transform.SetParent(controls.transform);
            connector.transform.SetParent(sphere2.transform);
            sphere1.transform.SetParent(connector.transform);

            sphere2.GetComponent<MeshRenderer>().material = centerMat;
            sphere1.GetComponent<MeshRenderer>().material = rotateMat;
            connector.GetComponent<MeshRenderer>().material = rotateMat;

            centerSphere = sphere2;

            Debug.Log("2");
        }
    }
}
