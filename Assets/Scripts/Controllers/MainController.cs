using UnityEngine;
using UnityEngine.InputSystem;


public class MainController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // [SerializeField]
    public GeneratorController generator;
    // [SerializeField]
    // public AmplifierController amplifier;
    void Start()
    {
        generator = GeneratorController.shared;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            var currentAttenuation = generator.GetAttenuation();
            generator.SetAttenuation(currentAttenuation + 5);
            Debug.Log(currentAttenuation);
        }

        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            var currentAttenuation = generator.GetAttenuation();
            generator.SetAttenuation(currentAttenuation - 5);
            Debug.Log(currentAttenuation);
        }
    }

}
