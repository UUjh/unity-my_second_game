using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayClick : MonoBehaviour
{
    public void SceneChang()
    {
        SceneManager.LoadScene("Main");
    }
}
