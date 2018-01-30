using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Species
{

    public string Name;
    public string ID;
    public string Description;
    public string SpeciesType;

    public Species(string name, string SPtype, string id, string description)
    {
        ID = id.ToLower();
        Name = name;
        SpeciesType = SPtype;
        Description = description;
        SpeciesList.Add(id, this);
    }


    public static Dictionary<string, Species> SpeciesList = new Dictionary<string, Species>();
    private static Species Plant = new Species("Purple Draconia", "Plant", "plant.draconia", "This is a flower with purple petals that is poisonous to the touch.");
    private static Species Animal = new Species("Sand Hedgehog", "Animal", "animal.hedgehog", "This is a hedgehog that makes its nests in the sand. It's solitary and feeds on red sand snakes.");



    public static Species GetSpecies(string SpeciesID)
    {
        return SpeciesList[SpeciesID.ToLower()];
    }

    public virtual void OnAddToJournal()
    {
        //classes that inherit this one can override it
    }
}