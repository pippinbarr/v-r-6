using UnityEngine;

public class NarrationController : MonoBehaviour
{
    public GameObject[] _stages;
    private int _stage = 0;

    public AudioClip[] _audios;
    private int _audio = 0;
    public AudioSource _source;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        NextStage();
    }

    // Update is called once per frame
    void Update()
    {
        if (!_source.isPlaying)
        {
            NextStage();
        }
    }

    void NextStage()
    {
        int previousStage = _stage - 1;
        if (previousStage < 0) previousStage = _stages.Length - 1;

        _stages[previousStage].SetActive(false);
        _stages[_stage].SetActive(true);

        _stage++;
        if (_stage >= _stages.Length) _stage = 0;

        _source.Stop();
        _source.clip = _audios[_audio];
        _source.Play();
        _audio++;
        if (_audio >= _audios.Length) _audio = 0;
    }
}
