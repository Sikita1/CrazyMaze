using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsLevels : MonoBehaviour
{
    public void LoadScene(int scene) =>
        SceneManager.LoadScene(scene);
}
