using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class respawn : MonoBehaviour
{
    public string mLevelToLoad;
    
    public void LevelLoad(){
        SceneManager.LoadScene(mLevelToLoad);
    }
}
