using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorLerp : MonoBehaviour {
    SpriteRenderer bgRenderer;
    [SerializeField][Range (0f, 1f)] float lerpTime;
    [SerializeField] Color[] myColors;
    int colorIndex = 0;
    float lerpedColor = 0f;
    int len;
    void Start () {
        bgRenderer = GetComponent<SpriteRenderer> ();
        len = myColors.Length;
    }

    // Update is called once per frame
    void Update () {
        bgRenderer.color = Color.Lerp (bgRenderer.color, myColors[colorIndex], lerpTime * Time.deltaTime);

        lerpedColor = Mathf.Lerp (lerpedColor, 1f, lerpTime * Time.deltaTime);
        if (lerpedColor > 0.9f) {
            lerpedColor = 0f;
            colorIndex++;
            colorIndex = (colorIndex >= len) ? 0 : colorIndex;
        }
    }
}