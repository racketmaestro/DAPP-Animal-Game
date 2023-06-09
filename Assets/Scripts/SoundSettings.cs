using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundSettings : MonoBehaviour
{
    [SerializeField] private Slider musicSlider;
    [SerializeField] private AudioMixer masterMixer;

    private void Start()
    {
        SetMusicVolume(PlayerPrefs.GetFloat("SavedMasterVolume", 100));
        
    }

    public void SetMusicVolume(float _value)
    {
        if(_value < 1)
        {
            _value = .001f;
        }

        RefreshSlider(_value);
        PlayerPrefs.SetFloat("SavedMasterVolume", _value);
        masterMixer.SetFloat("MasterVolume", Mathf.Log10(_value / 100) * 20f);
    }

    public void SetVolumeFromSlider()
    {
        SetMusicVolume(musicSlider.value);
    }

    public void RefreshSlider(float _value)
    {
        musicSlider.value = _value;
    }
}
