using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float mouseSensitivity = 100f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(Vector3.forward);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(Vector3.back);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(Vector3.left);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(Vector3.right);
        }

        //MOUSE LOOK

        float mouseX = Input.GetAxis("Mouse X");

        float mouseY = Input.GetAxis("Mouse Y");

        transform.rotation = Quaternion.Euler(0, mouseX, 0) * transform.rotation;

        Camera cam = GetComponentInChildren<Camera>();

        cam.transform.localRotation = Quaternion.Euler(-mouseY, 0, 0) * cam.transform.localRotation;
    }


}
/*float rotateHorizontal = Input.GetAxis("Mouse X");

float rotateVertical = Input.GetAxis("Mouse Y");

transform.Rotate(transform.up * rotateHorizontal * sensitivity);

transform.Rotate(-transform.right * rotateVertical * sensitivity);*/
