using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OnMouseHover : MonoBehaviour
{

    public TextMeshProUGUI HoverSpeciesName;
    public float ReachRay;
    public Camera MainCamera;
    bool _wasDiscovered;

    Ray ray;
    RaycastHit RaycastHit;



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
                Species hitSpecies = Player.instance.Journal.GetSpecies(animalHit.ID);
                if (hitSpecies != null)
                {
                    HoverSpeciesName.text = hitSpecies.Name;
                }
                else {
                    HoverSpeciesName.text = "???";

                }
            }
            else
            {
                HoverSpeciesName.gameObject.SetActive(false);
            }

        }
        else
        {
            HoverSpeciesName.gameObject.SetActive(false);
        }
    }
}
