using UnityEngine;
using TMPro;

public class GeneratorLabel1 : MonoBehaviour
{
    public TextMeshProUGUI label;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        var outputSignal = GeneratorController.shared.GetOutputSignal();
        var correct = (int)outputSignal;
        label.SetText(correct.ToString());
    }
}
