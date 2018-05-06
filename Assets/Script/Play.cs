using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Play : MonoBehaviour
{
    public Animator animasi;

    void play()
    {
        animasi.SetBool("prees", true);
    }
    public void goToPlay()
    {
        play();
        StartCoroutine(Example());
        SceneManager.LoadSceneAsync(1, LoadSceneMode.Single);


    }
    IEnumerator Example()
    {
        do
        {
            yield return null;
        } while (!animasi.GetCurrentAnimatorStateInfo(0).IsName("end"));

    }
}