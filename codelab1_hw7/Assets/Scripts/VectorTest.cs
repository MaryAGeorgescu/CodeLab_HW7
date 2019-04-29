using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//this is just a test

public class VectorTest : MonoBehaviour
{
    public Vector3 FirstPoint;
    public Vector3 SecondPoint;
    public Vector3 force;
    public float transition;

    public Transform Player1;
    public  Transform Player2;
    public Transform cameraTransform;


    // Update is called once per frame
    void Update()
    {
        FirstPoint = Player1.position;
        SecondPoint = Player2.position;

        force = SecondPoint - FirstPoint;
        Vector3.Cross(force, Vector3.up);
        //force.Normalize();

        cameraTransform = Vector3.Lerp (FirstPoint,SecondPoint,transition)+ force;

        Debug.Log("Magnitude : " + force.magnitude);
        Debug.DrawLine(FirstPoint, SecondPoint, Color.magenta);
        Debug.DrawLine(Vector3.zero, force, Color.cyan);
    }
}
