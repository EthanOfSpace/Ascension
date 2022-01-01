using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : Character
{

    public Texture2D cursorImage;


    public void Awake()
    {
        setHealth(100);
    }

    public override void FixedUpdate()
    {
        MovePlayerReticle(cursorImage);
    }


    void MovePlayerReticle(Texture2D cursorImage) 
    {
        Cursor.SetCursor(cursorImage, Vector2.zero, CursorMode.ForceSoftware);
    }
    
    public float zAxisSpeed = 5.0f;
    public float xAxisSpeed = 10.0f;

    void Update()
    {
        // Get the horizontal and vertical axis.

        float zAxis = Input.GetAxis("Vertical") * zAxisSpeed;
        float xAxis = Input.GetAxis("Horizontal") * xAxisSpeed;

        // Make it move independant of frame rate

        zAxis *= Time.deltaTime;
        xAxis *= Time.deltaTime;

        // translate this object along the z-axis and x-axis
        transform.Translate(xAxis, 0, zAxis);

    }

    // The CHARACTER CONTROLLER will have its functinality split into states

    // The current state will be controlled by a state machine

}
