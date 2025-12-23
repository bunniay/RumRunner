using UnityEngine;
using UnityEngine.SceneManagement;

public class startmenu : MonoBehaviour
{
    public void OnStartClick ()
    {
        SceneManager.LoadScene("Choose");
    }
 /*  public void OnExitClick()
    {
#if UNITY_EDITOR 
        UnityEditor.EditorApplication.isPlaying = false;
#endif 
        Application.Quit();
    }*/
}
