using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float speed;

    private Vector3 _moveDir;
    // Start is called before the first frame update
    void Start()
    {
        InputManager.Init(this);
        InputManager.GameMode();
    }

    public void setMoveDir(Vector3 moveDir)
    {
        _moveDir= moveDir;
    }
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(_moveDir);
        transform.position += (Vector3) (_moveDir * (speed * Time.deltaTime));
    }
}
