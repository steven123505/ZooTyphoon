using UnityEngine;

public class ToElephant : CollisionDetector
{
    public void OnTriggerEnter(Collider other) // call parent method
    {
        goToElephantExhibit();
    }
}
