using System;

public class FaradayController
{
    private FaradayModel model;

    public FaradayController(FaradayModel model)
    {
        this.model = model;
    }
    
    
    public double GetCurrent()
    {
        return model.current;
    }

    public void SetCurrent(double newI)
    {
        if (newI < 0 || newI > 1)
            return;

        model.current = newI;
    }

    
    public double GetThetaStart()
    {
        return model.thetaStart;
    }
    


    public double GetCurrentTheta()
    {
        return model.currentTheta;
    }

    public void SetCurrentTheta(double value)
    {
        double twoPi = 2 * Math.PI;

        if (value < 0)
            value = value % twoPi + twoPi;
        else if (value >= twoPi)
            value = value % twoPi;

        model.currentTheta = value;
    }



    public double GetGamma()
    {
        return model.gamma;
    }

    public void SetGamma(double value)
    {
        model.gamma = value;
    }


    public bool GetReverseMode()
    {
        return model.reverseMode;
    }

    public void SetReverseMode(bool value)
    {
        model.reverseMode = value;
    }


    public double Beta
    {
        get { return model.Beta; }
    }

    public double FerriteLoss
    {
        get { return model.FerriteLoss; }
    }


    public string labelValue()
    {
        return model.current.ToString("0.00");
    }
}