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



}




