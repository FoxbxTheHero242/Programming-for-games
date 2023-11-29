using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Inputmanager
{
    private static Input_actions _inputActions;
    public static void INIT(clicktoplace clicktoplace)
    {
        _inputActions = new Input_actions();

        _inputActions.mouseClicks.MousePos.performed += mouse =>
        {
            clicktoplace.mouspos = mouse.ReadValue<Vector2>();
        };
    }
}
