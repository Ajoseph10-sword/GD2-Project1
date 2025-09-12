using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WhateverScript : MonoBehaviour
{
    public TextMeshProUGUI Title;
    public TextMeshProUGUI Answer1;
    public TextMeshProUGUI Answer2;
    public TextMeshProUGUI Answer3;
    public TextMeshProUGUI Answer4;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Title.text = "In the anime One Piece, what is the ephitet of Monkey D. Luffy?";
        Answer1.text = "Straw Hat";
        Answer2.text = "Rubber Man";
        Answer3.text = "Joy Boy";
        Answer4.text = "Pirate Goku";

    }

    // Update is called once per frame
    public void OpenScene()
    {
        SceneManager.LoadScene("Incorrect1");
    }

    public float Timer = 20;

    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            SceneManager.LoadScene("Times Up1");
        }
    }
}