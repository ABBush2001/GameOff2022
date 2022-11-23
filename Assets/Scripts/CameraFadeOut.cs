using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraFadeOut : MonoBehaviour
{
    public bool fadeOut = false;

    public float speedScale = 1f;
    public Color fadeColor = Color.black;

    public AnimationCurve Curve = new AnimationCurve(new Keyframe(0, 1), new Keyframe(0.5f, 0.5f, -1.5f, -1.5f), new Keyframe(1, 0));
    public bool startFadedOut = false;

    public float alpha = 0f;
    private Texture2D texture;
    public int direction = 0;
    private float time = 0f;

    private void Start()
    {
        if(startFadedOut)
        {
            alpha = 1f;
        }
        else
        {
            alpha = 0f;
        }

        texture = new Texture2D(1, 1);
        texture.SetPixel(0, 0, new Color(fadeColor.r, fadeColor.g, fadeColor.b, alpha));
        texture.Apply();
    }

    private void Update()
    {
        if(direction == 0 && fadeOut)
        {
            fadeOut = false;

            //Fully faded in
            alpha = 0f;
            time = 1f;
            direction = -1;

        }
        /*else if(SceneManager.GetActiveScene().name == "UnderwaterScene")
        {
            alpha = 1f;
            time = 0f;
            direction = 1;
        }*/
        /*else
        {
            if (alpha >= 1f) //Fully faded out
            {
                GameObject.Find("SceneManager").GetComponent<LoadNextScene>().LoadScene(1);
            }
        }*/
    }

    public void OnGUI()
    {
        if(alpha > 0f)
        {
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), texture);
        }
        if(direction != 0)
        {
            time += direction * Time.deltaTime * speedScale;
            alpha = Curve.Evaluate(time);
            texture.SetPixel(0, 0, new Color(fadeColor.r, fadeColor.g, fadeColor.b, alpha));
            texture.Apply();
            if(alpha <= 0f || alpha >= 1f)
            {
                direction = 0;
            }
        }

    }

}
