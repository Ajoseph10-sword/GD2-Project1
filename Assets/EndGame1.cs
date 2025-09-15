using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OpenScene()
    {
        SceneManager.LoadScene("Win Game");
    }
}
