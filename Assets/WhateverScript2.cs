using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WhateverScript2 : MonoBehaviour
{
    public TextMeshProUGUI QP2;
    public TextMeshProUGUI Answer5;
    public TextMeshProUGUI Answer6;
    public TextMeshProUGUI Answer7;
    public TextMeshProUGUI Answer8;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        QP2.text = "In WWII, the alliance of Germany, Italy, and Japan is known as?";
        Answer5.text = "Angry Countries of War";
        Answer6.text = "Germa-Italia-Japan Alliance";
        Answer7.text = "Axis Powers";
        Answer8.text = "The Losers Club";
    }

    // Update is called once per frame
    public void OpenScene()
    {
        SceneManager.LoadScene("Incorrect2-1");
    }

    public float Timer = 20;

    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            SceneManager.LoadScene("Times Up2");
        }
    }
}
