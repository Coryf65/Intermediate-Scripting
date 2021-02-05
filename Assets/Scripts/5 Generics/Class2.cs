using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class2 : MonoBehaviour
{
    void Start()
    {
        Class1 myClass = new Class1();

        //In order to use this method you must
        //tell the method what type to replace
        //'T' with.
        myClass.GenericMethod<int>(5);
    }
}
