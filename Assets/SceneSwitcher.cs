using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour {

    public void SwitchToScene(int i)
    {
        SceneManager.LoadScene(i);
    }
}
