using UnityEngine;

public class AmplifierModel
{
    /// <summary>
    ///  n_п – положение регулятора усиления
    /// на приемнике (0…2)
    /// </summary>
    public double sensitivity;
    
    /// <summary>
    ///  p_п – положение выключателя приемного
    /// усилителя (0 – выключен, 1 – включен)
    /// </summary>
    public bool power;
    
    /// <summary>
    /// n_ун – положение регулятора
    /// установки нуля (0…1),
    /// изначальное положение при запуске
    /// программы должно выбираться
    /// случайным образом в интервале 0,04…0,15
    /// </summary>
    public double zeroPoint;
    
    /// <summary>
    ///  p_ун – положение переключателя
    /// установки нуля (0 – выключена установка нуля,
    /// 1 – включена установка нуля)
    /// </summary>
    public bool isSetZero;
    
    /// <summary>
    /// n_x – положение переключателя
    /// умножения уровня на приемнике
    /// (1 при , 10 при , 100 при )
    /// </summary>
    public double multiplyFactor;
}