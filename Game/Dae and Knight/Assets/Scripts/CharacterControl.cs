using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    // Store reference to GameManager
    private GameManager gameManager;

    // Store reference to CharacterController
    public CharacterController2D controller;

    // Store movement speed
    private float moveSpeed;

    private float horizontalMove = 0f;

    // Store reference to Knight
    [SerializeField]
    private GameObject knight;

    // Store reference to Dae
    [SerializeField]
    private GameObject dae;

    /// <summary>
    /// Get and set moveSpeed
    /// </summary>
    public float MoveSpeed
    {
        get { return moveSpeed; }
        set { moveSpeed = value; }
    }

    /// <summary>
    /// Start is called before the first frame
    /// </summary>
    void Start()
    {
        // Intantiate gameManager
        gameManager = FindObjectOfType<GameManager>();

        // Initialise moveSpeed
        moveSpeed = 0.3f;
    }

    /// <summary>
    /// Update is called every frame
    /// </summary>
    void Update()
    {
        KeyboardInput();

        horizontalMove = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.fixedDeltaTime;
    }

    /// <summary>
    /// Handle keyboard input
    /// </summary>
    private void KeyboardInput()
    {
        // If W is pressed
        if (Input.GetKeyDown(KeyCode.W))
        {
            // If state is day
            if (gameManager.CheckState() == GameManager.GameState.Day)
            {
                // Move Dae up
                dae.transform.position = new Vector2(dae.transform.position.x, dae.transform.position.y + moveSpeed);
            }

            // If state is night
            if (gameManager.CheckState() == GameManager.GameState.Night)
            {
                // Move Knight up
                knight.transform.position = new Vector2(knight.transform.position.x, knight.transform.position.y + moveSpeed);
            }
        }

        // If A is pressed
        if (Input.GetKeyDown(KeyCode.A))
        {
            // If state is day
            if (gameManager.CheckState() == GameManager.GameState.Day)
            {
                // Move Dae to the left
                dae.transform.position = new Vector2(dae.transform.position.x - moveSpeed, dae.transform.position.y);
            }

            // If state is night
            if (gameManager.CheckState() == GameManager.GameState.Night)
            {
                // Move Knight to the left
                knight.transform.position = new Vector2(knight.transform.position.x - moveSpeed, knight.transform.position.y);
            }
        }

        // If S is pressed
        if (Input.GetKeyDown(KeyCode.S))
        {
            // If state is day
            if (gameManager.CheckState() == GameManager.GameState.Day)
            {
                // Move Dae down
                dae.transform.position = new Vector2(dae.transform.position.x, dae.transform.position.y - moveSpeed);
            }

            if (gameManager.CheckState() == GameManager.GameState.Night)
            {
                // Move Knight down
                knight.transform.position = new Vector2(knight.transform.position.x, knight.transform.position.y - moveSpeed);
            }
        }

        // If D is pressed
        if (Input.GetKeyDown(KeyCode.D))
        {
            // If state is day
            if (gameManager.CheckState() == GameManager.GameState.Day)
            {
                // Move Dae right
                dae.transform.position = new Vector2(dae.transform.position.x + moveSpeed, dae.transform.position.y);
            }

            // If state is night
            if (gameManager.CheckState() == GameManager.GameState.Night)
            {
                // Move Knight right
                knight.transform.position = new Vector2(knight.transform.position.x + moveSpeed, knight.transform.position.y);
            }
        }

        // If E is pressed
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Change state to day
            gameManager.ChangeState(KeyCode.E);
        }

        // If Q is pressed
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // Change state to night
            gameManager.ChangeState(KeyCode.Q);
        }
    }
}