using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HuhScript : MonoBehaviour
{
    public TextMeshProUGUI QP2;
    public TextMeshProUGUI Answer21;
    public TextMeshProUGUI Answer22;
    public TextMeshProUGUI Answer23;
    public TextMeshProUGUI Answer24;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        QP2.text = "What is the name of the Devil Fruit that Trafalgar D. Water Law ate?";
        Answer21.text = "Dice-Dice Fruit";
        Answer22.text = "Room-Room Fruit";
        Answer23.text = "Heart-Heart Fruit";
        Answer24.text = "Op-Op Fruit";
    }

    public void OpenScene()
    {
        SceneManager.LoadScene("Incorrect1-2");
    }
    public float Timer = 15;

    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            SceneManager.LoadScene("Times Up4");
        }
    }
}
