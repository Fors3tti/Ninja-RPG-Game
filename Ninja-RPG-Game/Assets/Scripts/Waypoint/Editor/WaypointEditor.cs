using UnityEditor;

[CustomEditor(typeof(Waypoint))]

public class WaypointEditor : Editor
{
    private Waypoint WaypointTarget => target as Waypoint;

    private void OnSceneGUI()
    {
        
    }
}
