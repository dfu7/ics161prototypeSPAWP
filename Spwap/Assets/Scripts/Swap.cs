using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swap : MonoBehaviour
{
    public Material centerMat;
    public Material rotateMat;

    [SerializeField] public GameObject Player;
    [SerializeField] public GameObject sphere1;
    [SerializeField] public GameObject connector;
    [SerializeField] public GameObject sphere2;

    private Vector3 rotationPos;

    private GameObject centerSphere;

    public float rotationSpeed = 100;

    private void Start()
    {
        centerSphere = sphere1;
        SwapSphere();
    }

    private void Update()
    {
        transform.RotateAround(rotationPos, -Vector3.forward, rotationSpeed * Time.deltaTime);
    }

    public void OnSwap()
    {
        SwapSphere();
    }
    
    void SwapSphere()
    {
        if (centerSphere == sphere2)
        {
            sphere1.GetComponent<MeshRenderer>().material = centerMat;
            sphere2.GetComponent<MeshRenderer>().material = rotateMat;
            connector.GetComponent<MeshRenderer>().material = rotateMat;

            centerSphere = sphere1;
            rotationPos = sphere1.transform.position;
        }
        else if (centerSphere = sphere1)
        {

            sphere2.GetComponent<MeshRenderer>().material = centerMat;
            sphere1.GetComponent<MeshRenderer>().material = rotateMat;
            connector.GetComponent<MeshRenderer>().material = rotateMat;

            centerSphere = sphere2;
            rotationPos = sphere2.transform.position;
        }
    }
}
