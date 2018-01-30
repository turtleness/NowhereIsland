using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{

    public Transform target;
    public float MinDistance;
    public float MaxDistance;
    public float Height;

    private Transform myTransform;

    // Use this for initialization
    void Start()
    {
        if (target == null)
            Debug.LogWarning("No target!");

        myTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LateUpdate()
    {
        //Always called after update
        // character moving in update, if camera moves at the same time as character, it might try to move before even knowing what the character will do
        //in late update, camera will adjust its pos. after the character

        myTransform.position = new Vector3(target.position.x, target.position.y + Height, target.position.z - MinDistance);
       // myTransform.LookAt(target.position);

    }

}