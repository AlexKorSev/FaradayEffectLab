using UnityEngine;
using TMPro;


public class AmplifierValueLabel : MonoBehaviour
{
    public TextMeshProUGUI label;

    void Update()
    {
        var ctx = InstallationContext.shared;
        label.SetText(ctx.amplifierController.labelValue());
    }
}

