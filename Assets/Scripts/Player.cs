﻿using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;
using System.Collections;

public class Player : MonoBehaviour {

    public UI PlayerUI;
    public static Player instance;
    public Journal Journal;
    public Camera PlayerCamera;
    public GameObject JournalUI;
    public ProgressBarScript Progress;

    public ThirdPersonCharacter controller;
    public Animator animator;
    private Rigidbody rigidbody;

    public void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
    }

    public void Awake()
    {
        if (instance == null) instance = this;

        Journal = new Journal(this);
        controller = GetComponent<ThirdPersonCharacter>();
        Progress.Initialize(Species.SpeciesList.Count);
    }

    private void Update()
    {
        Inputs();
    }

    void Inputs()
    {
        if (Input.GetKeyDown(KeyCode.E) || Input.GetMouseButtonDown(0))
        {
            //RaycastHit testHit;
            //if (Physics.Raycast(PlayerCamera.transform.position, PlayerCamera.transform.forward, out testHit, Mathf.Infinity))
            //{
            //    Debug.Log(Vector3.Distance(transform.position, testHit.transform.position));
            //}

            RaycastHit hit;
            Ray ray = PlayerCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 7, LayerMask.GetMask("Foliage", "Tree"), QueryTriggerInteraction.Collide))
            {
                SpeciesBase animalHit = hit.transform.GetComponent<SpeciesBase>();
                if (animalHit != null)
                {
                    Journal.AddSpecies(animalHit.ID);
                }
            }

            //RaycastHit RaycastHit;
            //if (Physics.Raycast(PlayerCamera.transform.position, PlayerCamera.transform.forward, out RaycastHit, 7))
            //{
            //    SpeciesBase animalHit = RaycastHit.transform.GetComponent<SpeciesBase>();
            //    if (animalHit != null)
            //    {
            //        Journal.AddSpecies(animalHit.ID);
            //    }
            //}

        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            JournalUI.SetActive(!JournalUI.activeSelf);
            if (JournalUI.activeSelf)
            {
                controller.enabled = false;
                rigidbody.isKinematic = true;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                controller.enabled = true;
                rigidbody.isKinematic = false;
                //Cursor.visible = false;
                //Cursor.lockState = CursorLockMode.Locked;
            }
        
        }
    }

}
