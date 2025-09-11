using TMPro;
using UnityEditor;
using UnityEngine;

public class CorrectAnswer : MonoBehaviour
    
{
    public TextMeshProUGUI Answer1;
    public TextMeshProUGUI Answer2;
    public TextMeshProUGUI Answer3;
    public TextMeshProUGUI Answer4;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Answer1.text= "Straw Hat" ;
        Answer2.text = "Rubber Man";
        Answer3.text = "Joy Boy";
        Answer4.text = "Pirate Goku";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
