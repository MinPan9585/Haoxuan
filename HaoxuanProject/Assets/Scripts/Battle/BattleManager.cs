using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public float gameDuration;
    public GameObject successPanel;
    public bool isGameOver = false;
    void Start()
    {
    }

    void Update()
    {
        gameDuration -= Time.deltaTime;
        if (gameDuration <= 0)
        {
            //gameover
            successPanel.SetActive(true);
            isGameOver = true;
        }
    }
}
