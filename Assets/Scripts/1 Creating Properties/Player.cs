using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Basics of a Property

    private int experience;

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
    public int Health { get; set; }


}
