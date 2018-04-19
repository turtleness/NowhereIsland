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
            "tree.thintree", new Species("Thin Sycamore", "Tree", "A tree with many branches and a very small trunk. It is almost a wonder how it can stant upright.")
        }
        ,
        {
            "plant.tinytree", new Species("Delirium", "Plant", "This miniature tree can be found all around the island. Its leaves maintain the colour orange all throughout the season. Once a year, it will bear a single fruit which can have similar effects to Marijuana if consummed.")
        }
        ,
        {
            "plant.redbranches", new Species("Crimson Yew", "Plant", "This plant prefers warm weather. The colour of its leaves never fades, regardless of the season. They tend to grow around Fire Grandifolia and will rarely be seen in other habitats.")
        }
        ,
        {
            "plant.drygrass", new Species("Straw Dulce", "Plant", "This type of tall grass only grows around humid, still waters. It has a sweet taste that resembles sugar.")
        }        
        ,
        {
            "plant.drybranches", new Species("The living dead", "Plant", "Although these charcoal branches look dead, if they are broken apart, a liquid green ooze will come out of them. It can be found all around the island, especially in dry or cliff areas. Its effects need to be further studied.")
        }        
        ,
        {
            "plant.pinkflowers", new Species("Rosemary thistle", "Plant", "This type of thistle can be used as a condiment as it has many properties in common with rosemary.")
        }        
        ,
        {
            "plant.greenleaves", new Species("Green Symphytum", "Plant", "This type of Symphytum grows no flowers. It can be used as a quick remedy for the flu.")
        }        
        ,
        {
            "plant.whitesmall", new Species("Somnium","Plant", "This plant can be used to make sleep-inducing tea.")
        }
         ,
        {
            "plant.darkgrass", new Species("Purple Draconia", "Plant", "This is a plant with dark purple leaves that is poisonous to the touch. It will leave purple rashes over the skin.")
        } 
        ,
        {
            "plant.greenfern", new Species("Abyss Fern", "Plant", "The roots of this type of fern can reach several feet underground. It is impossible to pull them out so the leaves always need to be cut to prevent mass spreading. Luckily, they have been the source of food for many animals and are now less common.")
        } 
        ,
        {
            "plant.thinflowers", new Species("Boar's eye", "Plant", "This flower seems to have a strong effect on wild Boars. It will make them agressive.")
        }
    };
    



    public static Species GetSpecies(string SpeciesID)
    {
        return SpeciesList[SpeciesID.ToLower()];
    }

}