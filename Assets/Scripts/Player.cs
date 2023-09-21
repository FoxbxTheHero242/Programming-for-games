using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private float ShotSpeed;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletParent;
    [SerializeField] private Transform gun;
    [SerializeField] private Transform shotPoint;
    
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
        GameObject go = Instantiate(bullet, shotPoint.position, gun.rotation, bulletParent);
        go.GetComponent<Rigidbody>().AddForce(go.transform.forward*ShotSpeed);
    }

    public void clear()
    {
        for (int i = 0; i < bulletParent.childCount; i++)
        {
            Destroy(bulletParent.GetChild(i).gameObject);
        }
    }

    //Making moving gun to shoot balls
    public void GunMove(Vector2 mouse)
    {
        gun.rotation= new Quaternion(gun.rotation.x+mouse.x*0,-1*(mouse.x-Screen.width/2)/(Screen.width/2),
            gun.rotation.z,gun.rotation.w);
    }
    //NOT MINE:
    // pdate is called once per frame
    void Update()
    {
        //Debug.Log(_moveDir);
        //modified to move forward
        
        _self.MovePosition(_self.position+  _self.rotation*(Vector3)(_moveDir* (speed * Time.deltaTime)));
        
        
    }
}
