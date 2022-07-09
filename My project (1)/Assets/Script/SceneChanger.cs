using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string nextSceneName;
    public bool gameWin;
    public bool gameLose;
    public Animator anim;

    private void Start()
    {
        anim.SetBool("Win", gameWin);
        anim.SetBool("Lose", gameLose);
    }

    private void OnCollisionEnter(Collision collision)
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit")) // Submit: Enter, Spacebar, ... 큰버튼 의미
        {
            SceneManager.LoadScene(nextSceneName);

        }
    }
}
