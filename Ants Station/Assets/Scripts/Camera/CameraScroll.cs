using System;
using UnityEngine;

public class CameraScroll : MonoBehaviour
{
    private Camera camera;
    
    private void Start()
    {
        camera = GetComponent<Camera>();
    }

    private void Update()
    {
        ScrollCamera();
    }

    private void ScrollCamera()
    {
        float value = Input.GetAxisRaw("Mouse ScrollWheel");
        
        camera.orthographicSize *= 1 + value*-1;
    }
}
