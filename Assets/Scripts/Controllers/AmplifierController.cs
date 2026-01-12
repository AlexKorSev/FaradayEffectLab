using UnityEngine;

public class AmplifierController
{
    private AmplifierModel model;

    public AmplifierController(AmplifierModel model)
    {
        this.model = model;
    }

    public string labelValue()
    {
        var ctx = InstallationContext.shared;
        
        double uGenerator = CalculationService.GeneratorSignalOutput(
            ctx.generatorController.GetAttenuation()
        );

        double u = CalculationService.AmplifierSignal(
            n_n: model.sensitivity,
            p_setZero: model.isSetZero ? 1 : 0,
            n_setZero: model.zeroPoint,
            p_generatorPower: ctx.generatorController.GetPower(),
            p_ampifierPower: model.power ? 1 : 0,
            n_multiplier: model.multiplyFactor,
            betta: ctx.faradayController.Beta,
            generatorSignal: uGenerator,
            teta: ctx.faradayController.GetCurrentTheta(),
            ferriteLoss: ctx.faradayController.FerriteLoss
        );
        return ((int)u).ToString();
    }
    
    
}
