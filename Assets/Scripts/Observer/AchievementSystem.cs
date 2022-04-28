using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementSystem : Observer
{
    private void Start()
    {
        PlayerPrefs.DeleteAll();
        PointOfInterest.OnPointOInterestEntered += PointOfInterest_OnPointOfInterestEntered;
        //foreach (var poi in PointOfInterest())
        //{
          //  poi.RegisterObserver(this);
        //}
    }
    private void PointOfInterest_OnPointOfInterestEntered(string poi)
    {
        string achieventkey = "Achivement" + poi;
    }
    public override void OnNotify(object value, NotificationType notificationType)
    {
        if (notificationType == NotificationType.AchievementUnlocked)
        {
            string achievementKey = "achievement-" + value;
            if (PlayerPrefs.GetInt(achievementKey) == 1)
                return;
            PlayerPrefs.SetInt(achievementKey, 1);
            Debug.Log("Unlocked" + value);
        }
    }
}
public enum NotificationType
{
    AchievementUnlocked,
}
