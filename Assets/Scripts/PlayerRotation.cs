using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxis("Mouse X");
        float yAxis = Input.GetAxis("Mouse Y");
        transform.rotation = Quaternion.Euler(0,xAxis,0)*transform.rotation;
       // Camera cam = GetComponentInChildren<Camera>();
        //cam.transform.localRotation = Quaternion.Euler(-yAxis, 0, 0) * cam.transform.localRotation;

        //Raycast
        RaycastHit hit;
        if(Physics.Raycast(transform.position,Vector3.forward,out hit,100.0f))
        {
            Debug.DrawRay(transform.position,Vector3.forward,Color.red);
            Debug.Log("Successful");
        }
        else
        {
            Debug.DrawRay(transform.position,Vector3.forward,Color.yellow);
            Debug.Log("UNSuccessful");
        }
    }
    
}
