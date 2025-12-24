using UnityEngine;
using UnityEngine.SceneManagement;

public class backbutton : MonoBehaviour
{
    public void OnStartClick()
    {
        SceneManager.LoadScene("Choose");
    }
}
