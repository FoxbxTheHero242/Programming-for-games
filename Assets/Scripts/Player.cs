using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private float ShotSpeed;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletParent;
    private Rigidbody _self;

    private Vector3 _moveDir;
    // Start is called before the first frame update
    void Start()
    {
        InputManager.Init(this);
        InputManager.GameMode();
        _self = this.GetComponent<Rigidbody>();
    }

    public void setMoveDir(Vector3 moveDir)
    {
        _moveDir= moveDir;
    }

    //MINE:
    public void shoot()
    {
        //trying to spawn a sphere at the player as a bullet without it moving with the player
        GameObject go = Instantiate(bullet, transform.position+Vector3.up, transform.rotation, bulletParent);
        go.GetComponent<Rigidbody>().AddForce(Vector3.up*ShotSpeed);
    }

    public void clear()
    {
        for (int i = 0; i < bulletParent.childCount; i++)
        {
            Destroy(bulletParent.GetChild(i).gameObject);
        }
    }
    //NOT MINE:
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(_moveDir);
        _self.MovePosition(transform.position+ (Vector3) (_moveDir * (speed * Time.deltaTime)));
    }
}
