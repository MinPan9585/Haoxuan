using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Investigation : MonoBehaviour
{
    public GameObject bg1, bg2, text1, text2, failImage, failText, act2Button, failButton;
    public Sprite buttonWhite, buttonBlue;
    int successRate = 20;

    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(Judge);
        //successRate = skillPoint;
    }

    void Judge()
    {
        this.GetComponent<Image>().sprite = buttonWhite;
        Invoke("SwitchBackToBlue", 0.1f);

        int randomNum = Random.Range(1, 101);
        if (randomNum <= successRate)
        {
            //success
            bg1.SetActive(false);
            text1.SetActive(false);
            bg2.SetActive(true);
            text2.SetActive(true);
            act2Button.SetActive(true);
        }
        else
        {
            //failure
            failButton.SetActive(true);
        }
    }

    void SwitchBackToBlue()
    {
        this.GetComponent<Image>().sprite = buttonBlue;
        this.gameObject.SetActive(false);
    }
}
