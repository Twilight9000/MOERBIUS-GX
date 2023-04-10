//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/carControls.inputactions
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
    public struct CarActions
    {
        private @CarControls m_Wrapper;
        public CarActions(@CarControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @hMove => m_Wrapper.m_car_hMove;
        public InputAction @vMove => m_Wrapper.m_car_vMove;
        public InputAction @Accelerate => m_Wrapper.m_car_Accelerate;
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
            }
        }
    }
    public CarActions @car => new CarActions(this);
    public interface ICarActions
    {
        void OnHMove(InputAction.CallbackContext context);
        void OnVMove(InputAction.CallbackContext context);
        void OnAccelerate(InputAction.CallbackContext context);
    }
}
