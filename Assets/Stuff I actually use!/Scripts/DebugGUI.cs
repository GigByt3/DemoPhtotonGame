using UnityEngine;
using System.Collections;

public class DebugGUI : MonoBehaviour
{
    void OnGUI () {
        GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
    }
}