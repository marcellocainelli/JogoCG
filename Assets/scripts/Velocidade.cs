using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Velocidade : MonoBehaviour {
    public Rigidbody objectToMeasure;
    public Text velocidade;
    public Text aviso;
    public KeyCode sair;//tecla para voltar ao menu durante a execução
    float currentTime = 0;
    float maxTime = 5;
    public Text pontos;
    int ponto = 0;
    float currentTimePonto = 0;
    float tempoponto = 5;
    // Use this for initialization
    void Start () {
        velocidade.text = "0";
        pontos.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        double speed;
        //vai para o menu se apertar ESC durante o jogo
        if (Input.GetKeyDown(sair))
        {
            SceneManager.LoadScene("TelaInicialMenu");
        }

        currentTime += Time.deltaTime;
        if (currentTime >= maxTime)
        {
            aviso.enabled = false;
        }

        currentTimePonto += Time.deltaTime;
        if (currentTimePonto >= tempoponto)
        {
            ponto++;
            currentTimePonto = 0;
        }
        pontos.text = "Sua pontuação: " + ponto.ToString();

        speed = objectToMeasure.velocity.magnitude * 3.6;
        velocidade.text = System.Math.Round(speed, 0).ToString();
        if(speed<70)
            velocidade.color = Color.red;
        else if(speed>70 && speed<110)
            velocidade.color = Color.yellow;
        else if (speed > 110)
            velocidade.color= Color.green;
    }
}
