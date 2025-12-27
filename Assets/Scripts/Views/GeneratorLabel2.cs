using UnityEngine;
using TMPro;

public class GeneratorLabel2 : MonoBehaviour
{
    public TextMeshProUGUI label;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var attinuation = GeneratorController.shared.GetAttenuation();
        var correct = (int)attinuation;
        label.SetText(correct.ToString());
    }
}
