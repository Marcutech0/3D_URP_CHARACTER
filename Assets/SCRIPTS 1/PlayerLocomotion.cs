using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocomotion : MonoBehaviour
{

    private Vector3 movedirection;
    Transform cameraObject;
    public void HandlesAllMovement()
    {
        HandlesRotation();
        HandlesMovement();
    }
    private void HandlesMovement()
    {
        movedirection = cameraObject.forward * PlayerManager.Instance.inputManager.VerticalInput;
    }
    private void HandlesRotation()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        cameraObject = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
