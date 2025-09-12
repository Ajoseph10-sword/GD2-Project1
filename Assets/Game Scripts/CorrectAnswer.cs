using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CorrectAnswer : MonoBehaviour
    
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }
    public void OpenScene()
    {
        SceneManager.LoadScene("Correct1-1");
    }
}
