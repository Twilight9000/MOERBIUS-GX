//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/PlayerControllers/carControls.inputactions
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

public partial class @CarControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @CarControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""carControls"",
    ""maps"": [
        {
            ""name"": ""car"",
            ""id"": ""ed5eae4a-fa8d-4833-b1fd-d1b99af21667"",
            ""actions"": [
                {
                    ""name"": ""hMove"",
                    ""type"": ""Value"",
                    ""id"": ""ecc7132d-f5e4-4d07-8984-4391101566ac"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""vMove"",
                    ""type"": ""Value"",
                    ""id"": ""14ed91c4-bec2-4e34-895d-6e14aff9c3f0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Accelerate"",
                    ""type"": ""Button"",
                    ""id"": ""18d50a0f-4664-4e72-a694-5e5a1505c15a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Reverse"",
                    ""type"": ""Button"",
                    ""id"": ""f3b980e3-c154-45fb-8f57-b8aa3f5b577d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Restart"",
                    ""type"": ""Button"",
                    ""id"": ""d57d9d0b-8f21-4f75-a2cf-c7d77f8d5b69"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Quit"",
                    ""type"": ""Button"",
                    ""id"": ""8984c758-8bd0-4a92-a07a-004111088d32"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""b215f4e3-129e-4eee-97e6-c4cee36459df"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""f60be111-1288-4756-8305-bcf344efce0f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RotateCamera"",
                    ""type"": ""Value"",
                    ""id"": ""c7daadd0-7a89-4608-b998-5c8aafeb48ca"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""cf5d1b51-083b-4863-9db8-37bf7a3d8ea6"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""hMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""65e072b0-b756-474f-a10b-202b0e87c64a"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""hMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""78b682fb-cda6-4663-b77d-2c05385690c7"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""hMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""ae9cd2bb-47e3-4811-8f04-0d9a232d2206"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""hMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ec9d2668-081b-4aef-8ec9-1fc7b304dfdf"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""hMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1cc6fcd5-f31b-4425-874a-5460fdf1bf11"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""hMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Movement2"",
                    ""id"": ""f0759d84-1db2-44cd-bbcb-214b0768dfbf"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""vMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""86f24928-7367-4c39-80c3-fdd3c2bc3ea1"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""vMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ffafb35c-6588-4e69-8d9d-14591c812b9e"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""vMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8e4f508f-261c-4f06-a078-d3b31cc3edc0"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd69118d-5d41-413b-8f0c-2085f3728f96"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c438e36f-34af-412f-8451-3986d004d77f"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a369f902-5d96-47a8-96ae-ef70b6e19999"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c87a8504-eb59-4208-bcd5-22848ea3e8b4"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Restart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bf7c95fe-e571-400a-8e40-82896efed7d4"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Restart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7affd8ca-56de-47e6-8a2c-efc6abb79e4c"",
                    ""path"": ""<Keyboard>/backquote"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Quit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4be489d0-b2d1-4a4f-b908-0ec0ebaa091c"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Quit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7670c284-8e8a-4e45-9f2a-14ac0aab8d23"",
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
                    ""id"": ""0fdb0a08-c9d7-41bc-a57f-871215928dec"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ed885576-1fb2-4072-b2bf-1a25bdc3077f"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6525a4b7-bf7a-4b68-be1f-d2e6bb926d6e"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""f1d9f2ce-0772-418b-b587-e7c4550f8996"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""16268c64-99c1-4cd1-a04c-1870e8601d7e"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""955b9e1d-4195-463a-bf0e-b2b99e2ea1e4"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3b88978b-3391-4103-b180-5e8903372c1c"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6996f661-eb5f-437c-8e9a-544480833d96"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""6c2acd72-ece6-4471-aea8-4e0491200e42"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e391d2d4-b16b-4200-8670-0f4d9e6bcccb"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""141b95f5-a28d-4fab-898d-4d7bcd3ffdc2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""064da361-ba68-4691-a9ad-cb8ec07de03b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a6ca6abb-7697-4973-b95f-f3d6c4817923"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // car
        m_car = asset.FindActionMap("car", throwIfNotFound: true);
        m_car_hMove = m_car.FindAction("hMove", throwIfNotFound: true);
        m_car_vMove = m_car.FindAction("vMove", throwIfNotFound: true);
        m_car_Accelerate = m_car.FindAction("Accelerate", throwIfNotFound: true);
        m_car_Reverse = m_car.FindAction("Reverse", throwIfNotFound: true);
        m_car_Restart = m_car.FindAction("Restart", throwIfNotFound: true);
        m_car_Quit = m_car.FindAction("Quit", throwIfNotFound: true);
        m_car_Pause = m_car.FindAction("Pause", throwIfNotFound: true);
        m_car_Shoot = m_car.FindAction("Shoot", throwIfNotFound: true);
        m_car_RotateCamera = m_car.FindAction("RotateCamera", throwIfNotFound: true);
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

    // car
    private readonly InputActionMap m_car;
    private ICarActions m_CarActionsCallbackInterface;
    private readonly InputAction m_car_hMove;
    private readonly InputAction m_car_vMove;
    private readonly InputAction m_car_Accelerate;
    private readonly InputAction m_car_Reverse;
    private readonly InputAction m_car_Restart;
    private readonly InputAction m_car_Quit;
    private readonly InputAction m_car_Pause;
    private readonly InputAction m_car_Shoot;
    private readonly InputAction m_car_RotateCamera;
    public struct CarActions
    {
        private @CarControls m_Wrapper;
        public CarActions(@CarControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @hMove => m_Wrapper.m_car_hMove;
        public InputAction @vMove => m_Wrapper.m_car_vMove;
        public InputAction @Accelerate => m_Wrapper.m_car_Accelerate;
        public InputAction @Reverse => m_Wrapper.m_car_Reverse;
        public InputAction @Restart => m_Wrapper.m_car_Restart;
        public InputAction @Quit => m_Wrapper.m_car_Quit;
        public InputAction @Pause => m_Wrapper.m_car_Pause;
        public InputAction @Shoot => m_Wrapper.m_car_Shoot;
        public InputAction @RotateCamera => m_Wrapper.m_car_RotateCamera;
        public InputActionMap Get() { return m_Wrapper.m_car; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CarActions set) { return set.Get(); }
        public void SetCallbacks(ICarActions instance)
        {
            if (m_Wrapper.m_CarActionsCallbackInterface != null)
            {
                @hMove.started -= m_Wrapper.m_CarActionsCallbackInterface.OnHMove;
                @hMove.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnHMove;
                @hMove.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnHMove;
                @vMove.started -= m_Wrapper.m_CarActionsCallbackInterface.OnVMove;
                @vMove.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnVMove;
                @vMove.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnVMove;
                @Accelerate.started -= m_Wrapper.m_CarActionsCallbackInterface.OnAccelerate;
                @Accelerate.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnAccelerate;
                @Accelerate.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnAccelerate;
                @Reverse.started -= m_Wrapper.m_CarActionsCallbackInterface.OnReverse;
                @Reverse.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnReverse;
                @Reverse.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnReverse;
                @Restart.started -= m_Wrapper.m_CarActionsCallbackInterface.OnRestart;
                @Restart.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnRestart;
                @Restart.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnRestart;
                @Quit.started -= m_Wrapper.m_CarActionsCallbackInterface.OnQuit;
                @Quit.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnQuit;
                @Quit.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnQuit;
                @Pause.started -= m_Wrapper.m_CarActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnPause;
                @Shoot.started -= m_Wrapper.m_CarActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnShoot;
                @RotateCamera.started -= m_Wrapper.m_CarActionsCallbackInterface.OnRotateCamera;
                @RotateCamera.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnRotateCamera;
                @RotateCamera.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnRotateCamera;
            }
            m_Wrapper.m_CarActionsCallbackInterface = instance;
            if (instance != null)
            {
                @hMove.started += instance.OnHMove;
                @hMove.performed += instance.OnHMove;
                @hMove.canceled += instance.OnHMove;
                @vMove.started += instance.OnVMove;
                @vMove.performed += instance.OnVMove;
                @vMove.canceled += instance.OnVMove;
                @Accelerate.started += instance.OnAccelerate;
                @Accelerate.performed += instance.OnAccelerate;
                @Accelerate.canceled += instance.OnAccelerate;
                @Reverse.started += instance.OnReverse;
                @Reverse.performed += instance.OnReverse;
                @Reverse.canceled += instance.OnReverse;
                @Restart.started += instance.OnRestart;
                @Restart.performed += instance.OnRestart;
                @Restart.canceled += instance.OnRestart;
                @Quit.started += instance.OnQuit;
                @Quit.performed += instance.OnQuit;
                @Quit.canceled += instance.OnQuit;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @RotateCamera.started += instance.OnRotateCamera;
                @RotateCamera.performed += instance.OnRotateCamera;
                @RotateCamera.canceled += instance.OnRotateCamera;
            }
        }
    }
    public CarActions @car => new CarActions(this);
    public interface ICarActions
    {
        void OnHMove(InputAction.CallbackContext context);
        void OnVMove(InputAction.CallbackContext context);
        void OnAccelerate(InputAction.CallbackContext context);
        void OnReverse(InputAction.CallbackContext context);
        void OnRestart(InputAction.CallbackContext context);
        void OnQuit(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnRotateCamera(InputAction.CallbackContext context);
    }
}
