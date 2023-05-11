// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControls/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""BasicControls"",
            ""id"": ""b4a9fcfc-f558-40e8-bcc8-54a167bfe071"",
            ""actions"": [
                {
                    ""name"": ""MouseLeftClick"",
                    ""type"": ""Button"",
                    ""id"": ""371c681a-f50f-495e-a370-df7e80fa696d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.25)""
                },
                {
                    ""name"": ""MouseRightClick"",
                    ""type"": ""Button"",
                    ""id"": ""bc7f38b0-b9af-468f-8677-b0df6d13b4b3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""MouseMiddleClick"",
                    ""type"": ""Button"",
                    ""id"": ""05d7f308-1524-46aa-b528-2bf196f57f09"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.01)""
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""b3b18f41-07c0-4bef-b550-cc6b6918d490"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseDelta"",
                    ""type"": ""Value"",
                    ""id"": ""acfd254c-ab84-49f4-b808-dcd62651c6f7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseScroll"",
                    ""type"": ""Value"",
                    ""id"": ""c9bf6be2-35f7-43b6-90dc-c40f4efd084a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Escape"",
                    ""type"": ""Button"",
                    ""id"": ""cc0bea0c-9aa6-4b1e-866d-07ca89a50a75"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""TechTree"",
                    ""type"": ""Button"",
                    ""id"": ""e5f3a641-41c7-45cf-b9d8-34b45fd1168c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""BuildMenu"",
                    ""type"": ""Button"",
                    ""id"": ""e0210e6b-0770-408a-8b76-3dbb01f82f51"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""Recruit"",
                    ""type"": ""Button"",
                    ""id"": ""b7182db4-8d67-4e79-a672-57e33a3197b6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""TempGenerateWorld"",
                    ""type"": ""Button"",
                    ""id"": ""bb675483-cedc-42a3-bcea-d737f378862c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""TempLoadWorld"",
                    ""type"": ""Button"",
                    ""id"": ""04a54777-95f5-4c83-8eae-98d53303fe05"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""TempSaveWorld"",
                    ""type"": ""Button"",
                    ""id"": ""66bc1654-4b42-4cbb-94f4-91f6737fa9fc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""KeyboardMovement"",
                    ""type"": ""Value"",
                    ""id"": ""2f119222-cd78-46e7-9023-d55992c6d91b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e8a0ce9a-2551-4806-b6d1-1f46057868e1"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseLeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0e22da9a-4e79-40ce-8f8b-8aa68c37a53c"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseMiddleClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ae50a8d-cc31-46d0-a14d-9d74f23f4c5d"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4defc44d-204b-4222-98b5-5a341443c844"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseScroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""339dade6-4cc0-4960-b930-cad3f475745d"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2f358b3e-350f-4665-9052-0fc5984bc35e"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TechTree"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a476b5a-784e-4afd-a8b0-9b7b539c475c"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d4a01774-4396-4580-82b0-dd9d56ec60b2"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseRightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9bbd86af-a1ad-4085-958c-0ca9e2e90296"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BuildMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2d1112fd-8ad9-41a4-9105-e56a7004b407"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Recruit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8c2d58a4-99c0-43fc-9baf-8acff367d23f"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TempGenerateWorld"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e1625659-43ff-4c51-99e3-1fb469dff943"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TempLoadWorld"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef037113-124b-46dd-a8f0-c8cc59ef3578"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TempSaveWorld"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""c552214d-f0a4-4639-8933-8e26b3ba2d1a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeyboardMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""298dbf10-4a86-41fa-a05e-98e84be09eb8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeyboardMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""41580d6f-9ab5-4dc9-922b-31e6ba0d1491"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeyboardMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5a274f64-c0b4-4c3c-b53c-22005c44e91e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeyboardMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6d67ce7e-44e2-496f-9675-c5e1268a1a3a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeyboardMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""5683cf8b-9430-4193-ae49-6a21b84e8d41"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeyboardMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""71b1a279-2ded-4440-bd70-3589eb9bae96"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeyboardMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ac6e4677-7037-4b4f-a930-e4cc14310fdb"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeyboardMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5d901a01-ccf9-478d-9726-e1e85331a3e1"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeyboardMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""be5d3a21-45a0-4ac4-adf3-2be528e99f9c"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeyboardMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""MouseAndKeyboard"",
            ""bindingGroup"": ""MouseAndKeyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // BasicControls
        m_BasicControls = asset.FindActionMap("BasicControls", throwIfNotFound: true);
        m_BasicControls_MouseLeftClick = m_BasicControls.FindAction("MouseLeftClick", throwIfNotFound: true);
        m_BasicControls_MouseRightClick = m_BasicControls.FindAction("MouseRightClick", throwIfNotFound: true);
        m_BasicControls_MouseMiddleClick = m_BasicControls.FindAction("MouseMiddleClick", throwIfNotFound: true);
        m_BasicControls_MousePosition = m_BasicControls.FindAction("MousePosition", throwIfNotFound: true);
        m_BasicControls_MouseDelta = m_BasicControls.FindAction("MouseDelta", throwIfNotFound: true);
        m_BasicControls_MouseScroll = m_BasicControls.FindAction("MouseScroll", throwIfNotFound: true);
        m_BasicControls_Escape = m_BasicControls.FindAction("Escape", throwIfNotFound: true);
        m_BasicControls_TechTree = m_BasicControls.FindAction("TechTree", throwIfNotFound: true);
        m_BasicControls_BuildMenu = m_BasicControls.FindAction("BuildMenu", throwIfNotFound: true);
        m_BasicControls_Recruit = m_BasicControls.FindAction("Recruit", throwIfNotFound: true);
        m_BasicControls_TempGenerateWorld = m_BasicControls.FindAction("TempGenerateWorld", throwIfNotFound: true);
        m_BasicControls_TempLoadWorld = m_BasicControls.FindAction("TempLoadWorld", throwIfNotFound: true);
        m_BasicControls_TempSaveWorld = m_BasicControls.FindAction("TempSaveWorld", throwIfNotFound: true);
        m_BasicControls_KeyboardMovement = m_BasicControls.FindAction("KeyboardMovement", throwIfNotFound: true);
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

    // BasicControls
    private readonly InputActionMap m_BasicControls;
    private IBasicControlsActions m_BasicControlsActionsCallbackInterface;
    private readonly InputAction m_BasicControls_MouseLeftClick;
    private readonly InputAction m_BasicControls_MouseRightClick;
    private readonly InputAction m_BasicControls_MouseMiddleClick;
    private readonly InputAction m_BasicControls_MousePosition;
    private readonly InputAction m_BasicControls_MouseDelta;
    private readonly InputAction m_BasicControls_MouseScroll;
    private readonly InputAction m_BasicControls_Escape;
    private readonly InputAction m_BasicControls_TechTree;
    private readonly InputAction m_BasicControls_BuildMenu;
    private readonly InputAction m_BasicControls_Recruit;
    private readonly InputAction m_BasicControls_TempGenerateWorld;
    private readonly InputAction m_BasicControls_TempLoadWorld;
    private readonly InputAction m_BasicControls_TempSaveWorld;
    private readonly InputAction m_BasicControls_KeyboardMovement;
    public struct BasicControlsActions
    {
        private @PlayerInput m_Wrapper;
        public BasicControlsActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @MouseLeftClick => m_Wrapper.m_BasicControls_MouseLeftClick;
        public InputAction @MouseRightClick => m_Wrapper.m_BasicControls_MouseRightClick;
        public InputAction @MouseMiddleClick => m_Wrapper.m_BasicControls_MouseMiddleClick;
        public InputAction @MousePosition => m_Wrapper.m_BasicControls_MousePosition;
        public InputAction @MouseDelta => m_Wrapper.m_BasicControls_MouseDelta;
        public InputAction @MouseScroll => m_Wrapper.m_BasicControls_MouseScroll;
        public InputAction @Escape => m_Wrapper.m_BasicControls_Escape;
        public InputAction @TechTree => m_Wrapper.m_BasicControls_TechTree;
        public InputAction @BuildMenu => m_Wrapper.m_BasicControls_BuildMenu;
        public InputAction @Recruit => m_Wrapper.m_BasicControls_Recruit;
        public InputAction @TempGenerateWorld => m_Wrapper.m_BasicControls_TempGenerateWorld;
        public InputAction @TempLoadWorld => m_Wrapper.m_BasicControls_TempLoadWorld;
        public InputAction @TempSaveWorld => m_Wrapper.m_BasicControls_TempSaveWorld;
        public InputAction @KeyboardMovement => m_Wrapper.m_BasicControls_KeyboardMovement;
        public InputActionMap Get() { return m_Wrapper.m_BasicControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BasicControlsActions set) { return set.Get(); }
        public void SetCallbacks(IBasicControlsActions instance)
        {
            if (m_Wrapper.m_BasicControlsActionsCallbackInterface != null)
            {
                @MouseLeftClick.started -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnMouseLeftClick;
                @MouseLeftClick.performed -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnMouseLeftClick;
                @MouseLeftClick.canceled -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnMouseLeftClick;
                @MouseRightClick.started -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnMouseRightClick;
                @MouseRightClick.performed -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnMouseRightClick;
                @MouseRightClick.canceled -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnMouseRightClick;
                @MouseMiddleClick.started -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnMouseMiddleClick;
                @MouseMiddleClick.performed -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnMouseMiddleClick;
                @MouseMiddleClick.canceled -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnMouseMiddleClick;
                @MousePosition.started -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnMousePosition;
                @MouseDelta.started -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnMouseDelta;
                @MouseDelta.performed -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnMouseDelta;
                @MouseDelta.canceled -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnMouseDelta;
                @MouseScroll.started -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnMouseScroll;
                @MouseScroll.performed -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnMouseScroll;
                @MouseScroll.canceled -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnMouseScroll;
                @Escape.started -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnEscape;
                @Escape.performed -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnEscape;
                @Escape.canceled -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnEscape;
                @TechTree.started -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnTechTree;
                @TechTree.performed -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnTechTree;
                @TechTree.canceled -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnTechTree;
                @BuildMenu.started -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnBuildMenu;
                @BuildMenu.performed -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnBuildMenu;
                @BuildMenu.canceled -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnBuildMenu;
                @Recruit.started -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnRecruit;
                @Recruit.performed -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnRecruit;
                @Recruit.canceled -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnRecruit;
                @TempGenerateWorld.started -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnTempGenerateWorld;
                @TempGenerateWorld.performed -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnTempGenerateWorld;
                @TempGenerateWorld.canceled -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnTempGenerateWorld;
                @TempLoadWorld.started -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnTempLoadWorld;
                @TempLoadWorld.performed -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnTempLoadWorld;
                @TempLoadWorld.canceled -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnTempLoadWorld;
                @TempSaveWorld.started -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnTempSaveWorld;
                @TempSaveWorld.performed -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnTempSaveWorld;
                @TempSaveWorld.canceled -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnTempSaveWorld;
                @KeyboardMovement.started -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnKeyboardMovement;
                @KeyboardMovement.performed -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnKeyboardMovement;
                @KeyboardMovement.canceled -= m_Wrapper.m_BasicControlsActionsCallbackInterface.OnKeyboardMovement;
            }
            m_Wrapper.m_BasicControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MouseLeftClick.started += instance.OnMouseLeftClick;
                @MouseLeftClick.performed += instance.OnMouseLeftClick;
                @MouseLeftClick.canceled += instance.OnMouseLeftClick;
                @MouseRightClick.started += instance.OnMouseRightClick;
                @MouseRightClick.performed += instance.OnMouseRightClick;
                @MouseRightClick.canceled += instance.OnMouseRightClick;
                @MouseMiddleClick.started += instance.OnMouseMiddleClick;
                @MouseMiddleClick.performed += instance.OnMouseMiddleClick;
                @MouseMiddleClick.canceled += instance.OnMouseMiddleClick;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
                @MouseDelta.started += instance.OnMouseDelta;
                @MouseDelta.performed += instance.OnMouseDelta;
                @MouseDelta.canceled += instance.OnMouseDelta;
                @MouseScroll.started += instance.OnMouseScroll;
                @MouseScroll.performed += instance.OnMouseScroll;
                @MouseScroll.canceled += instance.OnMouseScroll;
                @Escape.started += instance.OnEscape;
                @Escape.performed += instance.OnEscape;
                @Escape.canceled += instance.OnEscape;
                @TechTree.started += instance.OnTechTree;
                @TechTree.performed += instance.OnTechTree;
                @TechTree.canceled += instance.OnTechTree;
                @BuildMenu.started += instance.OnBuildMenu;
                @BuildMenu.performed += instance.OnBuildMenu;
                @BuildMenu.canceled += instance.OnBuildMenu;
                @Recruit.started += instance.OnRecruit;
                @Recruit.performed += instance.OnRecruit;
                @Recruit.canceled += instance.OnRecruit;
                @TempGenerateWorld.started += instance.OnTempGenerateWorld;
                @TempGenerateWorld.performed += instance.OnTempGenerateWorld;
                @TempGenerateWorld.canceled += instance.OnTempGenerateWorld;
                @TempLoadWorld.started += instance.OnTempLoadWorld;
                @TempLoadWorld.performed += instance.OnTempLoadWorld;
                @TempLoadWorld.canceled += instance.OnTempLoadWorld;
                @TempSaveWorld.started += instance.OnTempSaveWorld;
                @TempSaveWorld.performed += instance.OnTempSaveWorld;
                @TempSaveWorld.canceled += instance.OnTempSaveWorld;
                @KeyboardMovement.started += instance.OnKeyboardMovement;
                @KeyboardMovement.performed += instance.OnKeyboardMovement;
                @KeyboardMovement.canceled += instance.OnKeyboardMovement;
            }
        }
    }
    public BasicControlsActions @BasicControls => new BasicControlsActions(this);
    private int m_MouseAndKeyboardSchemeIndex = -1;
    public InputControlScheme MouseAndKeyboardScheme
    {
        get
        {
            if (m_MouseAndKeyboardSchemeIndex == -1) m_MouseAndKeyboardSchemeIndex = asset.FindControlSchemeIndex("MouseAndKeyboard");
            return asset.controlSchemes[m_MouseAndKeyboardSchemeIndex];
        }
    }
    public interface IBasicControlsActions
    {
        void OnMouseLeftClick(InputAction.CallbackContext context);
        void OnMouseRightClick(InputAction.CallbackContext context);
        void OnMouseMiddleClick(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
        void OnMouseDelta(InputAction.CallbackContext context);
        void OnMouseScroll(InputAction.CallbackContext context);
        void OnEscape(InputAction.CallbackContext context);
        void OnTechTree(InputAction.CallbackContext context);
        void OnBuildMenu(InputAction.CallbackContext context);
        void OnRecruit(InputAction.CallbackContext context);
        void OnTempGenerateWorld(InputAction.CallbackContext context);
        void OnTempLoadWorld(InputAction.CallbackContext context);
        void OnTempSaveWorld(InputAction.CallbackContext context);
        void OnKeyboardMovement(InputAction.CallbackContext context);
    }
}
