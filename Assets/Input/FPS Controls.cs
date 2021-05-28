// GENERATED AUTOMATICALLY FROM 'Assets/Input/FPS Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @FPSControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @FPSControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""FPS Controls"",
    ""maps"": [
        {
            ""name"": ""Gameplay Controls"",
            ""id"": ""f5c47aba-c3b5-47a6-bfaf-091867207bf0"",
            ""actions"": [
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""357b026e-4c6e-44bd-bf30-96804dfdc698"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""574d1955-71e4-4afe-aead-55f27aea0226"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""e34f8d15-c1b5-4cb7-825a-93def40cf0eb"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouchstart"",
                    ""type"": ""Button"",
                    ""id"": ""6e8c1229-7099-4bf0-a329-2f25df1db726"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouchend"",
                    ""type"": ""Button"",
                    ""id"": ""3521dbd1-c9fc-4492-b0cd-4a9cee045ed3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprintstart"",
                    ""type"": ""Button"",
                    ""id"": ""b5656cd2-d291-4c0a-a7e0-34aeed6366f9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprintend"",
                    ""type"": ""Button"",
                    ""id"": ""e16d1209-65b8-4c24-8c7d-3ed0143c00e9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PauseMenu"",
                    ""type"": ""Value"",
                    ""id"": ""d7c86f96-c530-47cb-92f3-e042e1c77682"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Flashlight"",
                    ""type"": ""Button"",
                    ""id"": ""55c3e035-49f4-4ea8-9d9f-70a57f889e82"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""27c8b1ad-9159-4fd8-8eb6-c16df7ce94bc"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""edc9ff98-8f60-4bdd-b86a-0e64bc804dfa"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d1d65f68-265b-48cd-a611-3896db11ac97"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c589bb10-b243-477e-aa99-bf81e428b25a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c7fbce1c-1ec5-4fdf-a260-020ffb61f15e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""94aca598-f2d8-4449-8578-c06a1f55e3eb"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""288b6968-723c-4324-af91-625083561613"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af158d15-10c0-4c09-a572-71282c4ba6d5"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Crouchstart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2dd577a5-2dd4-4b2e-ac19-58693e26514b"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Sprintstart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""73bae297-4290-495f-b4f9-e0b89d0f19b8"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Sprintend"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""85e04155-2e90-4f5a-8bcb-1625243e3291"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Crouchend"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""54ce2f25-1505-4198-89f7-69af017e4170"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""PauseMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aedb9190-5b28-42ca-b015-69ebad201489"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Flashlight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and Mouse"",
            ""bindingGroup"": ""Keyboard and Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Gameplay Controls
        m_GameplayControls = asset.FindActionMap("Gameplay Controls", throwIfNotFound: true);
        m_GameplayControls_Look = m_GameplayControls.FindAction("Look", throwIfNotFound: true);
        m_GameplayControls_Movement = m_GameplayControls.FindAction("Movement", throwIfNotFound: true);
        m_GameplayControls_Jump = m_GameplayControls.FindAction("Jump", throwIfNotFound: true);
        m_GameplayControls_Crouchstart = m_GameplayControls.FindAction("Crouchstart", throwIfNotFound: true);
        m_GameplayControls_Crouchend = m_GameplayControls.FindAction("Crouchend", throwIfNotFound: true);
        m_GameplayControls_Sprintstart = m_GameplayControls.FindAction("Sprintstart", throwIfNotFound: true);
        m_GameplayControls_Sprintend = m_GameplayControls.FindAction("Sprintend", throwIfNotFound: true);
        m_GameplayControls_PauseMenu = m_GameplayControls.FindAction("PauseMenu", throwIfNotFound: true);
        m_GameplayControls_Flashlight = m_GameplayControls.FindAction("Flashlight", throwIfNotFound: true);
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

    // Gameplay Controls
    private readonly InputActionMap m_GameplayControls;
    private IGameplayControlsActions m_GameplayControlsActionsCallbackInterface;
    private readonly InputAction m_GameplayControls_Look;
    private readonly InputAction m_GameplayControls_Movement;
    private readonly InputAction m_GameplayControls_Jump;
    private readonly InputAction m_GameplayControls_Crouchstart;
    private readonly InputAction m_GameplayControls_Crouchend;
    private readonly InputAction m_GameplayControls_Sprintstart;
    private readonly InputAction m_GameplayControls_Sprintend;
    private readonly InputAction m_GameplayControls_PauseMenu;
    private readonly InputAction m_GameplayControls_Flashlight;
    public struct GameplayControlsActions
    {
        private @FPSControls m_Wrapper;
        public GameplayControlsActions(@FPSControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Look => m_Wrapper.m_GameplayControls_Look;
        public InputAction @Movement => m_Wrapper.m_GameplayControls_Movement;
        public InputAction @Jump => m_Wrapper.m_GameplayControls_Jump;
        public InputAction @Crouchstart => m_Wrapper.m_GameplayControls_Crouchstart;
        public InputAction @Crouchend => m_Wrapper.m_GameplayControls_Crouchend;
        public InputAction @Sprintstart => m_Wrapper.m_GameplayControls_Sprintstart;
        public InputAction @Sprintend => m_Wrapper.m_GameplayControls_Sprintend;
        public InputAction @PauseMenu => m_Wrapper.m_GameplayControls_PauseMenu;
        public InputAction @Flashlight => m_Wrapper.m_GameplayControls_Flashlight;
        public InputActionMap Get() { return m_Wrapper.m_GameplayControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayControlsActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayControlsActions instance)
        {
            if (m_Wrapper.m_GameplayControlsActionsCallbackInterface != null)
            {
                @Look.started -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnLook;
                @Movement.started -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnJump;
                @Crouchstart.started -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnCrouchstart;
                @Crouchstart.performed -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnCrouchstart;
                @Crouchstart.canceled -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnCrouchstart;
                @Crouchend.started -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnCrouchend;
                @Crouchend.performed -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnCrouchend;
                @Crouchend.canceled -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnCrouchend;
                @Sprintstart.started -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnSprintstart;
                @Sprintstart.performed -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnSprintstart;
                @Sprintstart.canceled -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnSprintstart;
                @Sprintend.started -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnSprintend;
                @Sprintend.performed -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnSprintend;
                @Sprintend.canceled -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnSprintend;
                @PauseMenu.started -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnPauseMenu;
                @PauseMenu.performed -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnPauseMenu;
                @PauseMenu.canceled -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnPauseMenu;
                @Flashlight.started -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnFlashlight;
                @Flashlight.performed -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnFlashlight;
                @Flashlight.canceled -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnFlashlight;
            }
            m_Wrapper.m_GameplayControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Crouchstart.started += instance.OnCrouchstart;
                @Crouchstart.performed += instance.OnCrouchstart;
                @Crouchstart.canceled += instance.OnCrouchstart;
                @Crouchend.started += instance.OnCrouchend;
                @Crouchend.performed += instance.OnCrouchend;
                @Crouchend.canceled += instance.OnCrouchend;
                @Sprintstart.started += instance.OnSprintstart;
                @Sprintstart.performed += instance.OnSprintstart;
                @Sprintstart.canceled += instance.OnSprintstart;
                @Sprintend.started += instance.OnSprintend;
                @Sprintend.performed += instance.OnSprintend;
                @Sprintend.canceled += instance.OnSprintend;
                @PauseMenu.started += instance.OnPauseMenu;
                @PauseMenu.performed += instance.OnPauseMenu;
                @PauseMenu.canceled += instance.OnPauseMenu;
                @Flashlight.started += instance.OnFlashlight;
                @Flashlight.performed += instance.OnFlashlight;
                @Flashlight.canceled += instance.OnFlashlight;
            }
        }
    }
    public GameplayControlsActions @GameplayControls => new GameplayControlsActions(this);
    private int m_KeyboardandMouseSchemeIndex = -1;
    public InputControlScheme KeyboardandMouseScheme
    {
        get
        {
            if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and Mouse");
            return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
        }
    }
    public interface IGameplayControlsActions
    {
        void OnLook(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCrouchstart(InputAction.CallbackContext context);
        void OnCrouchend(InputAction.CallbackContext context);
        void OnSprintstart(InputAction.CallbackContext context);
        void OnSprintend(InputAction.CallbackContext context);
        void OnPauseMenu(InputAction.CallbackContext context);
        void OnFlashlight(InputAction.CallbackContext context);
    }
}
