using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Velocidade : MonoBehaviour {
    public Rigidbody objectToMeasure;
    public Text velocidade;

    // Use this for initialization
    void Start () {
        velocidade.text = "0";
    }
	
	// Update is called once per frame
	void Update () {
        double speed;
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
