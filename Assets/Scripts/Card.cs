using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject {

    public string title;
    public string description;

    public Sprite artWork;

    public int type;

    public int servantAlt;
    public int influeneAlt;
    public int otherValue;
}
