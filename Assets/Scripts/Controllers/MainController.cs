using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.InputSystem;


public class MainController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // [SerializeField]

    // [SerializeField]
    // public AmplifierController amplifier;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var generator = InstallationContext.shared.generatorController;
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            var nextStep = generator.GetAttenuation() + 5;
            generator.SetAttenuation(nextStep);
        }

        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            var nextStep = generator.GetAttenuation() - 5;
            generator.SetAttenuation(nextStep);
        }
        
        
        var faraday = InstallationContext.shared.faradayController;
        if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
        {
            var nextStep = faraday.GetCurrentTheta() + Math.PI/12;
            faraday.SetCurrentTheta(nextStep);
            
        }
        if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
        {
            var nextStep = faraday.GetCurrentTheta() - Math.PI/12;
            faraday.SetCurrentTheta(nextStep);
        }
        
        if (Keyboard.current.upArrowKey.wasPressedThisFrame)
        {
            var nextStep = faraday.GetCurrent() + 0.1;
            faraday.SetCurrent(nextStep);
            
        }
        if (Keyboard.current.downArrowKey.wasPressedThisFrame)
        {
            var nextStep = faraday.GetCurrent() - 0.1;
            faraday.SetCurrent(nextStep);
        }
    }

}
