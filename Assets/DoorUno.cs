using UnityEngine;
using UnityEngine.SceneManagement;
public class DoorUno : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void OpenScene() {
        SceneManager.LoadScene("Door 1");
    }
}
