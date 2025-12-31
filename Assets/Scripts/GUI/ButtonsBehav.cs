using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class ButtonsBehav : MonoBehaviour
{
    public AudioMixer audioMix;

    public void SceneString(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Entrance");
    }
    public void AudioLevelSound(float sound)
    {
        audioMix.SetFloat("sound", sound);
    }
    public void AudioLevelMusic(float music)
    {
        audioMix.SetFloat("music", music);
    }
    public void CloseGame()
    {
        Application.Quit();
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
