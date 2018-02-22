using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Journal
{

    List<string> FoundSpecies = new List<string>();

    public void AddSpecies (string id)
    {
        if (Species.SpeciesList.ContainsKey(id) && !FoundSpecies.Contains(id))
        {
            FoundSpecies.Add(id);
            Player.instance.PlayerUI.AddPage(Species.SpeciesList[id]);
        }
    }


    //GetSpecies. If its in the list, return the species object from Species.GetSpecies. If not, return null.

    public Species GetSpecies(string id)
    {
        if (FoundSpecies.Contains(id))
        {
            return Species.GetSpecies(id);
        }

        else
        {
            return null;
        }
    }
}




