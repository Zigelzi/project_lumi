using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotGizmo : MonoBehaviour
{
    public float gizmoSize = 0.75f;
    public Color gizmocolor = Color.yellow;

    private void OnDrawGizmos()
    {
        Gizmos.color = gizmocolor;
        Gizmos.DrawWireSphere(transform.position, gizmoSize);
    }
}
