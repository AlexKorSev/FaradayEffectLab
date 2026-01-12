using UnityEngine;
using TMPro;

public class FaradayValueLabel : MonoBehaviour
{
    public TextMeshProUGUI label;
    public Transform target;

    void Update()
    {
        var ctx = InstallationContext.shared;
        label.SetText(ctx.faradayController.labelValue());

        float thetaDeg = (float)(
            ctx.faradayController.GetCurrentTheta() * Mathf.Rad2Deg
        );

        target.localRotation = Quaternion.Euler(thetaDeg, 0, 0);
    }
}