using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ContaPontos : MonoBehaviour {
    public Text pontos;
    int ponto = 0;
    float currentTimePonto = 0;
    float tempoponto = 5;

    void Start () {
        Debug.Log("Entrei1");
        //pontos.enabled = false;
    }

    void update()
    {
        currentTimePonto += Time.deltaTime;
        Debug.Log("Entrei2");
        if (currentTimePonto >= tempoponto)
        {
            ponto++;
            currentTimePonto = 0;
        }
        pontos.text = "Sua pontuação: " + ponto.ToString();
    }
}
