public class FaradayModel
{
    public double thetaStart;
    public double currentTheta;
    public double gamma;
    public double current;
    public bool reverseMode;

    public double Beta =>
        CalculationService.AnglePolarizationCharacteristic(thetaStart, current);

    public double FerriteLoss =>
        reverseMode ? CalculationService.FerriteLoss(gamma) : 1.0;
    public double GetCurrent()
    {
        return current;
    }

    public void SetCurrent(double newI)
    {
        if (!(newI >= 0 && newI <= 1)){return;}
        current = newI;
    }
}