using UnityEngine;

public class GeneratorController
{
    private GeneratorModel model;

    public GeneratorController(GeneratorModel model)
    {
        this.model = model;
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

    public double GetPower()
    {
        return model.power;
    }

    public double GetOutputSignal()
    {
        var attenuation = GetAttenuation();
        var result = CalculationService.GeneratorSignalOutput(attenuation);
        return result;
    }

    public string label1Value()
    {
        if (model.power == 0)
        {
            return "0";
        }
        double u = CalculationService.GeneratorSignalOutput(model.attenuation);
        return ((int)u).ToString();
    }
    public string label2Value()
    {
        var attinuation = model.attenuation;
        var correct = (int)attinuation;
        return correct.ToString();
    }
    
}
