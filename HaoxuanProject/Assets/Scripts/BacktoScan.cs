using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BacktoScan : MonoBehaviour
{
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(SwitchScene);
    }

    void SwitchScene()
    {
        SceneManager.LoadScene("MainScene1020");
    }
}
