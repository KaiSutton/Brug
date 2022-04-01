// GENERATED AUTOMATICALLY FROM 'Assets/_Scripts/InputSystem/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Local Motion"",
            ""id"": ""b20666f5-cb2d-46bd-b673-73143fad7b76"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5888bf84-5496-4657-8a74-bd5b40f67d33"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""f4a061f1-4627-4d04-94c9-cd17b3606642"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f00c4659-5ee6-4511-ac14-a1ec2f530230"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ba3f4a30-c2d9-49bf-bb1c-02fee256a46a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c7cd5577-6148-4b24-9e9d-df7a5c4a4c2d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""02d13485-815b-4749-aead-b8f29e52c810"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Local Motion
        m_LocalMotion = asset.FindActionMap("Local Motion", throwIfNotFound: true);
        m_LocalMotion_Move = m_LocalMotion.FindAction("Move", throwIfNotFound: true);
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

    // Local Motion
    private readonly InputActionMap m_LocalMotion;
    private ILocalMotionActions m_LocalMotionActionsCallbackInterface;
    private readonly InputAction m_LocalMotion_Move;
    public struct LocalMotionActions
    {
        private @Controls m_Wrapper;
        public LocalMotionActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_LocalMotion_Move;
        public InputActionMap Get() { return m_Wrapper.m_LocalMotion; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LocalMotionActions set) { return set.Get(); }
        public void SetCallbacks(ILocalMotionActions instance)
        {
            if (m_Wrapper.m_LocalMotionActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_LocalMotionActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_LocalMotionActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_LocalMotionActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_LocalMotionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public LocalMotionActions @LocalMotion => new LocalMotionActions(this);
    public interface ILocalMotionActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
