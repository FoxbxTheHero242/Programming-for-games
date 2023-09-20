using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputManager
{
    private static Controls _controls;
    
    public static void Init(Player player)
    {
        _controls = new Controls();

        _controls.Game.Movement.performed += Move =>
        {
            player.setMoveDir(Move.ReadValue<Vector2>());
        };
        _controls.Permanent.Enable();
    }

    public static void GameMode()
    {
        _controls.Game.Enable();
        _controls.Ui.Disable();
    }

    public static void UiMode()
    {
        _controls.Game.Disable();
        _controls.Ui.Enable();
    }
    
    
    
    
}
