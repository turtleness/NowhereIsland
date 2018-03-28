using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLoadWait : MonoBehaviour {

    public void Start()
    {
        Invoke("LoadEndLevel", 3f);
    }

    private void LoadEndLevel()
    {
        SceneManager.LoadScene(3);
    }
}
