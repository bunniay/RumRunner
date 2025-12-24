using UnityEngine;
using UnityEngine.SceneManagement;

public class gotorunner : MonoBehaviour
{
    public void OnStartClick()
    {
        SceneManager.LoadScene("RumRunner");
    }
}
