using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour
{
    public Text Title,description, exhibit;
    public Image animalImage;

    public List<CardModel> cards ;



    public void CallCard(int value)
    {
        Title.text = cards[value].Title;
        description.text = cards[value].Description;
        exhibit.text = cards[value].Exhibit;
        animalImage.sprite = cards[value].AnimalImage;
    }
}
