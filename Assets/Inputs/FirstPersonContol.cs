//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Inputs/FirstPersonContol.inputactions
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

public partial class @FirstPersonContol: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @FirstPersonContol()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""FirstPersonContol"",
    ""maps"": [
        {
            ""name"": ""Gameplay Control"",
            ""id"": ""cf0007e4-5ae3-4767-a663-e96110f0cecb"",
            ""actions"": [
                {
                    ""name"": ""CameraLook"",
                    ""type"": ""Value"",
                    ""id"": ""925034d6-415b-4c9a-b470-529a38f479d9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""PlayerMove"",
                    ""type"": ""Value"",
                    ""id"": ""b8034149-219c-4379-a46e-5954717633e5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c6a5f939-d0ec-4f95-8b00-8547c19778fc"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASDKeys"",
                    ""id"": ""20b5b078-e4de-4c23-bb04-980a552106b1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""063cddd4-16cd-41e7-9efb-564e5b2f5b41"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a708d417-9c38-4dee-b135-d90d9d4e2f5d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1570745e-9f0a-4da4-9bc3-6e3e4583a591"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8c23b263-883e-4e1e-bbd9-a8c9d4ccd8df"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""f2738ef1-48e7-4a5c-aada-b0722d3fc572"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""20cd635e-c7df-4656-a430-cc9046a0d836"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""381c3793-ab59-441d-9da7-0ed994b97def"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7762611e-9f1d-45be-89d1-8f0b8702b2f0"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""243e2d91-ead0-48c5-b38a-c7e3a5e9de58"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay Control
        m_GameplayControl = asset.FindActionMap("Gameplay Control", throwIfNotFound: true);
        m_GameplayControl_CameraLook = m_GameplayControl.FindAction("CameraLook", throwIfNotFound: true);
        m_GameplayControl_PlayerMove = m_GameplayControl.FindAction("PlayerMove", throwIfNotFound: true);
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

    // Gameplay Control
    private readonly InputActionMap m_GameplayControl;
    private List<IGameplayControlActions> m_GameplayControlActionsCallbackInterfaces = new List<IGameplayControlActions>();
    private readonly InputAction m_GameplayControl_CameraLook;
    private readonly InputAction m_GameplayControl_PlayerMove;
    public struct GameplayControlActions
    {
        private @FirstPersonContol m_Wrapper;
        public GameplayControlActions(@FirstPersonContol wrapper) { m_Wrapper = wrapper; }
        public InputAction @CameraLook => m_Wrapper.m_GameplayControl_CameraLook;
        public InputAction @PlayerMove => m_Wrapper.m_GameplayControl_PlayerMove;
        public InputActionMap Get() { return m_Wrapper.m_GameplayControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayControlActions set) { return set.Get(); }
        public void AddCallbacks(IGameplayControlActions instance)
        {
            if (instance == null || m_Wrapper.m_GameplayControlActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameplayControlActionsCallbackInterfaces.Add(instance);
            @CameraLook.started += instance.OnCameraLook;
            @CameraLook.performed += instance.OnCameraLook;
            @CameraLook.canceled += instance.OnCameraLook;
            @PlayerMove.started += instance.OnPlayerMove;
            @PlayerMove.performed += instance.OnPlayerMove;
            @PlayerMove.canceled += instance.OnPlayerMove;
        }

        private void UnregisterCallbacks(IGameplayControlActions instance)
        {
            @CameraLook.started -= instance.OnCameraLook;
            @CameraLook.performed -= instance.OnCameraLook;
            @CameraLook.canceled -= instance.OnCameraLook;
            @PlayerMove.started -= instance.OnPlayerMove;
            @PlayerMove.performed -= instance.OnPlayerMove;
            @PlayerMove.canceled -= instance.OnPlayerMove;
        }

        public void RemoveCallbacks(IGameplayControlActions instance)
        {
            if (m_Wrapper.m_GameplayControlActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameplayControlActions instance)
        {
            foreach (var item in m_Wrapper.m_GameplayControlActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameplayControlActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameplayControlActions @GameplayControl => new GameplayControlActions(this);
    public interface IGameplayControlActions
    {
        void OnCameraLook(InputAction.CallbackContext context);
        void OnPlayerMove(InputAction.CallbackContext context);
    }
}
