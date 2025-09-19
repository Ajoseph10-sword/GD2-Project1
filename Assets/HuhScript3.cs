using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Threading;

public class HuhScript3 : MonoBehaviour
{
    public TextMeshProUGUI TheHero;
    public TextMeshProUGUI fw1;
    public TextMeshProUGUI fw2;
    public TextMeshProUGUI fw3;
    public TextMeshProUGUI fw4;
    public TextMeshProUGUI EVO37;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TheHero.text = "Which one of these gaming characters are not from an indie company?";
        fw1.text = "Cuphead";
        fw2.text = "Sack-Boy";
        fw3.text = "Sans";
        fw4.text = "Shovel Knight";
        WhateverScript.Score = 0;
    }
    
    public void OpenScene()
    {
        SceneManager.LoadScene("Incorrect3-2");
    }
    public float Timer = 15;
    // Update is called once per frame
    void Update()
    {
      Timer -= Time.deltaTime;
        EVO37.text = "Timer." + Timer.ToString("0.0");
        if (Timer <= 0) 
        {
            SceneManager.LoadScene("Times Up6");
        }
    }
}
