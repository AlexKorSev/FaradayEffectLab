using UnityEngine;

public class GeneratorController
{
    public static GeneratorController shared = new GeneratorController();
    private GeneratorModel model;

    public GeneratorController()
    {
        this.model = new GeneratorModel();
        model.attenuation = GeneratorModel.AttenuationMin;
        model.power = 0;
    }

    public void SetAttenuation(double value)
    {
        if (value < GeneratorModel.AttenuationMin)
        {
            this.model.attenuation = GeneratorModel.AttenuationMin;
            return;
        }
        if (value > GeneratorModel.AttenuationMax)
        {
            this.model.attenuation = GeneratorModel.AttenuationMax;
            return;
        }
        this.model.attenuation = value;
    }
    
    public void SetPower(bool value)
    {
        this.model.power = value ? 1 : 0;
    }

    public double GetAttenuation()
    {
        return model.attenuation;
    }

    public bool GetPower()
    {
        return model.power == 1;
    }

    public double GetOutputSignal()
    {
        var attenuation = GetAttenuation();
        var result = CalculationService.GeneratorSignalOutput(attenuation);
        return result;
    }
    
}
