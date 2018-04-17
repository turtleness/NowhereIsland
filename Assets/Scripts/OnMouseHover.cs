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
    Animator animator;
    bool playedAnim = false;

    public void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit, 7, LayerMask.GetMask("Foliage", "Tree"), QueryTriggerInteraction.Collide))
        {
            SpeciesBase animalHit = RaycastHit.transform.GetComponent<SpeciesBase>();

            if (animalHit != null)
            {
                HoverSpeciesName.gameObject.SetActive(true);
                Species hitSpecies = Player.instance.Journal.GetSpecies(animalHit.ID);
                if (hitSpecies != null)
                {
                    HoverSpeciesName.text = hitSpecies.Name;
                    playedAnim = false;
                }
                else {
                    HoverSpeciesName.text = "???";
                    if (!playedAnim)
                    {
                        animator.SetTrigger("NewSpecies");
                        playedAnim = true; 
                    }
                }
            }
            else
            {
                HoverSpeciesName.gameObject.SetActive(false);
                playedAnim = false;
            }

        }
        else
        {
            HoverSpeciesName.gameObject.SetActive(false);
            playedAnim = false;
        }
    }
}
