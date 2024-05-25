using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scrimer : MonoBehaviour
{
    [SerializeField] private Sprite[] _images;
    [SerializeField] private Image _image;

    [SerializeField] private Audio _audio;

    private float _delay = 2f;
    private Coroutine _coroutine;

    private float _maxChance = 100f;
    private float _chance = 50;

    private bool CanChance => Random.Range(0, _maxChance) < _chance;
    private int RandomImage => Random.Range(0, _images.Length);

    private void Awake()
    {
        GetImage();
    }

    private void Start()
    {
        ImageOff();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (CanChance)
        {
            ImageOn();
            _coroutine = StartCoroutine(CloseImage());
            _audio.ScrimerPlay();
        }
    }

    private void GetImage() =>
        _image.sprite = _images[RandomImage];

    private void ImageOff() =>
        _image.gameObject.SetActive(false);

    private void ImageOn() =>
        _image.gameObject.SetActive(true);

    private IEnumerator CloseImage()
    {
        WaitForSeconds wait = new WaitForSeconds(_delay);

        yield return wait;

        ImageOff();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
