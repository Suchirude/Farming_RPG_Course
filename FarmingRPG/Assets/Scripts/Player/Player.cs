using UnityEngine;

public class Player : SingletonMonobehaviour<Player>
{
    //Movement Parameters
    float xInput; 
    float yInput; 
    bool isWalking; 
    bool isRunning; 
    bool isIdle; 
    bool isCarrying = false;
    bool isUsingToolRight; 
    bool isUsingToolLeft; 
    bool isUsingToolUp; 
    bool isUsingToolDown;
    bool isLiftingToolRight; 
    bool isLiftingToolLeft; 
    bool isLiftingToolUp; 
    bool isLiftingToolDown;
    bool isPickingRight; 
    bool isPickingLeft; 
    bool isPickingUp; 
    bool isPickingDown;
    bool isSwingingToolRight; 
    bool isSwingingToolLeft; 
    bool isSwingingToolUp; 
    bool isSwingingToolDown;
    bool idleUp; 
    bool idleDown; 
    bool idleLeft;
    bool idleRight;
    ToolEffect toolEffect = ToolEffect.none;

    private Rigidbody2D rigidBody;

    private Direction playerDirection;

    private float movementSpeed;

    private bool _playerInputIsDisabled = false;

    public bool PlayerInputIsDisabled { get => _playerInputIsDisabled; set => _playerInputIsDisabled = false; }

    protected override void Awake()
    {
        base.Awake();

        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        #region Player Input

        ResetAnimationTriggers();

        PlayerMovementInput();

        #endregion
    }

    private void ResetAnimationTriggers()
    {
        isUsingToolRight = false;
        isUsingToolLeft = false;
        isUsingToolUp = false;
        isUsingToolDown = false;
        isLiftingToolRight = false;
        isLiftingToolLeft = false;
        isLiftingToolUp = false;
        isLiftingToolDown = false;
        isPickingRight = false;
        isPickingLeft = false;
        isPickingUp = false;
        isPickingDown = false;
        isSwingingToolRight = false;
        isSwingingToolLeft = false;
        isSwingingToolUp = false;
        isSwingingToolDown = false;
        toolEffect = ToolEffect.none;
    }

    private void PlayerMovementInput()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");
    }
}
