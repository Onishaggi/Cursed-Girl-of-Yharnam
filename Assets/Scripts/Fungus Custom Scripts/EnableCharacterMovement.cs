using Fungus;
using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[CommandInfo("Custom", "Enable Player Movement", "Enables player movement back when we end the Dialoge")]
[AddComponentMenu("")]
public class EnableCharacterMovement : Command
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
        _thirdPersonController = _playerGO.GetComponent<ThirdPersonController>();
        _animator = _playerGO.GetComponent<Animator>();
        _playerInput = _playerGO.GetComponent<PlayerInput>();
       
    }
    public override void OnEnter()
    {

        base.OnEnter();
        Debug.Log(_playerGO.name);
        _starterAssetsInput.cursorLocked = true;
        _starterAssetsInput.cursorInputForLook = true;
        Cursor.lockState = CursorLockMode.Locked;
        //_thirdPersonController.enabled = enabled;
        //_animator.enabled = enabled;
        _playerInput.enabled = true;
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
