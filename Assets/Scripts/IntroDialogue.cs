using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroDialogue : MonoBehaviour {

    public Text Name;
    public Text Dialogue;
    public GameObject OrganizationMember;
    public GameObject MainCharacter;
    public int Progression;
    public GameObject nextbutton;
    public GameObject StartMission;
    public GameObject DialoguePanel;
    public GameObject NamePanel;

    private void Start()
    {
        DialoguePanel.SetActive(true);
        NamePanel.SetActive(true);
        StartMission.SetActive(false);
        Talking();
    }
    public void Talking () {

    
        Progression++; //each time this function is executed (when the next button is pressed), the interger value will be increased by 1

        if(Progression == 1)
        {
            Name.text = " Organization X ";
            Dialogue.text = "???, I'm glad you came. I had an important matter to discuss with you";

            OrganizationMember.SetActive(true);
            MainCharacter.SetActive(false);
        }

        else if(Progression == 2)
        {
            Name.text = "???";
            Dialogue.text = "Is this about a new mission?";

            OrganizationMember.SetActive(false);
            MainCharacter.SetActive(true);
        }

        else if (Progression == 3)
        {
            Name.text = " Organization X ";
            Dialogue.text = "Indeed. I have heard you have a special circumstance and need the money. Well, we have it. I'm sure your poor grandmother will appreciate it.";

            OrganizationMember.SetActive(true);
            MainCharacter.SetActive(false);
        }

        else if (Progression == 4)
        {
            Name.text = "???";
            Dialogue.text = "So what is it that I need to do?";

            OrganizationMember.SetActive(false);
            MainCharacter.SetActive(true);
        }

        else if (Progression == 5)
        {
            Name.text = " Organization X ";
            Dialogue.text = "I'm glad you asked. Our radars have detected an island, never before seen. What you have to do is go there and test the grounds. There might be new species of plants and animals there and we want you to make note of them all. Do that and the money is yours.";

            OrganizationMember.SetActive(true);
            MainCharacter.SetActive(false);
        }

        else if (Progression == 6)
        {
            Name.text = "???";
            Dialogue.text = "I'll be right on it.";

            OrganizationMember.SetActive(false);
            MainCharacter.SetActive(true);
        }

        else if (Progression == 7)
        {
            Name.text = "";
            Dialogue.text = "";


            OrganizationMember.SetActive(false);
            MainCharacter.SetActive(false);
            nextbutton.SetActive(false);
            DialoguePanel.SetActive(false);
            NamePanel.SetActive(false);
            StartMission.SetActive(true);

        }
    }


}
