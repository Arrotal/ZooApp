using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName ="New Card", menuName ="Cards")]
public class CardModel : ScriptableObject
{
    public string Title;
    public string Description;
    public string Exhibit;
    public Sprite AnimalImage;


    private void OnEnable()
    {
    }
}
