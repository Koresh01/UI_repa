using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class play_game : MonoBehaviour
{
    public void OpenScene(int level)
    {
        SceneManager.LoadScene(level);
    }
}
