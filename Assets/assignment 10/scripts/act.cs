//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/assignment 10/scripts/act.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Act: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Act()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""act"",
    ""maps"": [
        {
            ""name"": ""fuck"",
            ""id"": ""066efa03-7038-4178-ae18-f5a4d2b99ad3"",
            ""actions"": [
                {
                    ""name"": ""bullshit"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1d0b02c9-2e38-47f7-860c-713b21b07743"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Unity_Sucks_Balls"",
                    ""type"": ""Button"",
                    ""id"": ""4713cc72-d64b-437f-8e42-bf4b84d03ed5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e3e441b2-d2b9-4219-969b-bea818421496"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""bullshit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a3b94812-4563-49ef-af0c-d5d9bb432d21"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Unity_Sucks_Balls"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // fuck
        m_fuck = asset.FindActionMap("fuck", throwIfNotFound: true);
        m_fuck_bullshit = m_fuck.FindAction("bullshit", throwIfNotFound: true);
        m_fuck_Unity_Sucks_Balls = m_fuck.FindAction("Unity_Sucks_Balls", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // fuck
    private readonly InputActionMap m_fuck;
    private List<IFuckActions> m_FuckActionsCallbackInterfaces = new List<IFuckActions>();
    private readonly InputAction m_fuck_bullshit;
    private readonly InputAction m_fuck_Unity_Sucks_Balls;
    public struct FuckActions
    {
        private @Act m_Wrapper;
        public FuckActions(@Act wrapper) { m_Wrapper = wrapper; }
        public InputAction @bullshit => m_Wrapper.m_fuck_bullshit;
        public InputAction @Unity_Sucks_Balls => m_Wrapper.m_fuck_Unity_Sucks_Balls;
        public InputActionMap Get() { return m_Wrapper.m_fuck; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FuckActions set) { return set.Get(); }
        public void AddCallbacks(IFuckActions instance)
        {
            if (instance == null || m_Wrapper.m_FuckActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_FuckActionsCallbackInterfaces.Add(instance);
            @bullshit.started += instance.OnBullshit;
            @bullshit.performed += instance.OnBullshit;
            @bullshit.canceled += instance.OnBullshit;
            @Unity_Sucks_Balls.started += instance.OnUnity_Sucks_Balls;
            @Unity_Sucks_Balls.performed += instance.OnUnity_Sucks_Balls;
            @Unity_Sucks_Balls.canceled += instance.OnUnity_Sucks_Balls;
        }

        private void UnregisterCallbacks(IFuckActions instance)
        {
            @bullshit.started -= instance.OnBullshit;
            @bullshit.performed -= instance.OnBullshit;
            @bullshit.canceled -= instance.OnBullshit;
            @Unity_Sucks_Balls.started -= instance.OnUnity_Sucks_Balls;
            @Unity_Sucks_Balls.performed -= instance.OnUnity_Sucks_Balls;
            @Unity_Sucks_Balls.canceled -= instance.OnUnity_Sucks_Balls;
        }

        public void RemoveCallbacks(IFuckActions instance)
        {
            if (m_Wrapper.m_FuckActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IFuckActions instance)
        {
            foreach (var item in m_Wrapper.m_FuckActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_FuckActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public FuckActions @fuck => new FuckActions(this);
    public interface IFuckActions
    {
        void OnBullshit(InputAction.CallbackContext context);
        void OnUnity_Sucks_Balls(InputAction.CallbackContext context);
    }
}
