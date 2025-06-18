using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    [Header("Mouse info")]
    public Vector3 clickStartLocation;
    // Start is called before the first frame update
    [Header("Physics")]
    public Vector3 launchVector;
    public float launchForce;
    [Header("Mandrake")]
    public Transform mandrakeTransform;
    public Rigidbody mandrakeRigidbody;
    public Vector3 originalMandrakePosition;
    public Quaternion originalRotation;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            print("Click");
            clickStartLocation = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            print("Hold!");
            Vector3 mouseDifference = clickStartLocation - Input.mousePosition;
            launchVector = new Vector3(
                mouseDifference.x * 1f,
                mouseDifference.y * 1.2f,
                mouseDifference.y * 1.5f
                );
            mandrakeTransform.position = originalMandrakePosition - launchVector / 400;
            launchVector.Normalize();
            print(mouseDifference.x);
            print(mouseDifference.y);
            print(mouseDifference.z);
        }
        if (Input.GetMouseButtonUp(0))
        {
            print("Release");
            print(launchVector);
            mandrakeRigidbody.isKinematic = false;
            mandrakeRigidbody.AddForce(launchVector.x,launchVector.y, launchVector.y*launchForce, ForceMode.Impulse);

        }
        if (Input.GetMouseButton(1))
        {
            mandrakeRigidbody.isKinematic = true;
            mandrakeTransform.position = originalMandrakePosition;
            mandrakeTransform.rotation = originalRotation;
        }

    }

}
