using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class ButtonsBehav : MonoBehaviour
{
    public AudioMixer audioMix;

    public void StartGame()
    {
        SceneManager.LoadScene("Entrance");
    }
    public void AudioLevelSound(float soundlevel)
    {
        audioMix.SetFloat("sound", soundlevel);
    }
    public void AudioLevelMusic(float musiclevel)
    {
        audioMix.SetFloat("music", musiclevel);
    }
    public void CloseGame()
    {
        Application.Quit();
    }
}
