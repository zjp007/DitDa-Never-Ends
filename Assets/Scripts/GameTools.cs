using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTools : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    /// <summary>
    /// 场景跳转
    /// </summary>
    /// <param name="sceneName"></param>
    public void SceneJumpTo(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
