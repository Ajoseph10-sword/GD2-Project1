using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EhScript11 : MonoBehaviour
{
    public TextMeshProUGUI hellsparadise;
    public TextMeshProUGUI gatorade;
    public TextMeshProUGUI kicks;
    public TextMeshProUGUI haitianhenry;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hellsparadise.text = "Is Goku really a bad dad?";
        gatorade.text = "Yes";
        kicks.text = "No";
        WhateverScript.Score = 4;
    }

    // Update is called once per frame
    public void OpenScene()
    {
        SceneManager.LoadScene("Incorrect1-3");
    }

    public float TimerZ = 10;

    void Update()
    {
        TimerZ -= Time.deltaTime;
        haitianhenry.text = "Time: " + TimerZ.ToString("0.0");
        if (TimerZ <= 0)
        {
            SceneManager.LoadScene("Times Up7-3-3");
        }

    }

}