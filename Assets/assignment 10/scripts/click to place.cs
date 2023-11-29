using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class clicktoplace : MonoBehaviour
{
    public Vector2 mouspos;
    
    [SerializeField] private GameObject cube;

    private GameObject hold;
    private bool isbound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isbound)
        {
            hold.transform.position = new Vector3(mouspos.x, transform.position.y - 5, mouspos.y);
        }
    }
    
    public void MoveObb()
    {
       hold = Instantiate(cube, new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
       isbound=true;

    }

    public void Dropit()
    {
        isbound = false;
        hold.transform.position = new Vector3(hold.transform.position.x, 0, hold.transform.position.z);
    }
}
