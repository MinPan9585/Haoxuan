using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private bool pressHeld = false;
    public Animator playereAnim;
    public int health = 10;

    public void LoseHealth()
    {
        health -= 1;
    }

    void Update()
    {
        if (health == 0)
        {
            //play dead;
        }
    }

    public void SingleHit(InputAction.CallbackContext context)
    {
        //查找附近小敌人tag的object，执行销毁，播放特效，音效，得分（距离判断）
        if (context.phase == InputActionPhase.Performed)
        {
            //执行攻击
            playereAnim.SetTrigger("hit");
            AudioManager.instance.PlaySoundFX();

            Debug.Log("you hit screen once...");
        }
    }

    public void LongPress(InputAction.CallbackContext context)
    {
        //大敌人
        if (context.performed)
        {
            Debug.Log("you long pressed screen once");
            pressHeld = true;
        }
        if (context.canceled && pressHeld)
        {
            //执行攻击
            pressHeld = false;
        }
    }
}
