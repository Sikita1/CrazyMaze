using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        int nextScene = SceneManager.GetActiveScene().buildIndex + 1;

        if (nextScene > SceneManager.sceneCountInBuildSettings - 1)
            SceneManager.LoadScene(1);
        else
            SceneManager.LoadScene(nextScene);
    }
}
