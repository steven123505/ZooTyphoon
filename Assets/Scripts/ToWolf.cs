using UnityEngine;

public class ToWolf : CollisionDetector
{
    public void OnTriggerEnter(Collider other) // call parent method
    {
        goToWolfExhibit();
    }

}
