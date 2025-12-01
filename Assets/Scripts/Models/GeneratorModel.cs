using UnityEngine;

public class GeneratorModel
{
    /// <summary>
    /// n_г – положение регулятора
    /// ослабления на генераторе, (20…80 дБ)
    /// </summary>
    public double attenuation;
    
    /// <summary>
    /// p_г – положение выключателя
    /// генератора (0 – генератор выключен,
    /// 1 – генератор включен)
    /// </summary>
    public double power;
    
}
