using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioSlider : MonoBehaviour
{
    //This script has to be assigned individually to any slider whose only purpose is to change the sound value.
    //Public variables
    public Text valueIndicator;
    public AudioMixer mixer;
    public string exposedParameter;

    public void SetValue(float value)
    {


        AssignValue(value);
    }
    private void AssignValue(float valueToAssign)
    {

    }
}
