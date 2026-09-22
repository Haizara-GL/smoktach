using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private float duration;
    [SerializeField] private Image progressBar;
    private float _currTime;

    private void Awake()
    {
       StartTimer();
    }

    private void StartTimer()
    {
        _currTime = duration;
    }

    private void Update()
    {
        if (_currTime > 0)
        {
            _currTime -= Time.deltaTime;
            progressBar.fillAmount = _currTime / duration;
        }
    }
}
