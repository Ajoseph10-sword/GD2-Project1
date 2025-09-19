using UnityEngine;
using UnityEngine.SceneManagement;

public class marijuana : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OpenScene()
    {
        SceneManager.LoadScene("Correct2-2-2");
        WhateverScript.Score++;
    }
}
