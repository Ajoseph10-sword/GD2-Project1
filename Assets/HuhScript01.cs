using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HuhScript01 : MonoBehaviour
{
    public TextMeshProUGUI QP2_2;
    public TextMeshProUGUI Answer41;
    public TextMeshProUGUI Answer42;
    public TextMeshProUGUI Answer43;
    public TextMeshProUGUI Answer44;
    public TextMeshProUGUI dandadans2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        QP2_2.text = "Which technique did Son Goku create in Dragon Ball?";
        Answer41.text = "Rock-Paper-Scissors";
        Answer42.text = "None. Dragon Fist non-canon";
        Answer43.text = "Kaio-ken";
        Answer44.text = "Kamehameha";
        WhateverScript.Score = 2;
    }

    public void OpenScene()
    {
        SceneManager.LoadScene("Incorrect1-2");
    }
    public float Timer = 10;

    void Update()
    {
        Timer -= Time.deltaTime;
        dandadans2.text = "Time. " + Timer.ToString("0.0");
        if (Timer <= 0)
        {
            SceneManager.LoadScene("Times Up4");
        }
    }
}