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
            textTimer.text = "���� �ð� : " + min  +  "�� " + (int)sec + "��";
        }
        if (setTime < 60f)
        {
            textTimer.text = "<color=red>" + "���� �ð� : " + (int)setTime + "��" + "</color>";
        }
        if (setTime <= 0)
        {
            SceneManager.LoadScene("Lose");
        }
    }
}
