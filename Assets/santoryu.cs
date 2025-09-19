using UnityEngine;
using UnityEngine.SceneManagement;

public class santoryu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OpenScene()
    {
        SceneManager.LoadScene("Door 1 - Level 3-3");
    }
}
