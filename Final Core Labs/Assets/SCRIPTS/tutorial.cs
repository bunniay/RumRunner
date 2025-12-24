using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorial : MonoBehaviour
{
    public void OnStartClick()
    {
        SceneManager.LoadScene("Tutorial");
    }
}