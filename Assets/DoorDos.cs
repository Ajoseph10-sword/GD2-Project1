using UnityEngine;
using UnityEngine.SceneManagement;
public class DoorDos : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    public void OpenScene()
    {
        SceneManager.LoadScene("Door 2");
    }
}

