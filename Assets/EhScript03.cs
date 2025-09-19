using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EhScript03 : MonoBehaviour
{
    public TextMeshProUGUI thirdstrike;
    public TextMeshProUGUI alex;
    public TextMeshProUGUI urien;
    public TextMeshProUGUI yun;
    public TextMeshProUGUI necro;
    public TextMeshProUGUI Q;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        thirdstrike.text = "Which EVO moment was so famous, it was referenced in Street Fighter III Online Editon?";
        alex.text = "54";
        urien.text = "03";
        yun.text = "37";
        necro.text = "19";
        WhateverScript.Score = 3;
    }

    // Update is called once per frame
    public void OpenScene()
    {
        SceneManager.LoadScene("Incorrect3-3");
    }

    public float TimerT = 10;

    void Update()
    {
        TimerT -= Time.deltaTime;
        Q.text = "Time: " + TimerT.ToString("0.0");
        if (TimerT <= 0)
        {
            SceneManager.LoadScene("Times Up9-1");
        }

    }

}
