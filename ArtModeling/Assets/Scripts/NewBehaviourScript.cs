using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundFollow : MonoBehaviour
{

    public Transform mainCamera;
    void Start()
    {
        mainCamera = Camera.main.transform.parent.transform;
    }
    void Update()
    {
        transform.position = new Vector3(mainCamera.transform.position.x, mainCamera.transform.position.y, 2);
    }
}
