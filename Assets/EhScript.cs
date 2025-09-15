
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EhScript : MonoBehaviour
{
    public TextMeshProUGUI Title3;
    public TextMeshProUGUI Answer13;
    public TextMeshProUGUI Answer23;
    public TextMeshProUGUI Answer33;
    public TextMeshProUGUI Answer43;
    public TextMeshProUGUI Text3;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Title3.text = "Which anime won Anime of the Year in 2025";
        Answer13.text = "Frieren";
        Answer23.text = "Apothecary Diaries";
        Answer33.text = "DanDaDan";
        Answer43.text = "Solo Leveling";

    }

    // Update is called once per frame
    public void OpenScene()
    {
        SceneManager.LoadScene("Incorrect1-3");
    }

    public float Timer3 = 15;

    void Update()
    {
        Timer3 -= Time.deltaTime;
        Text3.text = "Time: " + Timer3.ToString("0.0");
        if (Timer3 <= 0)
        {
            SceneManager.LoadScene("Times Up7");
        }

    }

}