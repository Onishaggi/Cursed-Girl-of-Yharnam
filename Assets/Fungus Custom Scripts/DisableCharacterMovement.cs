using Fungus;
using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[CommandInfo("Custom","Disable Player Movement","Disables player movement to we can interact with the dialouge")]
[AddComponentMenu("")]
public class DisableCharacterMovement : Command
{
    private GameManager _gameManager;
    private GameObject _playerGO;
    private StarterAssetsInputs _starterAssetsInput;
    private ThirdPersonController _thirdPersonController;
    private Animator _animator;
    private PlayerInput _playerInput;

    
    // Start is called before the first frame update
    void Start()
    {
        _gameManager = ServiceLocator.Instance.GetService<GameManager>();
        _playerGO = _gameManager.PlayerGO;
        _starterAssetsInput = _playerGO.GetComponent<StarterAssetsInputs>();
        _thirdPersonController= _playerGO.GetComponent<ThirdPersonController>();
        _animator = _playerGO.GetComponent<Animator>();
        _playerInput = _playerGO.GetComponent<PlayerInput>();
    }
    public override void OnEnter()
    {
        
        base.OnEnter();
        Debug.Log(_playerGO.name);
        _starterAssetsInput.cursorLocked = false;
        _starterAssetsInput.cursorInputForLook = false;
        Cursor.lockState = CursorLockMode.Confined;
        //_thirdPersonController.enabled = false;
        //_animator.enabled = false;
        _playerInput.enabled = false;
        Continue();
    }
    public override string GetSummary()
    {
        return base.GetSummary();
    }

    public override Color GetButtonColor()
    {
        return base.GetButtonColor();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
