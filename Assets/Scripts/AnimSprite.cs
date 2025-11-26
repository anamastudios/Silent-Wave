using UnityEngine;

public class AnimSprite : MonoBehaviour
{
    // It works as intended or maybe not........
    public Sprite baseSprite;
    public SpriteRenderer affectedRenderer;
    public Sprite[] spriteList;
    public float spriteChangeRate;

    bool started = false;
    int spriteIndex = 0;
    float nextSpriteChange;

    void Update()
    {
        if (started)
        {
            RunAnimation();
        }
    }
    public void StartAnim()
    {
        started = true;
    }
    void RunAnimation()
    {
        if (Time.time > nextSpriteChange)
        {
            if (spriteIndex >= spriteList.Length)
            {
                spriteIndex = 0;
            }
            affectedRenderer.sprite = spriteList[spriteIndex];
            spriteIndex++;
            nextSpriteChange = Time.time + spriteChangeRate;
        }
    }
    public void StopAnim()
    {
        started = false;
        affectedRenderer.sprite = baseSprite;
        spriteIndex = 0;
    }
}
