using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Threading;

public class EhScript2 : MonoBehaviour
{
    public TextMeshProUGUI histori;
    public TextMeshProUGUI war1;
    public TextMeshProUGUI war2;
    public TextMeshProUGUI war3;
    public TextMeshProUGUI war4;
    public TextMeshProUGUI tldr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        histori.text = "Which one of these Caribbean countries was not colonized by Great Britain?";
        war1.text = "Jamaica";
        war2.text = "Barbados";
        war3.text = "Haiti";
        war4.text = "Trinidad";
        WhateverScript.Score = 2;
    }

    public void OpenScene()
    {
        SceneManager.LoadScene("Incorrect2-3");
    }
    public float Timer88 = 15;
    // Update is called once per frame
    void Update()
    {
        Timer88 -= Time.deltaTime;
        tldr.text = "Timer." + Timer88.ToString("0.0");
        if (Timer88 <= 0)
        {
            SceneManager.LoadScene("Times Up8");
        }
    }
}
