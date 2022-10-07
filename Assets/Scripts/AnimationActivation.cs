using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationActivation : MonoBehaviour
{
    [SerializeField] private Sprite OnTriggerSprite;
    [SerializeField] private Sprite NotOnTriggerSprite;
    [SerializeField] private Sprite StayTriggerSprite;
    private void OnTriggerEnter2D()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = OnTriggerSprite;
    }
    
    private void OnTriggerExit2D()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = NotOnTriggerSprite;
    }
}
