using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RadarScript : MonoBehaviour {
    public int vmax;
    public Image moto;
    public Image trem;
    public Image bb8;
    public Image mario;
    public Image elza;
    public Image minion;
    public Image gameover;
    public Rigidbody objectToMeasure;
    public GameObject BtVoltarMenu;
    public GameObject BtJogarNovamente;
    public Text velocidade;
    public string id_radar;
    double speed;
    private static int qteBrinquedos = 6;
    private int qteAnterior = 6;
    public GameObject BtJogaNovo;
    public Text pontos;


    void Start()
    {
        gameover.enabled = false;
        BtVoltarMenu.SetActive(false);
        BtJogarNovamente.SetActive(false);
        velocidade.text = "0";
        qteBrinquedos = 6;
        qteAnterior = 6;
      //  BtJogaNovo.SetActive(false);
    }


    public void OnTriggerEnter(Collider col)
    {
        speed = objectToMeasure.velocity.magnitude * 3.6;
        if (speed > vmax)
        {
            if (minion.enabled == true)
                minion.enabled = false;
            else if (elza.enabled == true)
                elza.enabled = false;
            else if (mario.enabled == true)
                mario.enabled = false;
            else if (bb8.enabled == true)
                bb8.enabled = false;
            else if (trem.enabled == true)
                trem.enabled = false;
            else if (moto.enabled == true)
            {
                moto.enabled = false;
                BtVoltarMenu.SetActive(true);
                BtJogaNovo.SetActive(true);
                gameover.enabled = true;
                Time.timeScale = 0;
                pontos.enabled = true;
            }
            qteBrinquedos = qteBrinquedos-1;
        }
        else if(id_radar == "radar1")
        {
           
            if(qteBrinquedos < 6 && qteAnterior == qteBrinquedos)
            {
                if (moto.enabled == false)
                    moto.enabled = true;
                else if (trem.enabled == false)
                    trem.enabled = true;
                else if (bb8.enabled == false)
                    bb8.enabled = true;
                else if (mario.enabled == false)
                    mario.enabled = true;
                else if (elza.enabled == false)
                    elza.enabled = true;
                else if (minion.enabled == false)
                    minion.enabled = true;
                qteBrinquedos++;
            }
            qteAnterior = qteBrinquedos;
        }
    }
}
