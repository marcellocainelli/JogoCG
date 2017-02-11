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
    double speed;

    void Start()
    {
        gameover.enabled = false;
        BtVoltarMenu.SetActive(false);
        BtJogarNovamente.SetActive(false);
        velocidade.text = "0";
    }

    void update()
    {
        speed = objectToMeasure.velocity.magnitude * 3.6;
        velocidade.text = "12";
        Debug.Log(velocidade);
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
                gameover.enabled = true;
                Time.timeScale = 0;
                BtVoltarMenu.SetActive(true);
                BtJogarNovamente.SetActive(true);
            }
        }
    }
}
