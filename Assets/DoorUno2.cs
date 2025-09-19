using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorUno2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OpenScene()
    {
        
        SceneManager.LoadScene("Door 1 - Level 2");
    }
}
