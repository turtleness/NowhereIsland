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

    private Vector3 LastCameraPosition;
    private Quaternion LastCameraRotation;

    public void Start()
    {
        PastTargetPos = CameraTarget.position;
        UpdateTargetMovePos();
    }

    void LateUpdate()
    {
        UpdateTargetMovePos();

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
            Vector3 MouseMovement = new Vector3(-Input.GetAxis("Mouse X"), -Input.GetAxis("Mouse Y")) * MoveRatio;
            DoCameraRotation(MouseMovement);
        }
    }

    void UpdateTargetMovePos()
    {
        //Update camera position to follow camera.
        Vector3 CameraMovement = CameraTarget.position - PastTargetPos;
        transform.position += CameraMovement;
        PastTargetPos = CameraTarget.position;
    }

    void DoCameraRotation(Vector3 MouseMovement)
    {
        //Store the current camera rotation and position incase we need to revert to this.
        LastCameraPosition = transform.position;
        LastCameraRotation = transform.rotation;

        //While right mouse is being held down
        
        transform.Translate(MouseMovement);

        transform.LookAt(CameraTarget);
        float Distance = Vector3.Distance(transform.position, CameraTarget.position);
        float difference = Distance - CameraDistance;
        transform.Translate(new Vector3(0, 0, difference));

        //Undo the operation and repeat with no Y Movement.
        if (transform.localEulerAngles.x > MaxXRotation || transform.localEulerAngles.x < MinXRotation)
        {
            transform.position = LastCameraPosition;
            transform.rotation = LastCameraRotation;
            //This is bad but works soo \__(`.`)_/
            DoCameraRotation(new Vector3(-Input.GetAxis("Mouse X"), 0));
        }
    }
}
