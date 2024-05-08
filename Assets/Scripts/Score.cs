using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Score : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoreTrigger;

   private void OnCollisionEnter2D(Collision2D collision){
    Ball ball = collision.gameObject.GetComponent<Ball>();

    if(ball != null) {
        BaseEventData eventData = new BaseEventData(EventSystem.current);
          scoreTrigger.Invoke(eventData);
    }

   }
}
