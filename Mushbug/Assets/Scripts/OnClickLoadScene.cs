using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClickLoadScene : MonoBehaviour {

    public string levelName;

    public void LoadScene(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }


}
