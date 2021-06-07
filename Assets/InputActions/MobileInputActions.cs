// GENERATED AUTOMATICALLY FROM 'Assets/InputActions/Mobile.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MobileInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MobileInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Mobile"",
    ""maps"": [
        {
            ""name"": ""Mobile"",
            ""id"": ""fd40fc39-9bff-4071-99ab-291dbb960039"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""3c8c4696-efc3-4f0a-868b-35b2dfdd7842"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""9e51aaa1-c9f7-4553-b584-dbc37be540c3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FlutePlay"",
                    ""type"": ""Button"",
                    ""id"": ""634dbc33-744b-4a58-9971-aeec9cd1c45b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""053051b4-a6e5-4047-80a3-19e98df22554"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f4509395-eadf-49a5-a95d-b4a67fc07627"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""409cb86b-b45c-4007-8dd0-8fc58f9d5370"",
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
                    ""id"": ""1a6a86f1-9469-4479-8100-5ab163f208e7"",
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
                    ""id"": ""557f7cd7-3d3e-439d-801f-2f5065bd7cf3"",
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
                    ""id"": ""a4a69d4e-89c3-49e4-b034-3c5e34d18949"",
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
                    ""id"": ""4969e2e7-2dda-4439-9167-38c1628adad0"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0341bdc5-5d82-4853-8a19-f1645c48a27c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4fbddf0b-9743-4266-b69a-a8d911b13fb5"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3d23e00b-31ba-481b-9e72-f804b71ee2e7"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlutePlay"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd3097de-f709-4f66-b770-095cb5171cfc"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlutePlay"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""332ee225-99ca-4919-9cd3-6512ac745b47"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6efd8250-7883-488e-806b-2d27088bcd15"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Mobile
        m_Mobile = asset.FindActionMap("Mobile", throwIfNotFound: true);
        m_Mobile_Move = m_Mobile.FindAction("Move", throwIfNotFound: true);
        m_Mobile_Jump = m_Mobile.FindAction("Jump", throwIfNotFound: true);
        m_Mobile_FlutePlay = m_Mobile.FindAction("FlutePlay", throwIfNotFound: true);
        m_Mobile_Pause = m_Mobile.FindAction("Pause", throwIfNotFound: true);
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

    // Mobile
    private readonly InputActionMap m_Mobile;
    private IMobileActions m_MobileActionsCallbackInterface;
    private readonly InputAction m_Mobile_Move;
    private readonly InputAction m_Mobile_Jump;
    private readonly InputAction m_Mobile_FlutePlay;
    private readonly InputAction m_Mobile_Pause;
    public struct MobileActions
    {
        private @MobileInput m_Wrapper;
        public MobileActions(@MobileInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Mobile_Move;
        public InputAction @Jump => m_Wrapper.m_Mobile_Jump;
        public InputAction @FlutePlay => m_Wrapper.m_Mobile_FlutePlay;
        public InputAction @Pause => m_Wrapper.m_Mobile_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Mobile; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MobileActions set) { return set.Get(); }
        public void SetCallbacks(IMobileActions instance)
        {
            if (m_Wrapper.m_MobileActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MobileActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MobileActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MobileActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_MobileActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MobileActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MobileActionsCallbackInterface.OnJump;
                @FlutePlay.started -= m_Wrapper.m_MobileActionsCallbackInterface.OnFlutePlay;
                @FlutePlay.performed -= m_Wrapper.m_MobileActionsCallbackInterface.OnFlutePlay;
                @FlutePlay.canceled -= m_Wrapper.m_MobileActionsCallbackInterface.OnFlutePlay;
                @Pause.started -= m_Wrapper.m_MobileActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_MobileActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_MobileActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_MobileActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @FlutePlay.started += instance.OnFlutePlay;
                @FlutePlay.performed += instance.OnFlutePlay;
                @FlutePlay.canceled += instance.OnFlutePlay;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public MobileActions @Mobile => new MobileActions(this);
    public interface IMobileActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnFlutePlay(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
