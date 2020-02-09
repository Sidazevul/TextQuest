using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Step : MonoBehaviour
{
    [TextArea(minLines: 1, maxLines: 50)] public string TitleText;
    [TextArea(minLines: 1, maxLines: 50)] public string GameText;
    public Sprite BackGround;
    public Step[] nextSteps;
}
