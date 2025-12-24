using UnityEngine;
using UnityEngine.SceneManagement;

public class endscreen : MonoBehaviour
{
    public void OnStartClick()
    {
        SceneManager.LoadScene("Menu");
    }
    /*  public void OnExitClick()
       {
   #if UNITY_EDITOR 
           UnityEditor.EditorApplication.isPlaying = false;
   #endif 
           Application.Quit();
       }*/
}
