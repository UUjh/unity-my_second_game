using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    float rx = 0f;
    float ry = 0f;

    public float rotSpeed = 500f;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float mx = Input.GetAxis("Mouse X");
        //float my = Input.GetAxis("Mouse Y");

        //rx += rotSpeed * my * Time.deltaTime;
        ry += rotSpeed * mx * Time.deltaTime;

        rx = Mathf.Clamp(rx, -80, 80);

        transform.eulerAngles = new Vector3(-rx, ry, 0);
        
    }
}
