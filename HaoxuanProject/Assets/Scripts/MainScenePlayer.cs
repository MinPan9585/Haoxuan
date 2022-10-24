using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MainScenePlayer : MonoBehaviour
{
    public void SingleHit(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            //destroy particle systems in the scene
            //Instantiate(particlePrefab, new Vector3(Random.Range(-1,1),0,0), Quaternion.identity);
        }
    }

    public void LongPress(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            //play particles
            //stop particles
            //play circle animation
        }
        if (context.canceled)
        {
            //stop particles
            //UI image set active
        }
    }
}
