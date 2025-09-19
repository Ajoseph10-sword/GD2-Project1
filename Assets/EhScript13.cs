using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EhScript13 : MonoBehaviour
{
    public TextMeshProUGUI squish;
    public TextMeshProUGUI swoosh;
    public TextMeshProUGUI bang;
    public TextMeshProUGUI fizz;
    public TextMeshProUGUI press;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        squish.text = " Can video games good movie adaptations?";
        swoosh.text = "Yes";
        bang.text = "No";
        fizz.text = "Depends on the game";
        WhateverScript.Score = 4;
    }

    // Update is called once per frame
    public void OpenScene()
    {
        SceneManager.LoadScene("Incorrect3-3");
    }

    public float TimerS = 10;

    void Update()
    {
        TimerS -= Time.deltaTime;
        press.text = "Time: " + TimerS.ToString("0.0");
        if (TimerS <= 0)
        {
            SceneManager.LoadScene("Times Up8-1");
        }

    }

}