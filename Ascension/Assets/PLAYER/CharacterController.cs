using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{


    public Texture2D mousecursorImage;

    private void FixedUpdate()
    {
        Cursor.SetCursor(mousecursorImage, Vector2.zero, CursorMode.ForceSoftware);


    }

    // This character controller will have its functinality split into states

    // the current state will be controlled by a state machine


  


}
