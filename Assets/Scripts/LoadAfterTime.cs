using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadAfterTime : MonoBehaviour
{
    [SerializeField]
    private float delayTime;
    [SerializeField]
    private string sceneNameToLoad;

    private float timeElapsed;
    

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if(timeElapsed > delayTime)
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }
}
