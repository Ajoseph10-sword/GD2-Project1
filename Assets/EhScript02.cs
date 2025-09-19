using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EhScript02 : MonoBehaviour
{
    public TextMeshProUGUI striker;
    public TextMeshProUGUI ninja;
    public TextMeshProUGUI batman;
    public TextMeshProUGUI fried;
    public TextMeshProUGUI hatred;
    public TextMeshProUGUI joker;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        striker.text = " How many colonies were there in America?";
        ninja.text = "18";
        batman.text = "7";
        fried.text = "13";
        hatred.text = "10";
        WhateverScript.Score = 3;
    }

    // Update is called once per frame
    public void OpenScene()
    {
        SceneManager.LoadScene("Incorrect2-3");
    }

    public float TimerS = 10;

    void Update()
    {
        TimerS -= Time.deltaTime;
        joker.text = "Time: " + TimerS.ToString("0.0");
        if (TimerS <= 0)
        {
            SceneManager.LoadScene("Times Up8-1");
        }

    }

}
