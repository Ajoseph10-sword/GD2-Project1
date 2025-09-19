using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EhScript01 : MonoBehaviour
{
    public TextMeshProUGUI besto_friendo;
    public TextMeshProUGUI bruv;
    public TextMeshProUGUI amigo;
    public TextMeshProUGUI friere;
    public TextMeshProUGUI buddy;
    public TextMeshProUGUI fantastic;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        besto_friendo.text = "Captain Crackhead and his crew of teenage terrorists fight the government to save their chaperone. Which One Piece arc is this?";
        bruv.text = "Thriller Bark";
        amigo.text = "Whole Cake Island";
        friere.text = "Skypiea";
        buddy.text = "Enies Lobby";
        WhateverScript.Score = 3;
    }

    // Update is called once per frame
    public void OpenScene()
    {
        SceneManager.LoadScene("Incorrect1-3");
    }

    public float Timer3 = 10;

    void Update()
    {
        Timer3 -= Time.deltaTime;
        fantastic.text = "Time: " + Timer3.ToString("0.0");
        if (Timer3 <= 0)
        {
            SceneManager.LoadScene("Times Up7-3-1");
        }

    }

}