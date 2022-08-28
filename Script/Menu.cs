using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void P1()
    {
        SceneManager.LoadScene(1); //load the scene 1 from scene manager
    }


    public void P2()
    {
        SceneManager.LoadScene(2); //load the scene 2 from scene manager
    }

}
