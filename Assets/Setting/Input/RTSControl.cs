//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Setting/Input/RTSControl.inputactions
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

public partial class @RTSControl : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @RTSControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""RTSControl"",
    ""maps"": [
        {
            ""name"": ""GameplayActionMap"",
            ""id"": ""60c0065c-1f93-408d-979b-f0aa31ad822a"",
            ""actions"": [
                {
                    ""name"": ""MoveCamera"",
                    ""type"": ""PassThrough"",
                    ""id"": ""601b65bf-0bf0-4e94-a0d4-9da275735f31"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RotateCamera"",
                    ""type"": ""Value"",
                    ""id"": ""3cd9d6d7-1797-461f-8087-645c92c8675a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ZoomCamera"",
                    ""type"": ""Value"",
                    ""id"": ""3df1a5af-6f62-45db-abfa-7a9a60f04696"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""e3eaa3b4-abbe-40da-9e12-f00048b9fcfb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PauseToggle"",
                    ""type"": ""Button"",
                    ""id"": ""423d1106-60e4-4010-84f6-3079c4fbaba0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Select Modifier"",
                    ""type"": ""Button"",
                    ""id"": ""6ddfecc7-ee11-4615-9ef5-19125951a068"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""1cccf90b-e58c-4e13-b69f-d3577561d4d8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5d3d2ec5-511a-4364-975a-6a24c13d3cda"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ZoomCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard(WASD)"",
                    ""id"": ""35eb990a-2027-4fb6-8819-79d060c9aa8f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4961f452-1605-4c83-a9a8-b3203cd144bf"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d0652183-da25-4f3f-b5b5-3a00cc1e9c65"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""57af32dd-8630-4c21-b80d-a568d537712a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9a3f1173-fc01-45dd-a967-bcfd81e9dd97"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard(Arrows)"",
                    ""id"": ""143a8944-2564-48ea-a5ac-2ce12e993eb4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0c07b451-d4bd-4581-ae5b-39758b170c9b"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""79c4b7a7-4f56-4d91-a1ce-bae30be73ca0"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e87bb37d-c79d-4330-8a08-cc914bfa773d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d66efbb4-801d-423b-8e8b-400929bbe51e"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""da63cf40-22f5-4973-b910-58ba4ac13fd6"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32c389c9-4cc8-4a2c-bbaa-d4cd83e264a4"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""832dcc21-5b09-49ed-b8ae-d53b2115c4c8"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""adf72a43-4c5b-45e2-a975-be4498d7089d"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select Modifier"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c6a19846-6b36-4007-b58e-a95714c2a418"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MainMenuActionMap"",
            ""id"": ""fa4d781e-44d7-4897-9e8e-c13afcdab3dc"",
            ""actions"": [
                {
                    ""name"": ""PauseToggle"",
                    ""type"": ""Button"",
                    ""id"": ""053f56e6-8eb3-48fb-8c28-7fdba228dd20"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""bdbfc11d-e4d6-4e3e-bf29-c79f34c138ff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2000289a-be57-4397-9196-889b145bc674"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""17019f01-2a02-42f0-a61b-ab2d303799e3"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GameplayActionMap
        m_GameplayActionMap = asset.FindActionMap("GameplayActionMap", throwIfNotFound: true);
        m_GameplayActionMap_MoveCamera = m_GameplayActionMap.FindAction("MoveCamera", throwIfNotFound: true);
        m_GameplayActionMap_RotateCamera = m_GameplayActionMap.FindAction("RotateCamera", throwIfNotFound: true);
        m_GameplayActionMap_ZoomCamera = m_GameplayActionMap.FindAction("ZoomCamera", throwIfNotFound: true);
        m_GameplayActionMap_Click = m_GameplayActionMap.FindAction("Click", throwIfNotFound: true);
        m_GameplayActionMap_PauseToggle = m_GameplayActionMap.FindAction("PauseToggle", throwIfNotFound: true);
        m_GameplayActionMap_SelectModifier = m_GameplayActionMap.FindAction("Select Modifier", throwIfNotFound: true);
        m_GameplayActionMap_MousePosition = m_GameplayActionMap.FindAction("MousePosition", throwIfNotFound: true);
        // MainMenuActionMap
        m_MainMenuActionMap = asset.FindActionMap("MainMenuActionMap", throwIfNotFound: true);
        m_MainMenuActionMap_PauseToggle = m_MainMenuActionMap.FindAction("PauseToggle", throwIfNotFound: true);
        m_MainMenuActionMap_Click = m_MainMenuActionMap.FindAction("Click", throwIfNotFound: true);
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

    // GameplayActionMap
    private readonly InputActionMap m_GameplayActionMap;
    private IGameplayActionMapActions m_GameplayActionMapActionsCallbackInterface;
    private readonly InputAction m_GameplayActionMap_MoveCamera;
    private readonly InputAction m_GameplayActionMap_RotateCamera;
    private readonly InputAction m_GameplayActionMap_ZoomCamera;
    private readonly InputAction m_GameplayActionMap_Click;
    private readonly InputAction m_GameplayActionMap_PauseToggle;
    private readonly InputAction m_GameplayActionMap_SelectModifier;
    private readonly InputAction m_GameplayActionMap_MousePosition;
    public struct GameplayActionMapActions
    {
        private @RTSControl m_Wrapper;
        public GameplayActionMapActions(@RTSControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveCamera => m_Wrapper.m_GameplayActionMap_MoveCamera;
        public InputAction @RotateCamera => m_Wrapper.m_GameplayActionMap_RotateCamera;
        public InputAction @ZoomCamera => m_Wrapper.m_GameplayActionMap_ZoomCamera;
        public InputAction @Click => m_Wrapper.m_GameplayActionMap_Click;
        public InputAction @PauseToggle => m_Wrapper.m_GameplayActionMap_PauseToggle;
        public InputAction @SelectModifier => m_Wrapper.m_GameplayActionMap_SelectModifier;
        public InputAction @MousePosition => m_Wrapper.m_GameplayActionMap_MousePosition;
        public InputActionMap Get() { return m_Wrapper.m_GameplayActionMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActionMapActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActionMapActions instance)
        {
            if (m_Wrapper.m_GameplayActionMapActionsCallbackInterface != null)
            {
                @MoveCamera.started -= m_Wrapper.m_GameplayActionMapActionsCallbackInterface.OnMoveCamera;
                @MoveCamera.performed -= m_Wrapper.m_GameplayActionMapActionsCallbackInterface.OnMoveCamera;
                @MoveCamera.canceled -= m_Wrapper.m_GameplayActionMapActionsCallbackInterface.OnMoveCamera;
                @RotateCamera.started -= m_Wrapper.m_GameplayActionMapActionsCallbackInterface.OnRotateCamera;
                @RotateCamera.performed -= m_Wrapper.m_GameplayActionMapActionsCallbackInterface.OnRotateCamera;
                @RotateCamera.canceled -= m_Wrapper.m_GameplayActionMapActionsCallbackInterface.OnRotateCamera;
                @ZoomCamera.started -= m_Wrapper.m_GameplayActionMapActionsCallbackInterface.OnZoomCamera;
                @ZoomCamera.performed -= m_Wrapper.m_GameplayActionMapActionsCallbackInterface.OnZoomCamera;
                @ZoomCamera.canceled -= m_Wrapper.m_GameplayActionMapActionsCallbackInterface.OnZoomCamera;
                @Click.started -= m_Wrapper.m_GameplayActionMapActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_GameplayActionMapActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_GameplayActionMapActionsCallbackInterface.OnClick;
                @PauseToggle.started -= m_Wrapper.m_GameplayActionMapActionsCallbackInterface.OnPauseToggle;
                @PauseToggle.performed -= m_Wrapper.m_GameplayActionMapActionsCallbackInterface.OnPauseToggle;
                @PauseToggle.canceled -= m_Wrapper.m_GameplayActionMapActionsCallbackInterface.OnPauseToggle;
                @SelectModifier.started -= m_Wrapper.m_GameplayActionMapActionsCallbackInterface.OnSelectModifier;
                @SelectModifier.performed -= m_Wrapper.m_GameplayActionMapActionsCallbackInterface.OnSelectModifier;
                @SelectModifier.canceled -= m_Wrapper.m_GameplayActionMapActionsCallbackInterface.OnSelectModifier;
                @MousePosition.started -= m_Wrapper.m_GameplayActionMapActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_GameplayActionMapActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_GameplayActionMapActionsCallbackInterface.OnMousePosition;
            }
            m_Wrapper.m_GameplayActionMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveCamera.started += instance.OnMoveCamera;
                @MoveCamera.performed += instance.OnMoveCamera;
                @MoveCamera.canceled += instance.OnMoveCamera;
                @RotateCamera.started += instance.OnRotateCamera;
                @RotateCamera.performed += instance.OnRotateCamera;
                @RotateCamera.canceled += instance.OnRotateCamera;
                @ZoomCamera.started += instance.OnZoomCamera;
                @ZoomCamera.performed += instance.OnZoomCamera;
                @ZoomCamera.canceled += instance.OnZoomCamera;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @PauseToggle.started += instance.OnPauseToggle;
                @PauseToggle.performed += instance.OnPauseToggle;
                @PauseToggle.canceled += instance.OnPauseToggle;
                @SelectModifier.started += instance.OnSelectModifier;
                @SelectModifier.performed += instance.OnSelectModifier;
                @SelectModifier.canceled += instance.OnSelectModifier;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
            }
        }
    }
    public GameplayActionMapActions @GameplayActionMap => new GameplayActionMapActions(this);

    // MainMenuActionMap
    private readonly InputActionMap m_MainMenuActionMap;
    private IMainMenuActionMapActions m_MainMenuActionMapActionsCallbackInterface;
    private readonly InputAction m_MainMenuActionMap_PauseToggle;
    private readonly InputAction m_MainMenuActionMap_Click;
    public struct MainMenuActionMapActions
    {
        private @RTSControl m_Wrapper;
        public MainMenuActionMapActions(@RTSControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @PauseToggle => m_Wrapper.m_MainMenuActionMap_PauseToggle;
        public InputAction @Click => m_Wrapper.m_MainMenuActionMap_Click;
        public InputActionMap Get() { return m_Wrapper.m_MainMenuActionMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainMenuActionMapActions set) { return set.Get(); }
        public void SetCallbacks(IMainMenuActionMapActions instance)
        {
            if (m_Wrapper.m_MainMenuActionMapActionsCallbackInterface != null)
            {
                @PauseToggle.started -= m_Wrapper.m_MainMenuActionMapActionsCallbackInterface.OnPauseToggle;
                @PauseToggle.performed -= m_Wrapper.m_MainMenuActionMapActionsCallbackInterface.OnPauseToggle;
                @PauseToggle.canceled -= m_Wrapper.m_MainMenuActionMapActionsCallbackInterface.OnPauseToggle;
                @Click.started -= m_Wrapper.m_MainMenuActionMapActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_MainMenuActionMapActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_MainMenuActionMapActionsCallbackInterface.OnClick;
            }
            m_Wrapper.m_MainMenuActionMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PauseToggle.started += instance.OnPauseToggle;
                @PauseToggle.performed += instance.OnPauseToggle;
                @PauseToggle.canceled += instance.OnPauseToggle;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
            }
        }
    }
    public MainMenuActionMapActions @MainMenuActionMap => new MainMenuActionMapActions(this);
    public interface IGameplayActionMapActions
    {
        void OnMoveCamera(InputAction.CallbackContext context);
        void OnRotateCamera(InputAction.CallbackContext context);
        void OnZoomCamera(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnPauseToggle(InputAction.CallbackContext context);
        void OnSelectModifier(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
    }
    public interface IMainMenuActionMapActions
    {
        void OnPauseToggle(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
    }
}
