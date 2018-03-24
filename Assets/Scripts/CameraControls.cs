using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraControls : MonoBehaviour
{

    public float MoveRatio = 1;
    public float CameraDistance = 4f;
    public Transform CameraTarget;
    public Player player;
    public float MinXRotation;
    public float MaxXRotation;

    private Vector3 PastTargetPos;
    private float LastYPos;

    public void Start()
    {
        PastTargetPos = CameraTarget.position;
        LastYPos = transform.position.y;
    }

    void LateUpdate()
    {
        Vector3 CameraMovement = CameraTarget.position - PastTargetPos;
        transform.position += CameraMovement;
        PastTargetPos = CameraTarget.position;

        if (Input.GetMouseButtonDown(1) && !PauseMenu.isGamePaused && !player.JournalUI.activeSelf)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        if (Input.GetMouseButtonUp(1))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

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

        //Clamp the cameras rotation
        if(transform.localEulerAngles.x > MaxXRotation || transform.localEulerAngles.x < MinXRotation)
        {
            Vector3 newPos = transform.position;
            newPos.y = LastYPos;
            transform.position = newPos;
            transform.LookAt(CameraTarget);
        }
        else{
            LastYPos = transform.position.y;
        }
        
    }

}
