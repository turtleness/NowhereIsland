using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Journal
{
    List<string> FoundSpecies = new List<string>();

    private Player player;

    public Journal(Player player)
    {
        this.player = player;
    }

    public void AddSpecies (string id)
    {
        if (Species.SpeciesList.ContainsKey(id) && !FoundSpecies.Contains(id))
        {
            //Adding a new species
            FoundSpecies.Add(id);
            player.PlayerUI.AddPage(Species.SpeciesList[id]);
            player.Progress.ProgressUpdate(FoundSpecies.Count);

            if (FoundSpecies.Count == Species.SpeciesList.Count)
            {
                //Win!
                player.gameObject.AddComponent<EndLoadWait>();
            }
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




