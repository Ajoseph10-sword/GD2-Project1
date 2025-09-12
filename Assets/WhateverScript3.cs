using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WhateverScript3 : MonoBehaviour
{
    public TextMeshProUGUI QP3;
    public TextMeshProUGUI Answer9;
    public TextMeshProUGUI Answer10;
    public TextMeshProUGUI Answer11;
    public TextMeshProUGUI Answer12;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        QP3.text = "Which gaming company created the Devil May Cry series";
        Answer9.text = "Activision";
        Answer10.text = "Capcom";
        Answer11.text = "Nintendo";
        Answer12.text = "Ubisoft";
    }

    // Update is called once per frame
    public void OpenScene()
    {
        SceneManager.LoadScene("Incorrect3-1");
    }
}
