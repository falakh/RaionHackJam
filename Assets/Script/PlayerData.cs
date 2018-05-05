using UnityEngine;
using System.Collections;

public class PlayerData : MonoBehaviour
{
    public static void addCoin(int a)
    {
        Debug.Log("sebelum "+getKoin());
        PlayerPrefs.DeleteKey("koin");
        PlayerPrefs.SetInt("koin", getKoin()+a);
        Debug.Log("sesudah"+getKoin());
    }
    public static int getKoin()
    {
        return PlayerPrefs.GetInt("koin");
    }
   
}
