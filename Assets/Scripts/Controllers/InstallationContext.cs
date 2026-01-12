using UnityEngine;

public class InstallationContext
{
    public static InstallationContext shared = new InstallationContext();


    public GeneratorController generatorController;
    public AmplifierController amplifierController;
    public FaradayController faradayController;

    private InstallationContext()
    {
        FaradayModel faraday = new FaradayModel();
        AmplifierModel amplifier = new AmplifierModel();
        GeneratorModel generator = new GeneratorModel();
        
        generator.attenuation = GeneratorModel.AttenuationMin;
        generator.power = 1;
        
        
        amplifier.sensitivity = 1.0;
        amplifier.power = true;
        amplifier.multiplyFactor = 1;
        amplifier.isSetZero = false;
        amplifier.zeroPoint = Random.Range(0.04f, 0.15f);
        
        
        faraday.thetaStart = Random.Range(110f, 130f);
        faraday.gamma = Random.Range(10f, 20f);
        faraday.currentTheta = 0.0;
        faraday.reverseMode = false;
        
        generatorController = new GeneratorController(generator);
        amplifierController = new AmplifierController(amplifier);
        faradayController = new FaradayController(faraday);
    }
    
}