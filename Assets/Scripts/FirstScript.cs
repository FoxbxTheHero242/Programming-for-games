using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEditor.UI;
using UnityEngine;

public class FirstScrip : MonoBehaviour
{
    public float speed;
    public float shootForce;
    public GameObject prefab;
    // Start is called before the first frame update
    //wrote some lines to test the 3 different log functions as well as the onEnable method
    /* This is to test the comment features
     */
    void Start()
    {
        Debug.Log("Hello World");
        Debug.LogWarning("YOUR CODE SCARES ME");
        Debug.LogError("YOUR CODE FUCKING SUCKS!!!!");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal")*speed*Time.deltaTime,0,Input.GetAxis("Vertical")*speed*Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject go = Instantiate(prefab);
            go.GetComponent<Rigidbody>().velocity=Vector3.up*shootForce;
        }
        
    }

    private void OnEnable()
    {
        Debug.Log("enabled");
    }
}

