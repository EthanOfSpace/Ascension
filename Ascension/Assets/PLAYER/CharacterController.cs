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

    // The character controller will have its functinality split into states

    // The current state will be controlled by a state machine

    // If COMPUTER GAME DEVELOPMENT is the INTERSECTION of ART || TECHNOLOGY || DESIGN
    
    // I need to consider how to translate my GAME DESIGN DOCUMENTS into GAME PROGRAMMING DOCUMENTS 

    // The purpose of these GAME PROGRAMMING DOCUMENTS is so that when it comes time for me or someone else to IMPLEMENT the GAME DESIGN

    // They have a GUIDE that lets them know what the REQUIREMENTS of the GAME DESIGN entail, and a RECCOMENDED way of IMPLEMENTING the DESIGN


  


}
