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
		if (animasi != null) {
			play();
			StartCoroutine(Example());
		}
      
        SceneManager.LoadScene(1);
		Time.timeScale = 1;


    }
    IEnumerator Example()
    {
        do
        {
            yield return null;
        } while (!animasi.GetCurrentAnimatorStateInfo(0).IsName("end"));

    }
}