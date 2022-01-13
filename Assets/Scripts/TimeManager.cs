using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public Text timeText;
    private float level2Time;

    // Start is called before the first frame update
    void Start()
    {
        level2Time = 30;
}

    // Update is called once per frame
    void Update()
    {
        level2Time -= Time.deltaTime;

        timeText.text = "Time: " + level2Time.ToString("0.00");

        if (level2Time <= 0)
        {
            SceneManager.LoadScene("LoseScene");
        }
    }
}
