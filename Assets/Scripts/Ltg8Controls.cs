//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Misc/ltg8_controls.inputactions
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

public partial class @Ltg8Controls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Ltg8Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ltg8_controls"",
    ""maps"": [
        {
            ""name"": ""GameplayCommon"",
            ""id"": ""0ccc083e-5f77-480c-bebe-6b509cefeef8"",
            ""actions"": [
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""d6d7e278-4b05-430f-806d-dad2201711ce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""a3edbee8-6170-4459-9b66-963d451b80ec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""383120c4-f7b9-4bfb-9831-fa0237b85ce8"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7bc5330d-7532-4174-937c-8eaa69473dca"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""33b50be7-11b8-4517-b5d1-df6d57374bc3"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""905af592-4463-4a98-b70c-17479ddf2147"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerFreeMovement"",
            ""id"": ""10831eb3-841c-4216-883b-b244c7f46d00"",
            ""actions"": [
                {
                    ""name"": ""MoveX"",
                    ""type"": ""Value"",
                    ""id"": ""ec4d88b0-d69d-45be-8aed-4d4fec0f7175"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveY"",
                    ""type"": ""Value"",
                    ""id"": ""72b57672-6e1b-4798-8ce0-bbd7cec388dd"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""LookX"",
                    ""type"": ""Value"",
                    ""id"": ""4cb9bb6a-7eb9-4227-a95c-3d60e00be11d"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""LookY"",
                    ""type"": ""Value"",
                    ""id"": ""56695006-5ec0-4569-ba28-4a908bb20fba"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""41cf576b-ce9c-4460-b227-da112d9a6d21"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""131bf255-aa28-41a8-b23d-dee334959042"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""363234a2-43c3-4d7f-876c-20326a142251"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ef9f42db-05b5-4bf0-a8b2-30548b2e9f75"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""644e8665-8d0b-4f0f-848b-c07d11679871"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""989609bf-6441-4fc5-ba86-b7a26c01683e"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WS"",
                    ""id"": ""cb630dde-3acb-482f-ae6b-4df6ebe251e5"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""dadeb5bd-1b09-4461-9d2e-675d6f927989"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9a5c2907-6068-4b51-9a27-e6a150bcf4e9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""AD"",
                    ""id"": ""7424e7f3-3acd-413b-a76d-c9e76db32cf6"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4c6d629b-55b2-4b4c-a2ec-5e385f04d31e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""4e549e31-a5ad-4f7e-ab63-3d46df4144b9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""cdb8dea3-a6d5-488e-9e56-1b51c586b866"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""LookX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""abd1a67d-738c-4cc2-a956-27330a14c090"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""LookY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerClimbingMovement"",
            ""id"": ""cd3b25df-de2e-4047-9ff3-e73a41b628e5"",
            ""actions"": [
                {
                    ""name"": ""MoveX"",
                    ""type"": ""Value"",
                    ""id"": ""c245d749-7cfb-44df-8589-d31a42f5dba9"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveY"",
                    ""type"": ""Value"",
                    ""id"": ""fbdbd933-0406-4188-b8a4-8cb23a02ef4c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""LookX"",
                    ""type"": ""Value"",
                    ""id"": ""0147b900-2443-44b6-8cb3-001b588e2474"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""LookY"",
                    ""type"": ""Value"",
                    ""id"": ""eeed2574-8ee7-4674-aae4-808b2f58c661"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""cde552da-957a-421a-98f7-784bd65bf56f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""8c41e8fd-3ffb-4530-9eca-e27b3d7acc8e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b1bf30e8-a6b9-4203-88c2-f2974c16a449"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ab404ac-d77b-485e-bf75-44dad841a282"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a6c44cb0-73eb-42ee-a982-e0859d4719db"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""LookX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c5af197e-5f2f-48a9-88b0-67fd8a94c700"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""LookY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WS"",
                    ""id"": ""546eaeff-ea91-4d07-9f91-9d4deac54bde"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""3898a054-1346-4fe9-9440-9284bc2cc4a0"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e675ad0f-6248-4315-ba8d-e5632135ca7f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""AD"",
                    ""id"": ""2b90811c-4556-4b8b-b897-bba28273dd10"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f9cc66ec-e85b-4962-aeb3-06a1bf8967e8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b0d58679-c2e3-4b0d-97ef-85a355771ed7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
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
        },
        {
            ""name"": ""Controller"",
            ""bindingGroup"": ""Controller"",
            ""devices"": []
        }
    ]
}");
        // GameplayCommon
        m_GameplayCommon = asset.FindActionMap("GameplayCommon", throwIfNotFound: true);
        m_GameplayCommon_Pause = m_GameplayCommon.FindAction("Pause", throwIfNotFound: true);
        m_GameplayCommon_Confirm = m_GameplayCommon.FindAction("Confirm", throwIfNotFound: true);
        // PlayerFreeMovement
        m_PlayerFreeMovement = asset.FindActionMap("PlayerFreeMovement", throwIfNotFound: true);
        m_PlayerFreeMovement_MoveX = m_PlayerFreeMovement.FindAction("MoveX", throwIfNotFound: true);
        m_PlayerFreeMovement_MoveY = m_PlayerFreeMovement.FindAction("MoveY", throwIfNotFound: true);
        m_PlayerFreeMovement_LookX = m_PlayerFreeMovement.FindAction("LookX", throwIfNotFound: true);
        m_PlayerFreeMovement_LookY = m_PlayerFreeMovement.FindAction("LookY", throwIfNotFound: true);
        m_PlayerFreeMovement_Jump = m_PlayerFreeMovement.FindAction("Jump", throwIfNotFound: true);
        m_PlayerFreeMovement_Sprint = m_PlayerFreeMovement.FindAction("Sprint", throwIfNotFound: true);
        m_PlayerFreeMovement_Interact = m_PlayerFreeMovement.FindAction("Interact", throwIfNotFound: true);
        // PlayerClimbingMovement
        m_PlayerClimbingMovement = asset.FindActionMap("PlayerClimbingMovement", throwIfNotFound: true);
        m_PlayerClimbingMovement_MoveX = m_PlayerClimbingMovement.FindAction("MoveX", throwIfNotFound: true);
        m_PlayerClimbingMovement_MoveY = m_PlayerClimbingMovement.FindAction("MoveY", throwIfNotFound: true);
        m_PlayerClimbingMovement_LookX = m_PlayerClimbingMovement.FindAction("LookX", throwIfNotFound: true);
        m_PlayerClimbingMovement_LookY = m_PlayerClimbingMovement.FindAction("LookY", throwIfNotFound: true);
        m_PlayerClimbingMovement_Jump = m_PlayerClimbingMovement.FindAction("Jump", throwIfNotFound: true);
        m_PlayerClimbingMovement_Interact = m_PlayerClimbingMovement.FindAction("Interact", throwIfNotFound: true);
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

    // GameplayCommon
    private readonly InputActionMap m_GameplayCommon;
    private List<IGameplayCommonActions> m_GameplayCommonActionsCallbackInterfaces = new List<IGameplayCommonActions>();
    private readonly InputAction m_GameplayCommon_Pause;
    private readonly InputAction m_GameplayCommon_Confirm;
    public struct GameplayCommonActions
    {
        private @Ltg8Controls m_Wrapper;
        public GameplayCommonActions(@Ltg8Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pause => m_Wrapper.m_GameplayCommon_Pause;
        public InputAction @Confirm => m_Wrapper.m_GameplayCommon_Confirm;
        public InputActionMap Get() { return m_Wrapper.m_GameplayCommon; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayCommonActions set) { return set.Get(); }
        public void AddCallbacks(IGameplayCommonActions instance)
        {
            if (instance == null || m_Wrapper.m_GameplayCommonActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameplayCommonActionsCallbackInterfaces.Add(instance);
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
            @Confirm.started += instance.OnConfirm;
            @Confirm.performed += instance.OnConfirm;
            @Confirm.canceled += instance.OnConfirm;
        }

        private void UnregisterCallbacks(IGameplayCommonActions instance)
        {
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
            @Confirm.started -= instance.OnConfirm;
            @Confirm.performed -= instance.OnConfirm;
            @Confirm.canceled -= instance.OnConfirm;
        }

        public void RemoveCallbacks(IGameplayCommonActions instance)
        {
            if (m_Wrapper.m_GameplayCommonActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameplayCommonActions instance)
        {
            foreach (var item in m_Wrapper.m_GameplayCommonActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameplayCommonActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameplayCommonActions @GameplayCommon => new GameplayCommonActions(this);

    // PlayerFreeMovement
    private readonly InputActionMap m_PlayerFreeMovement;
    private List<IPlayerFreeMovementActions> m_PlayerFreeMovementActionsCallbackInterfaces = new List<IPlayerFreeMovementActions>();
    private readonly InputAction m_PlayerFreeMovement_MoveX;
    private readonly InputAction m_PlayerFreeMovement_MoveY;
    private readonly InputAction m_PlayerFreeMovement_LookX;
    private readonly InputAction m_PlayerFreeMovement_LookY;
    private readonly InputAction m_PlayerFreeMovement_Jump;
    private readonly InputAction m_PlayerFreeMovement_Sprint;
    private readonly InputAction m_PlayerFreeMovement_Interact;
    public struct PlayerFreeMovementActions
    {
        private @Ltg8Controls m_Wrapper;
        public PlayerFreeMovementActions(@Ltg8Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveX => m_Wrapper.m_PlayerFreeMovement_MoveX;
        public InputAction @MoveY => m_Wrapper.m_PlayerFreeMovement_MoveY;
        public InputAction @LookX => m_Wrapper.m_PlayerFreeMovement_LookX;
        public InputAction @LookY => m_Wrapper.m_PlayerFreeMovement_LookY;
        public InputAction @Jump => m_Wrapper.m_PlayerFreeMovement_Jump;
        public InputAction @Sprint => m_Wrapper.m_PlayerFreeMovement_Sprint;
        public InputAction @Interact => m_Wrapper.m_PlayerFreeMovement_Interact;
        public InputActionMap Get() { return m_Wrapper.m_PlayerFreeMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerFreeMovementActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerFreeMovementActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerFreeMovementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerFreeMovementActionsCallbackInterfaces.Add(instance);
            @MoveX.started += instance.OnMoveX;
            @MoveX.performed += instance.OnMoveX;
            @MoveX.canceled += instance.OnMoveX;
            @MoveY.started += instance.OnMoveY;
            @MoveY.performed += instance.OnMoveY;
            @MoveY.canceled += instance.OnMoveY;
            @LookX.started += instance.OnLookX;
            @LookX.performed += instance.OnLookX;
            @LookX.canceled += instance.OnLookX;
            @LookY.started += instance.OnLookY;
            @LookY.performed += instance.OnLookY;
            @LookY.canceled += instance.OnLookY;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Sprint.started += instance.OnSprint;
            @Sprint.performed += instance.OnSprint;
            @Sprint.canceled += instance.OnSprint;
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
        }

        private void UnregisterCallbacks(IPlayerFreeMovementActions instance)
        {
            @MoveX.started -= instance.OnMoveX;
            @MoveX.performed -= instance.OnMoveX;
            @MoveX.canceled -= instance.OnMoveX;
            @MoveY.started -= instance.OnMoveY;
            @MoveY.performed -= instance.OnMoveY;
            @MoveY.canceled -= instance.OnMoveY;
            @LookX.started -= instance.OnLookX;
            @LookX.performed -= instance.OnLookX;
            @LookX.canceled -= instance.OnLookX;
            @LookY.started -= instance.OnLookY;
            @LookY.performed -= instance.OnLookY;
            @LookY.canceled -= instance.OnLookY;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Sprint.started -= instance.OnSprint;
            @Sprint.performed -= instance.OnSprint;
            @Sprint.canceled -= instance.OnSprint;
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
        }

        public void RemoveCallbacks(IPlayerFreeMovementActions instance)
        {
            if (m_Wrapper.m_PlayerFreeMovementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerFreeMovementActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerFreeMovementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerFreeMovementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerFreeMovementActions @PlayerFreeMovement => new PlayerFreeMovementActions(this);

    // PlayerClimbingMovement
    private readonly InputActionMap m_PlayerClimbingMovement;
    private List<IPlayerClimbingMovementActions> m_PlayerClimbingMovementActionsCallbackInterfaces = new List<IPlayerClimbingMovementActions>();
    private readonly InputAction m_PlayerClimbingMovement_MoveX;
    private readonly InputAction m_PlayerClimbingMovement_MoveY;
    private readonly InputAction m_PlayerClimbingMovement_LookX;
    private readonly InputAction m_PlayerClimbingMovement_LookY;
    private readonly InputAction m_PlayerClimbingMovement_Jump;
    private readonly InputAction m_PlayerClimbingMovement_Interact;
    public struct PlayerClimbingMovementActions
    {
        private @Ltg8Controls m_Wrapper;
        public PlayerClimbingMovementActions(@Ltg8Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveX => m_Wrapper.m_PlayerClimbingMovement_MoveX;
        public InputAction @MoveY => m_Wrapper.m_PlayerClimbingMovement_MoveY;
        public InputAction @LookX => m_Wrapper.m_PlayerClimbingMovement_LookX;
        public InputAction @LookY => m_Wrapper.m_PlayerClimbingMovement_LookY;
        public InputAction @Jump => m_Wrapper.m_PlayerClimbingMovement_Jump;
        public InputAction @Interact => m_Wrapper.m_PlayerClimbingMovement_Interact;
        public InputActionMap Get() { return m_Wrapper.m_PlayerClimbingMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerClimbingMovementActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerClimbingMovementActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerClimbingMovementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerClimbingMovementActionsCallbackInterfaces.Add(instance);
            @MoveX.started += instance.OnMoveX;
            @MoveX.performed += instance.OnMoveX;
            @MoveX.canceled += instance.OnMoveX;
            @MoveY.started += instance.OnMoveY;
            @MoveY.performed += instance.OnMoveY;
            @MoveY.canceled += instance.OnMoveY;
            @LookX.started += instance.OnLookX;
            @LookX.performed += instance.OnLookX;
            @LookX.canceled += instance.OnLookX;
            @LookY.started += instance.OnLookY;
            @LookY.performed += instance.OnLookY;
            @LookY.canceled += instance.OnLookY;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
        }

        private void UnregisterCallbacks(IPlayerClimbingMovementActions instance)
        {
            @MoveX.started -= instance.OnMoveX;
            @MoveX.performed -= instance.OnMoveX;
            @MoveX.canceled -= instance.OnMoveX;
            @MoveY.started -= instance.OnMoveY;
            @MoveY.performed -= instance.OnMoveY;
            @MoveY.canceled -= instance.OnMoveY;
            @LookX.started -= instance.OnLookX;
            @LookX.performed -= instance.OnLookX;
            @LookX.canceled -= instance.OnLookX;
            @LookY.started -= instance.OnLookY;
            @LookY.performed -= instance.OnLookY;
            @LookY.canceled -= instance.OnLookY;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
        }

        public void RemoveCallbacks(IPlayerClimbingMovementActions instance)
        {
            if (m_Wrapper.m_PlayerClimbingMovementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerClimbingMovementActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerClimbingMovementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerClimbingMovementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerClimbingMovementActions @PlayerClimbingMovement => new PlayerClimbingMovementActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_ControllerSchemeIndex = -1;
    public InputControlScheme ControllerScheme
    {
        get
        {
            if (m_ControllerSchemeIndex == -1) m_ControllerSchemeIndex = asset.FindControlSchemeIndex("Controller");
            return asset.controlSchemes[m_ControllerSchemeIndex];
        }
    }
    public interface IGameplayCommonActions
    {
        void OnPause(InputAction.CallbackContext context);
        void OnConfirm(InputAction.CallbackContext context);
    }
    public interface IPlayerFreeMovementActions
    {
        void OnMoveX(InputAction.CallbackContext context);
        void OnMoveY(InputAction.CallbackContext context);
        void OnLookX(InputAction.CallbackContext context);
        void OnLookY(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
    public interface IPlayerClimbingMovementActions
    {
        void OnMoveX(InputAction.CallbackContext context);
        void OnMoveY(InputAction.CallbackContext context);
        void OnLookX(InputAction.CallbackContext context);
        void OnLookY(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
}