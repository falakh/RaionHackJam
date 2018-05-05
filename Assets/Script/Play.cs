using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Play : MonoBehaviour
{
    public Animator animasi;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void play()
    {
        animasi.SetBool("prees", true);
    }
    public void goToPlay()
    {
        play();
        Debug.Log("press");
        //    SceneManager.LoadScene(0);


    }
}