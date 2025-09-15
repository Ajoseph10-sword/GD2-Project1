using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HuhScript2 : MonoBehaviour
{
    public TextMeshProUGUI HelpingHand;
    public TextMeshProUGUI fai1;
    public TextMeshProUGUI fai2;
    public TextMeshProUGUI fai3;
    public TextMeshProUGUI fai4;
    public TextMeshProUGUI alibaba;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HelpingHand.text = "Which one of these is not from the Cold War Era ?";
        fai1.text = "War on Drugs";
        fai2.text = "Vietnam War";
        fai3.text = "War of Stalingrad";
        fai4.text = "Cuban Missile Crisis";

    }
    public void OpenScene() {
        SceneManager.LoadScene("Incorrect2-3");
    }
    public float Timer67 = 15;
    void Update()
    {
        Timer67 -= Time.deltaTime;
        alibaba.text = "Time: " + Timer67.ToString("0.0");
        if (Timer67 <= 0)
        {
            SceneManager.LoadScene("Times Up5");
        }
    }
}
