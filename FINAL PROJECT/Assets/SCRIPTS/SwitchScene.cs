using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SwitchScene : MonoBehaviour
{
    public virtual void Start()
    {

    }

    public void SceneSwitch(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }


}
