using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage1_3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OpenScene()
    {
        SceneManager.LoadScene("Door Selection - Level 3");
    }
}
