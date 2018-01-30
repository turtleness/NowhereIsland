using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour {

    public List<GameObject> SpeciesObjects;
    public int CurrentPage = 0;

	public GameObject LeftPage;
    public GameObject RightPage;
	
	private bool IsLeftPage(int Pagenumber)
    {

        if (Pagenumber % 2 == 0 && Pagenumber == 0)
        {
            return true;
        }

        else{
            return false;
        }
    }

    public void NextPage()
    {
        if (CurrentPage +2 <= SpeciesObjects.Count -1) {
            SpeciesObjects[CurrentPage].SetActive(false);
            SpeciesObjects[CurrentPage +1].SetActive(false);
            CurrentPage = CurrentPage + 2;
            SpeciesObjects[CurrentPage].SetActive(true);

            if(CurrentPage + 1 > SpeciesObjects.Count)
            {
                SpeciesObjects[CurrentPage + 1].SetActive(true);
            }
        }
    }

    public void PreviousPage()
    {
        if (CurrentPage != 0)
        {
            SpeciesObjects[CurrentPage].SetActive(false);
            if (CurrentPage + 1 > SpeciesObjects.Count)
            {
                SpeciesObjects[CurrentPage + 1].SetActive(false);
            }
            CurrentPage = CurrentPage - 2;
            SpeciesObjects[CurrentPage].SetActive(true);
            SpeciesObjects[CurrentPage + 1].SetActive(true);

        }
    }

    public void AddPage(Species AddedSpecies)
    {
        if (IsLeftPage(SpeciesObjects.Count -1))
        {
            //Right Page
            GameObject NewPage = Instantiate(RightPage, RightPage.transform.parent);
            if (CurrentPage == 0) {
                NewPage.SetActive(true);
            }
            UIpage UiRef = NewPage.GetComponent<UIpage>();
            UiRef.NameText.text = AddedSpecies.Name;
            UiRef.SpeciesTypeText.text = AddedSpecies.SpeciesType;
            UiRef.DescriptionText.text = AddedSpecies.Description;
            SpeciesObjects.Add(NewPage);
        }
        else
        {
            //left page
            GameObject NewPage = Instantiate(LeftPage, LeftPage.transform.parent);
            UIpage UiRef = NewPage.GetComponent<UIpage>();
            UiRef.NameText.text = AddedSpecies.Name;
            UiRef.SpeciesTypeText.text = AddedSpecies.SpeciesType;
            UiRef.DescriptionText.text = AddedSpecies.Description;
            SpeciesObjects.Add(NewPage);
        }
    }
}
