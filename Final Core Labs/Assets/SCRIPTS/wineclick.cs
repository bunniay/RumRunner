using UnityEngine;
using UnityEngine.SceneManagement;

public class wineclick : MonoBehaviour
{
    public void OnStartClick()
    {
        SceneManager.LoadScene("character");
    }
}
