using UnityEngine;
using System.Collections;
using System.IO;

public class GalleryScreenshotExample : MonoBehaviour
{

    bool saved = false;
    bool saved2 = false;

    void Start()
    {
        ScreenshotManager.ScreenshotFinishedSaving += ScreenshotSaved;
        ScreenshotManager.ImageFinishedSaving += ImageSaved;
    }

    void ScreenshotSaved()
    {
        Debug.Log("screenshot finished saving");
        saved = true;
    }

    void ImageSaved()
    {
        saved2 = true;
    }

    public void Capture()
    {
        StartCoroutine(ScreenshotManager.Save("MyScreenshot", "MyApp", true));
    }
}