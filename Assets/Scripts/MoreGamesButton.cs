using UnityEngine;
using YG;

public class MoreGamesButton : MonoBehaviour
{
    public void OpenReference() =>
        Application.OpenURL($"https://yandex.{YandexGame.EnvironmentData.domain}/games/developer/61727");
}
