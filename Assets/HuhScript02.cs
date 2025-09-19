using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HuhScript02 : MonoBehaviour
{
    public TextMeshProUGUI QP67;
    public TextMeshProUGUI Answer45;
    public TextMeshProUGUI Answer46;
    public TextMeshProUGUI Answer47;
    public TextMeshProUGUI Answer48;
    public TextMeshProUGUI davyjones;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        QP67.text = "What was the true purpose of the War On Drugs?";
        Answer45.text = "To criminalize drugs";
        Answer46.text = "Put colored communities in poverty";
        Answer47.text = "Reduce illegal drug trade in the U.S.";
        Answer48.text = "To allow more drug use";
        WhateverScript.Score = 2;
    }

    public void OpenScene()
    {
        SceneManager.LoadScene("Incorrect2-2-2");
    }
    public float Timer0 = 10;

    void Update()
    {
        Timer0 -= Time.deltaTime;
        davyjones.text = "Time. " + Timer0.ToString("0.0");
        if (Timer0 <= 0)
        {
            SceneManager.LoadScene("Times Up4-2");
        }
    }
}