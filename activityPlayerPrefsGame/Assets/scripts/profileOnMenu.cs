using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class profileOnMenu : MonoBehaviour
{
   public void clickProfile()
    {
        SceneManager.LoadScene("secondScene");
    }
    public void clickGame()
    {
        SceneManager.LoadScene("gameScene");
    }
}
