using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MainScenePlayer : MonoBehaviour
{
    public GameObject Image, Absorb, Particle1, Particle2, Particle3, Particle4, Particle5, Particle6;
    public Animator Rotate;

    // public void SingleHit(InputAction.CallbackContext context)
    // {
    //     if (context.phase == InputActionPhase.Performed)
    //     {
    //         Instantiate(Particle1, new Vector3(Random.Range(-1, 1), 0, 0), Quaternion.identity);
    //     }
    // }

    public void LongPress(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Destroy(Particle1);
            Destroy(Particle2);
            Destroy(Particle3);
            Destroy(Particle4);
            Destroy(Particle5);
            Destroy(Particle6);
            Rotate.SetTrigger("LongPressed");
            Absorb.SetActive(true);
        }
        if (context.canceled)
        {
            Destroy(Absorb);
            Image.SetActive(true);
        }
    }
}
