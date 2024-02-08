using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    //Temporizador
    private GameObject rel; 
    public Text timer;
    private float timeCurrent;
    // Start is called before the first frame update
    void Start()
    {
        rel = GameObject.FindWithTag("Timer");
        timer = rel.GetComponent<Text>();

        if(Time.time > 0){
            timeCurrent = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeCurrent = timeCurrent + 1 * Time.deltaTime;
        timer.text = "Timer: " + Mathf.RoundToInt(timeCurrent).ToString();

    }
}
