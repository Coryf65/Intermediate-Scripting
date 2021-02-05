using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Basics of a Property

    //Member variables can be referred to as
    //fields.
    private int experience;

    //Experience is a basic property
    public int Experience
    {
        // Accessor
        get
        {
            // Some other code
            return experience;
        }
        set
        {
            // Some other Code
            experience = value;
        }
    }

    //Level is a property that converts experience
    //points into the leve of a player automatically
    public int Level
    {
        get
        {
            // return numerical level not total EXP
            return experience / 1000;
        }
        set
        {
            experience = value * 1000;
        }
    }

    // Shorthand Property, that can act like a field
    //This is an example of an auto-implemented
    //property
    public int Health { get; set; }


}
