using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EhScript12 : MonoBehaviour
{
    public TextMeshProUGUI shoryukant;
    public TextMeshProUGUI dan;
    public TextMeshProUGUI sean;
    public TextMeshProUGUI rose;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shoryukant.text = " Did Marie Antoinette really say 'Let them eat cake?'";
        dan.text = "I'm not sure";
        sean.text = "Probably yes";
        WhateverScript.Score = 4;
    }

    // Update is called once per frame
    public void OpenScene()
    {
        SceneManager.LoadScene("Incorrect2-3");
    }

    public float Timer6 = 10;

    void Update()
    {
        Timer6 -= Time.deltaTime;
        rose.text = "Time: " + Timer6.ToString("0.0");
        if (Timer6 <= 0)
        {
            SceneManager.LoadScene("Times Up8-2");
        }

    }

}