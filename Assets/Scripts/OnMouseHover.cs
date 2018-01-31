using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnMouseHover : MonoBehaviour
{

    public Text HoverSpeciesName;
    public float ReachRay;
    public Camera MainCamera;
    bool _wasDiscovered;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

            RaycastHit RaycastHit;
            if (Physics.Raycast(MainCamera.transform.position, MainCamera.transform.forward, out RaycastHit, 7))
            {
                SpeciesBase animalHit = RaycastHit.transform.GetComponent<SpeciesBase>();
                if (animalHit != null)
                {
                HoverSpeciesName.gameObject.SetActive(true);
                }
            }
        }
    
}