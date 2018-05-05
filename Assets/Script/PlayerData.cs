using UnityEngine;
using System.Collections;

public class PlayerData : MonoBehaviour
{
    public static void addCoin(int a)
    {
        Debug.Log("sebelum " + getKoin());
        PlayerPrefs.SetInt("koin", getKoin() + a);
        Debug.Log("sesudah" + getKoin());
    }
    public static int getKoin()
    {
        return PlayerPrefs.GetInt("koin");
    }
    public static void setSound(bool a)
    {
        if (a)
        {
            PlayerPrefs.SetString("suara", "on");
        }
        else
        {
            PlayerPrefs.SetString("suara", "off");
        }
    }
    public static bool getSound()
    {
        return PlayerPrefs.GetString("suara").Equals("on");
    }

}
