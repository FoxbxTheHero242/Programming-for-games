using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class Player : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private float ShotSpeed;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletParent;
    [SerializeField] private Transform gun;
    [SerializeField] private Transform shotPoint;
    [SerializeField] private float jumpFoce;
    [Header("Ui")] 
    [SerializeField] private TextMeshProUGUI _ammoCount;

    [SerializeField] private TextMeshProUGUI _totalAmmoCount;

    private int _ammo;
    private int _totalAmmo;
    
    private Rigidbody _self;

    private Vector3 _moveDir;
    // Start is called before the first frame update
    void Start()
    {
        InputManager.Init(this);
        InputManager.GameMode();
        _self = this.GetComponent<Rigidbody>();
        _ammo = 12;
        _totalAmmo = 120;
        _ammoCount.text = _ammo.ToString();
        _totalAmmoCount.text = "/" + _totalAmmo.ToString();

    }

    public void setMoveDir(Vector3 moveDir)
    {
        _moveDir= moveDir;
    }

    //MINE:
    public void shoot()
    {
        if (_ammo>0)
        {
            //trying to spawn a sphere at the player as a bullet without it moving with the player
            for (int i = 0; i < 8; i++)
            {
                GameObject go = Instantiate(bullet, shotPoint.position+new Vector3(Random.Range(0,0.5f),Random.Range(0,0.5f),Random.Range(0,0.5f)), gun.rotation, bulletParent);
                                    go.GetComponent<Rigidbody>().AddForce(go.transform.forward*ShotSpeed);
            }
                    
                    _ammo--;
                    _ammoCount.text = _ammo.ToString();
        }
        
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
        print("she movin");
        gun.rotation= new Quaternion(gun.rotation.x+mouse.x*0,(mouse.x-Screen.width/2)/(Screen.width/2),
            gun.rotation.z,gun.rotation.w);
    }

    public void jump()
    {
        _self.AddForce(Vector3.up*jumpFoce);
    }
    //NOT MINE:
    // pdate is called once per frame
    void Update()
    {
        //Debug.Log(_moveDir);
        //modified to move forward
        
        _self.MovePosition(_self.position+  _self.rotation*(Vector3)(_moveDir* (speed * Time.deltaTime)));
        
        
    }

    public void Relaod()
    {
        if (_ammo<12)
        {
                    if (_totalAmmo>0&& _totalAmmo-(12-_ammo)>=0)
                    {
                        _totalAmmo -= (12-_ammo);
                        _ammo += (12-_ammo);
                        
                    }
            
                    if (_totalAmmo>0&& _totalAmmo-(12-_ammo)<0)
                    {
                        _ammo += _totalAmmo;
                        _totalAmmo = 0;
                    }
        }
        

        _totalAmmoCount.text = "/" + _totalAmmo.ToString();
        _ammoCount.text = _ammo.ToString();
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Ammo")
        {
            _totalAmmo += 12;
            _totalAmmoCount.text="/"+ _totalAmmo.ToString();
            Destroy(other.gameObject);
        }
    }
}
