using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class profileSceneScript : MonoBehaviour
{
    public void clickBack()
    {
        SceneManager.LoadScene("mainMenu");
    }
}
