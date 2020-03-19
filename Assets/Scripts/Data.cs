using UnityEngine;

[CreateAssetMenu(menuName = "Data file")] // Имя пункта.

public class Data : ScriptableObject
{
    public Sprite backGround;

    [TextArea(minLines: 1, maxLines: 70)] public string placeText;
    [TextArea(minLines: 1, maxLines: 70)] public string episodeText;
    [TextArea(minLines: 1, maxLines: 100)] public string contentText;

    public Data[] nextSteps;

}
