using System;
using System.Collections;
using System.Collections.Generic;
using ScriptableObjects;
using UnityEngine;

public class Loot : MonoBehaviour
{
    [SerializeField] private Enumexample _enumexample;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            _enumexample._raity = Raity.Common;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            _enumexample._raity = Raity.Rare;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            print("epic");
            _enumexample._raity =  Raity.Epic;
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            _enumexample._raity = Raity.Legendary;
        }
        
        
        
        if ((_enumexample._raity & Raity.Common) != 0)
        {
            print("its common");
        }
        if ((_enumexample._raity & Raity.Rare) != 0)
        {
            print("its rare");
        }
        if ((_enumexample._raity & Raity.Epic) != 0)
        {
            print("its epic");
        }

        if ((_enumexample._raity & Raity.Legendary) != 0)
        {
            print("its legendary");
        }
        
    }
}
