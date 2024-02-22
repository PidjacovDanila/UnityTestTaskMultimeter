using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MultimeterLogic : MonoBehaviour
{
    public static MultimeterLogic instance;

    private void Awake()
    {
        instance = this;
    }


    [SerializeField] TextMeshPro TMPOutput;
    [SerializeField] TextMeshProUGUI TMPOutputA;
    [SerializeField] TextMeshProUGUI TMPOutputR;
    [SerializeField] TextMeshProUGUI TMPOutputV;
    [SerializeField] TextMeshProUGUI TMPOutputV_;


    double R = 1000;//Сопротивление(R)
    double P = 400;//Мощность(P)
    double V_ = 0.01;//Напряжение переменного тока(V~)
    double A;//Сила тока(A)
    double V;//Напряжение постоянного тока(V)

    void Start()
    {
        double PR = (P / R);
        double PR_2 = (P * R);

        A = Mathf.Sqrt((float)PR);

        V = Mathf.Sqrt((float)PR_2);
    }

    public void Reset_TMP()
    {
        TMPOutput.text = "0";
        TMPOutputA.text = "A 0";
        TMPOutputR.text = "Ω 0";
        TMPOutputV.text = "V 0";
        TMPOutputV_.text = "~ 0 ";
    }

    public void OutputR() {
        Reset_TMP();
        TMPOutputR.text = $"Ω {R:f2}";
        TMPOutput.text = $"{R:f2}";
    }
    public void OutputA() {
        Reset_TMP();
        TMPOutputA.text = $"A {A:f2}";
        TMPOutput.text = $"{A:f2}";
    }
    public void OutputV_() {
        Reset_TMP();
        TMPOutputV_.text = $"~ {V_:f2}";
        TMPOutput.text = $"{V_:f2}";
    }
    public void OutputV() {
        Reset_TMP();
        TMPOutputV.text = $"V {V:f2}";
        TMPOutput.text = $"{V:f2}";
    }
}
