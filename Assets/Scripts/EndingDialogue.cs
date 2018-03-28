using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EndingDialogue : MonoBehaviour {

    public Text Name;
    public Text Dialogue;
    public GameObject OrganizationMember;
    public GameObject MainCharacter;
    public int Progression;
    public GameObject nextbutton;
    public GameObject DialoguePanel;
    public GameObject NamePanel;
    public TextMeshProUGUI EndingText;

    private void Start()
    {
        EndingText.gameObject.SetActive(false);

        DialoguePanel.SetActive(true);
        NamePanel.SetActive(true);
       
        Talking();
    }
    public void Talking () {

    
        Progression++; 

        if(Progression == 1)
        {
            Name.text = " Organization X ";
            Dialogue.text = "Congratulations on completing the mission. I must admit, everyone was surprised that you came back safely... Not that I wish to imply that anything bad should have happened.";

            OrganizationMember.SetActive(true);
            MainCharacter.SetActive(false);
        }

        else if(Progression == 2)
        {
            Name.text = "???";
            Dialogue.text = "Thank you... I suppose. Now, about my reward...";

            OrganizationMember.SetActive(false);
            MainCharacter.SetActive(true);
        }

        else if (Progression == 3)
        {
            Name.text = " Organization X ";
            Dialogue.text = "Right, we will make sure your cash is deposited into your account soon.";

            OrganizationMember.SetActive(true);
            MainCharacter.SetActive(false);
        }

        else if (Progression == 4)
        {
            Name.text = "???";
            Dialogue.text = "Thank you.";

            OrganizationMember.SetActive(false);
            MainCharacter.SetActive(true);
        }


        else if (Progression == 5)
        {
            Name.text = "";
            Dialogue.text = "";


            OrganizationMember.SetActive(false);
            MainCharacter.SetActive(false);
            nextbutton.SetActive(false);
            DialoguePanel.SetActive(false);
            NamePanel.SetActive(false);
            EndingText.gameObject.SetActive(true);

        }
    }


}
