using UnityEngine;
using System.Collections;

public class KeluarButton : MonoBehaviour
{
    //public animat
    public void press()
    {
        GetComponent<Animator>().SetBool("pressed", true);

        Application.Quit();
    }
}