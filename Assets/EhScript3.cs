using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Threading;

public class EhScript3 : MonoBehaviour
{
    public TextMeshProUGUI mellorine;
    public TextMeshProUGUI love1;
    public TextMeshProUGUI love2;
    public TextMeshProUGUI love3;
    public TextMeshProUGUI love4;
    public TextMeshProUGUI ero;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mellorine.text = "Who won the Console Wars?";
        love1.text = "Xbox";
        love2.text = "Playstation";
        love3.text = "No clear winner";
        love4.text = "Nintendo";
        WhateverScript.Score = 2;
    }

    public void OpenScene()
    {
        SceneManager.LoadScene("Incorrect3-3");
    }
    public float Timey = 15;
    // Update is called once per frame
    void Update()
    {
        Timey -= Time.deltaTime;
        ero.text = "Timer. " + Timey.ToString("0.0");
        if (Timey <= 0)
        {
            SceneManager.LoadScene("Times Up9");
        }
    }  
    
    }
