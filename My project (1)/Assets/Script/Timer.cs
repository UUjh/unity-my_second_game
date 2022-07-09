using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    TextMeshPro textTimer;
    

    float setTime = 120f;

    int min;
    float sec;
    private void Awake()
    {
        textTimer = GameObject.Find(name: "Timer").GetComponent<TextMeshPro>();
    }
    void Update()
    {
        
        setTime -= Time.deltaTime;

        if(setTime >= 60f)
        {
            min = (int)setTime / 60;
            sec = setTime % 60;
            textTimer.text = "남은 시간 : " + min  +  "분 " + (int)sec + "초";
        }
        if (setTime < 60f)
        {
            textTimer.text = "<color=red>" + "남은 시간 : " + (int)setTime + "초" + "</color>";
        }
        if (setTime <= 0)
        {
            SceneManager.LoadScene("Lose");
        }
    }
}
