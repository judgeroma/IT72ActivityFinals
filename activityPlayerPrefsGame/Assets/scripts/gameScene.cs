using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameScene : MonoBehaviour
{
    public void clickBack()
    {
        SceneManager.LoadScene("mainMenu");
    }
}
