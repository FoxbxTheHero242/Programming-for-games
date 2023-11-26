using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects
{
    [Flags]
    public enum Raity
    {
        Common=1,
        Rare=2,
        Epic=4,
        Legendary=8
    }


    public class Enumexample : ScriptableObject
    {
        
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
