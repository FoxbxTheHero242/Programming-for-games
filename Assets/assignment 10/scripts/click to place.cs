using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class clicktoplace : MonoBehaviour
{
     public Vector2 mouspos;
    
     [SerializeField] private float mouseAdjustment=1f;
    [SerializeField] private GameObject cube;

    private GameObject hold;
    private bool isbound;

    private bool allowedToDrop;

    private WaitForSeconds waitTime;
    // Start is called before the first frame update
    void Start()
    {
        bullshitManage.init(this);
        waitTime = new WaitForSeconds(1);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (isbound)
        {
            print("its true");
            hold.transform.position = new Vector3(mouspos.x, 1, mouspos.y);
        }
    }
    
    public void MoveObb()
    {
        allowedToDrop = false;
       hold = Instantiate(cube, new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
       isbound=true;

    }

    public void Dropit()
    {
        print("dropped");
        isbound = false;
        hold.transform.position = new Vector3(hold.transform.position.x, 0, hold.transform.position.z);
    }

    public void movemouse(Vector2 pos)
    {
        print("moving mouse");
        mouspos = new Vector2(pos.x, pos.y);
        mouspos -= new Vector2(Screen.width, Screen.height) / 2;
        mouspos = mouspos / mouseAdjustment;
    }

    private IEnumerator waitToPlace()
    {
       yield return waitTime;
       allowedToDrop = true;
    }
}
