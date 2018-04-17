using System.Collections;
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
        //{
        //    "plant.draconia", new Species("Purple Draconia", "Plant", "This is a flower with purple petals that is poisonous to the touch.")
        //},
        //{
        //   "animal.hedgehog", new Species("Sand Hedgehog", "Animal",  "This is a hedgehog that makes its nests in the sand. It's solitary and feeds on red sand snakes.")
        //},
        {
            "tree.greentree", new Species("Greenland Tree", "Tree", "This tree grows near beackes or in flat, grassy areas. The leaves have peculiar texture which may leave rashes on your hands if rubbed too forcefully.")
        },
        {
            "tree.redtree", new Species("Fire Grandifolia", "Tree", "A very tall tree with tough, thick bark and red leaves. Fires have often been spotted in this area and it is thought that the red leaves have a strange propriety that can cause them to fire up in direct contact with sun rays. Their ideal habitat is away from the sun.")
        }
        ,
        {
            "tree.firfoliage", new Species("Fir Hybrida","Tree", " A hybrid between a fir tree and an Oak. A mystery of nature")
        }
        ,
        {
            "tree.browntree", new Species("Fern Pine","Tree","An incredibly tall Pine with short branches and leaves that strongly resemble ferns.")
        }
        ,
        {
            "tree.clovertree", new Species("Clover Magnum", "Tree", "A medium sized tree with long, contorted branches and leaves that resenble clover leaves. They are very sensitive and fall off in just a few days. New ones quickly replace them.")
        }
        ,
        {
            "tree.frozentree", new Species("Frost Birch", "Tree", "A small sized tree with frozen leaves. They don't seem to be dead. This tree only grows on high mountains.")
        }
        ,
        {
            "tree.thintree", new Species("", "", "")
        }


    };
    



    public static Species GetSpecies(string SpeciesID)
    {
        return SpeciesList[SpeciesID.ToLower()];
    }


}