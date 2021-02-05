using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Static can also be applied to classes
public class Enemy
{
    //Static variables are shared across all instances
    //of a class.
    // Belongs to this class
    public static int enemyCount = 0;

    public Enemy()
    {
        //Increment the static variable to know how many
        //objects of this class have been created.
        enemyCount++;
    }
}