using System;


public static class CalculationService
{
    public static double AnglePolarizationCharacteristic(double teta, double I)
    {
        /*
         * teta is degrees
         * I in [0...1]
         * return value is degrees
         */
        return teta + 100 * Math.Pow(I / (0.15 + I), 1.25);

    }

    public static double GeneratorSignalOutput(double n)
    {
        return Math.Pow(10, ((40 - n) / 20));
    }

    public static double AmplifierSignal(
        double n_n,
        double p_setZero,
        double n_setZero,
        double p_generatorPower,
        double p_ampifierPower,
        double n_multiplier,
        double betta,
        double generatorSignal,
        double teta,
        double ferriteLoss = 1.0
    )
    {
        double angleRad = (teta - betta) * Math.PI / 180.0;
        double absCos = Math.Abs(Math.Cos(angleRad));

        double bigPart =
            ferriteLoss *
            generatorSignal *
            n_n *
            absCos *
            (1 - p_setZero) *
            (p_generatorPower / n_multiplier)
            + n_setZero;

        return p_ampifierPower * bigPart * bigPart * 100;
    }

    
    public static double FerriteLoss(double gamma)
    {
        return Math.Pow(10, gamma / 20);
    }

}
