using UnityEngine;

public class GameTime :MonoBehaviour
{
    public void SetScale(int scale)
    {
        Time.timeScale = scale;
    }

    private void OnDestroy()
    {
        Time.timeScale = 1;
    }
}