﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Species
{

    public string Name;
    public string Description;
    public string SpeciesType;

    public Species(string name, string SPtype, string description)
    {
        Name = name;
        SpeciesType = SPtype;
        Description = description;
    }


    public static Dictionary<string, Species> SpeciesList = new Dictionary<string, Species>
    {
        {
            "plant.draconia", new Species("Purple Draconia", "Plant", "This is a flower with purple petals that is poisonous to the touch.")
        },
        {
           "animal.hedgehog", new Species("Sand Hedgehog", "Animal",  "This is a hedgehog that makes its nests in the sand. It's solitary and feeds on red sand snakes.")
        }
    };
    



    public static Species GetSpecies(string SpeciesID)
    {
        return SpeciesList[SpeciesID.ToLower()];
    }


}