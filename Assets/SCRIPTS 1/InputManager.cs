using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public PlayerControls playerControl;
    public Vector2 movementinput;
    public float VerticalInput;
    public float HorizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEnable()
    {
       if (playerControl != null)
        {
            playerControl = new PlayerControls();
            //ME WHEN WASD:
            playerControl.playerControl.WASD.performed += i => movementinput = i.ReadValue<Vector2>();
        }
    }

    public void OnDisable()
    {

    }
}
