using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : Character
{
    [SerializeField]
    Texture2D cursorImage;

    [SerializeField]
    TrailRenderer playerTrail;

    [SerializeField]
    SpriteRenderer playerSprite;


    public void Awake()
    {
        setHealth(100);
    }

    public override void FixedUpdate()
    {
        MoveCursor(cursorImage);
    }


    void MoveCursor(Texture2D cursorImage) 
    {
        Cursor.SetCursor(cursorImage, Vector2.zero, CursorMode.ForceSoftware);
    }
    
    public const float zAxisSpeed = 20.0f;
    public const float xAxisSpeed = 20.0f;

    void Update()
    {
        // Multiply this objects X and Z axies by the players speed variables for the related axis

        float zAxis = Input.GetAxis("Vertical") * zAxisSpeed;
        float xAxis = Input.GetAxis("Horizontal") * xAxisSpeed;

        // Make this object move independant of frame rate

        zAxis *= Time.deltaTime;
        xAxis *= Time.deltaTime;

        // translate this object along the z-axis and x-axis by using the players speed variables

        transform.Translate(xAxis, 0, zAxis);

        // ACTIVATE TRAIL

        // if right mouse button is held down, the player leaves a trail

        // else the trail is not there

        // FLIPPING SPRITE

        if (xAxis < 0)
        {
            playerSprite.flipX = true;
        }
        else if(xAxis > 0)
        {
            playerSprite.flipX = false;
        }

    }

    // The CHARACTER CONTROLLER will have its functinality split into states and be controlled by a state machine

}
