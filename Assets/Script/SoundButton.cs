using UnityEngine;
using System.Collections;

public class SoundButton : MonoBehaviour
{
    private Animator sound;
    static bool isOn;
    void press()
    {
        if (PlayerData.getSound())
        {
            sound.SetTrigger("onToOf");
            PlayerData.setSound(false);
        }
        else
        {
            sound.SetTrigger("ofToOn");
            PlayerData.setSound(false);

        }
    }
}