using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CountdownTimer : MonoBehaviour
{
    public Text txtTimer;
    public float second;

    private void Start()
    {
        // 1.�����������
        txtTimer = this.GetComponent<Text>();
        // �ظ����ã���ִ�еķ������ƣ���һ��ִ��ʱ�䣬ÿ��ִ�м��ʱ�䣩
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
                // ȡ������
                CancelInvoke("Timer");
            }
        }
    }
}