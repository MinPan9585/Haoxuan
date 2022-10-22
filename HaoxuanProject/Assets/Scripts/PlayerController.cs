using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private bool pressHeld = false;
    public Animator playereAnim;
    public int health = 10;
    public GameObject haloSuccess;

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

            Collider2D[] nearbyEnemies = Physics2D.OverlapCircleAll(Vector2.zero, 6f);
            if (nearbyEnemies.Length >= 1)
            {
                Destroy(nearbyEnemies[0].gameObject);
                Instantiate(haloSuccess, Vector3.zero, Quaternion.identity);
            }


            //Debug.Log("you hit screen once...");
        }
    }

    public void LongPress(InputAction.CallbackContext context)
    {
        //大敌人
        if (context.canceled && pressHeld)
        {
            //执行攻击
            pressHeld = false;
        }
    }
}
