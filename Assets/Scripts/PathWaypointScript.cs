using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathWaypointScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        this.GetComponentInParent<QuestScript>().GetWaypoint();
    }
}
