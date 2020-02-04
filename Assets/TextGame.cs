using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextGame : MonoBehaviour
{
    [Header("Elements")]
    public Text titleText;
    public Text contentText;

    [Header("Config")]
    [TextArea]public string TitleText;
    [Tooltip("123")]public string GameText;
    // Start is called before the first frame update
    void Start()
    {
        contentText.text = GameText;
        titleText.text = TitleText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
