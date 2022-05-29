using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swap : MonoBehaviour
{
    public Material centerMat;
    public Material rotateMat;

    [SerializeField] public GameObject sphere1;
    [SerializeField] public GameObject connector;
    [SerializeField] public GameObject sphere2;
    [SerializeField] private GameObject _panel;

    private Vector3 rotationPos;

    public static GameObject centerSphere;

    public float rotationSpeed;
    private bool _check;

    private void Start()
    {
        _check = false;
        centerSphere = sphere1;
        SwapSphere();
    }

    private void Update()
    {
        transform.RotateAround(rotationPos, -Vector3.forward, rotationSpeed * Time.deltaTime);
    }
    public void changeRotationSpeed(float speed)
    {
        rotationSpeed = speed;
    }

    public void OnSwap()
    {
        SwapSphere();
    }
    public void OnPause()
    {
        if(_check)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }
    public void Resume()
    {
        _panel.SetActive(false);
        Time.timeScale = 1f;
        _check = false;
    }

    public void Pause()
    {  
        _panel.SetActive(true);
        Time.timeScale = 0f;
        _check = true;
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

            sphere2.GetComponent<SphereCollider>().enabled = false;
            sphere1.GetComponent<SphereCollider>().enabled = true;
        }
        else if (centerSphere = sphere1)
        {

            sphere2.GetComponent<MeshRenderer>().material = centerMat;
            sphere1.GetComponent<MeshRenderer>().material = rotateMat;
            connector.GetComponent<MeshRenderer>().material = rotateMat;

            centerSphere = sphere2;
            rotationPos = sphere2.transform.position;

            sphere1.GetComponent<SphereCollider>().enabled = false;
            sphere2.GetComponent<SphereCollider>().enabled = true;
        }
    }
}