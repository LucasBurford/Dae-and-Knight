using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class GameManager : MonoBehaviour
{
    #region Members
    [Header("Gameplay")]

    // Store reference to mainLight
    public Light2D mainLight;

    // Enum to store game state, night or day
    public enum GameState
    {
        Day,
        Night
    }
    // Access enum
    public GameState gameState;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        // Initialise the game state to night, as we start out as the knight
        gameState = GameState.Day;
    }

    // Update is called once per frame
    void Update()
    {
        CheckState();
    }

    /// <summary>
    /// Check gameState every frame and act accordingly
    /// </summary>
    public GameState CheckState()
    {
        // If state is day, keep mainLight on
        if (gameState == GameState.Day)
        {
            mainLight.enabled = true;
        }
        else
        {
            mainLight.enabled = false;
        }

        return gameState;
    }

    /// <summary>
    /// Change the state of the game
    /// </summary>
    public void ChangeState(KeyCode key)
    {
        // If Q is passed through (pressed)
        if (key == KeyCode.Q)
        {
            // Change the state to night
            gameState = GameState.Night;
        }

        // If E is passed through (pressed)
        if (key == KeyCode.E)
        {
            // Change the state to day
            gameState = GameState.Day;
        }
    }
}
