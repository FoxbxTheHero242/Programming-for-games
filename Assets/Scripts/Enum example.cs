using System;
using UnityEngine;

namespace ScriptableObjects
{
    [Flags]
    public enum Raity
    {
        Common=1,
        Rare=2,
        Epic=4,
        Legendary=8
    }

    [CreateAssetMenu(menuName = "Enum/Enumexample")]
    public class Enumexample : ScriptableObject
    {
        [field: SerializeField] public Raity _raity { get; set; }
    }
}
