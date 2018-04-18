using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour {

    public List<GameObject> Pages;
    public int CurrentPage = 0;

	public GameObject LeftPage;
    public GameObject RightPage;
	
	private bool IsLeftPage(int Pagenumber)
    {
        return (Pagenumber % 2 == 0);
    }

    public void NextPage()
    {
        if (CurrentPage +2 <= Pages.Count -1) {
            Pages[CurrentPage].SetActive(false);
            Pages[CurrentPage +1].SetActive(false);
            CurrentPage = CurrentPage + 2;
            Pages[CurrentPage].SetActive(true);

            if(CurrentPage + 1 < Pages.Count)
            {
                Pages[CurrentPage + 1].SetActive(true);
            }
        }
    }

    public void PreviousPage()
    {
        if (CurrentPage != 0)
        {
            Pages[CurrentPage].SetActive(false);
            if (CurrentPage + 1 < Pages.Count)
            {
                Pages[CurrentPage + 1].SetActive(false);
            }
            CurrentPage = CurrentPage - 2;
            Pages[CurrentPage].SetActive(true);
            Pages[CurrentPage + 1].SetActive(true);

        }
    }

    public void AddPage(Species AddedSpecies)
    {
        //Decide what this new page needs to be.
        if (IsLeftPage(Pages.Count))
        {
            //left page
            GameObject NewPage = Instantiate(LeftPage, LeftPage.transform.parent);
            UIpage UiRef = NewPage.GetComponent<UIpage>();
            UiRef.NameText.text = AddedSpecies.Name;
            UiRef.SpeciesTypeText.text = AddedSpecies.SpeciesType;
            UiRef.DescriptionText.text = AddedSpecies.Description;
            Pages.Add(NewPage);
        }
        else
        {
            //Right Page
            GameObject NewPage = Instantiate(RightPage, RightPage.transform.parent);
            if (Pages.Count == 1)
            {
                NewPage.SetActive(true);
            }
            UIpage UiRef = NewPage.GetComponent<UIpage>();
            UiRef.NameText.text = AddedSpecies.Name;
            UiRef.SpeciesTypeText.text = AddedSpecies.SpeciesType;
            UiRef.DescriptionText.text = AddedSpecies.Description;
            Pages.Add(NewPage);
        }
    }
}
