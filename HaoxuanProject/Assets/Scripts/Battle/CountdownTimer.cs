using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public TMP_Text txtTimer;
    public float second;

    private void Start()
    {
        txtTimer = this.GetComponent<TMP_Text>();
        InvokeRepeating("Timer", 1, 1);
    }

    private void Timer()
    {
        second = second - 1;
        txtTimer.text = string.Format("{0:d2}:{1:d2}", (int)second / 60, (int)second % 60);

        if (second <= 3)
        {
            txtTimer.color = Color.red;
            if (second <= 0)
            {
                CancelInvoke("Timer");
            }
        }
    }
}