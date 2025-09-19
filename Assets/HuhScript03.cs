using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HuhScript03 : MonoBehaviour
{
    public TextMeshProUGUI QP2_2;
    public TextMeshProUGUI Answer49;
    public TextMeshProUGUI Answer50;
    public TextMeshProUGUI Answer51;
    public TextMeshProUGUI Answer52;
    public TextMeshProUGUI kizaru;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        QP2_2.text = "Who was the first Smash Bros. DLC Character?";
        Answer49.text = "Ryu";
        Answer50.text = "Mewtwo";
        Answer51.text = "Joker";
        Answer52.text = "Piranha Plant";
        WhateverScript.Score = 2;
    }

    public void OpenScene()
    {
        SceneManager.LoadScene("Incorrect3-2-2");
    }
    public float Timer = 10;

    void Update()
    {
        Timer -= Time.deltaTime;
        kizaru.text = "Time. " + Timer.ToString("0.0");
        if (Timer <= 0)
        {
            SceneManager.LoadScene("Times Up6-2");
        }
    }
}
