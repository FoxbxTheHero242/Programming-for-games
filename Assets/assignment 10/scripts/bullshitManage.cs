using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class bullshitManage
{
    private static Act _act;

    public static void init(clicktoplace clicktoplace)
    {
        _act = new Act();
        _act.fuck.Enable();
        
        _act.fuck.bullshit.performed += bullshit =>
        {
            clicktoplace.movemouse(bullshit.ReadValue<Vector2>());
        };
        _act.fuck.Unity_Sucks_Balls.performed += ass =>
        {
            clicktoplace.Dropit();
        };
    }
}
