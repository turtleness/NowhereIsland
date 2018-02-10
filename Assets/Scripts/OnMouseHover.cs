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

    Ray ray;
    RaycastHit RaycastHit;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit, 7))
        {
            SpeciesBase animalHit = RaycastHit.transform.GetComponent<SpeciesBase>();

            if (animalHit != null)
            {
                HoverSpeciesName.gameObject.SetActive(true);
                //Player.instance.Journal.
            }
            else
            {
                HoverSpeciesName.gameObject.SetActive(false);
            }

        }
    }
}
