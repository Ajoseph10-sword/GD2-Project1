using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CorrectAnswer : MonoBehaviour
    
{
    public string Next= "Correct1-1";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }
    public void OpenScene()
    {
        WhateverScript.Score++;
        SceneManager.LoadScene(Next);
    }
}
