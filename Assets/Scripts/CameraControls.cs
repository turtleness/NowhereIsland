using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraControls : MonoBehaviour
{

    public float MoveRatio = 1;
    public float CameraDistance = 4f;
    public Transform CameraTarget;

    private Vector3 PastTargetPos;

    public void Start()
    {
        PastTargetPos = CameraTarget.position;
    }

    void LateUpdate()
    {
        Vector3 CameraMovement = CameraTarget.position - PastTargetPos;
        transform.position += CameraMovement;
        if (Input.GetMouseButton(1))
        {
            //While right mouse is being held down
            Vector3 MouseMovement = new Vector3(-Input.GetAxis("Mouse X"), -Input.GetAxis("Mouse Y")) * MoveRatio;
            transform.Translate(MouseMovement); 
        }
        transform.LookAt(CameraTarget);
        float Distance = Vector3.Distance(transform.position, CameraTarget.position);
        float difference = Distance - CameraDistance;
        transform.Translate(new Vector3(0, 0, difference));
    }

}
