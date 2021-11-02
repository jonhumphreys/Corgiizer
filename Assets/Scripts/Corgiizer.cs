using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Corgiizer : MonoBehaviour
{
    public Image CorgiImage;
    public List<Sprite> CorgiSprites;
    public CanvasGroup CorgiImageCanvasGroup;
    private bool isShowingImage = true;

    // Start is called before the first frame update
    void Start()
    {
        SetRandomImage();
    }

    public void SetRandomImage()
    {
        int randomIndex = Random.Range(0, CorgiSprites.Count);
        CorgiImage.sprite = CorgiSprites[randomIndex];
    }

    public void ToggleImageVisibility()
    {
        if (isShowingImage)
        {
            CanvasGroupDisplayer.Hide(CorgiImageCanvasGroup);
        }
        else
            CanvasGroupDisplayer.Show(CorgiImageCanvasGroup);
        isShowingImage = !isShowingImage;
    }
}
