using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        WhateverScript.Score = 0;  
    }

    // Update is called once per frame
    public void OpenScene()
    {
        SceneManager.LoadScene("Door Selection");
    }
}
