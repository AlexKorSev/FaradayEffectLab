using UnityEngine;
using TMPro;

public class GeneratorLabel2 : MonoBehaviour
{
    public TextMeshProUGUI label;


    // Update is called once per frame
    void Update()
    {
        
            var ctx = InstallationContext.shared;
            label.SetText(ctx.generatorController.label2Value());
    }
}
