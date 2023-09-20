using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float speed;

    private Vector2 _moveDir;
    // Start is called before the first frame update
    void Start()
    {
        InputManager.Init(this);
        InputManager.GameMode();
    }

    public void setMoveDir(Vector2 moveDir)
    {
        _moveDir= moveDir;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += _moveDir * speed * Time.deltaTime;
    }
}
