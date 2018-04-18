using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionsPanel : MonoBehaviour {

    public UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl control;
    public Rigidbody rigidbody;
    public CameraControls MainCam;
    public GameObject InstPanel;

	// Use this for initialization
	void Start () {
        MainCam.enabled = false;
        rigidbody.isKinematic = true;
        control.enabled = false;
        InstPanel.SetActive(true);
       
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.C))
        {
            MainCam.enabled = true;
            rigidbody.isKinematic = false;
            control.enabled = true;
            Destroy(InstPanel);
        }
	}
}
