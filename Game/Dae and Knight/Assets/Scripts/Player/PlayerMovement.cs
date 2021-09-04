using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Members
    [Header("References")]

    public GameManager gameManager;
    public CharacterController2D controller;

    //-----------------------------------------\\

    [SerializeField]
    private float horizontalMove;

    #endregion
    // Start is called before the first frame update
    void Start()
    {
        horizontalMove = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove, false, false);
    }

    private void GetInput()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");
    }
}
