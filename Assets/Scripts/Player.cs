using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class Player : MonoBehaviour {

    public UI PlayerUI;
    public static Player instance;
    public Journal Journal = new Journal();
    public Camera PlayerCamera;
    public GameObject JournalUI;
    public ThirdPersonCharacter controller;

    private void Awake()
    {
        if (instance == null) instance = this;

        controller = GetComponent<ThirdPersonCharacter>();
        
    }
    private void Update()
    {
        Inputs();
    }

    void Inputs()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {

            RaycastHit RaycastHit;
            if (Physics.Raycast(PlayerCamera.transform.position, PlayerCamera.transform.forward, out RaycastHit, 7))
            {
                SpeciesBase animalHit = RaycastHit.transform.GetComponent<SpeciesBase>();
                if (animalHit != null)
                {
                    Journal.AddSpecies(animalHit.ID);
                }
            }

        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            JournalUI.SetActive(!JournalUI.activeSelf);
            if (JournalUI.activeSelf)
            {
                controller.enabled = false;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                controller.enabled = true;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
        
        }
    }

}
