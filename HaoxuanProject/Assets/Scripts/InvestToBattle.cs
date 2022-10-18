using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InvestToBattle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(FromInvestToBatte);
    }

    void FromInvestToBatte()
    {
        SceneManager.LoadScene("BattleScene1018");
    }
}
