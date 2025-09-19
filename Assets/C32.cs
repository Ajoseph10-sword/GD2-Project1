using UnityEngine;
using UnityEngine.SceneManagement;

public class C32 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OpenScene()
    {
        SceneManager.LoadScene("Door 3 - Level 2 Part 2");
        WhateverScript.Score++;
    }
}
