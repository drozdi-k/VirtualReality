using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public void openFinish()
    {
        SceneManager.LoadScene("menu");
    }
}
