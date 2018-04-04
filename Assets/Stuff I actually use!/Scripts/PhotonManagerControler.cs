using UnityEngine;

public class PhotonManagerControler : Photon.PunBehaviour
{
    public void startGame()
    {
        PhotonNetwork.JoinRandomRoom();
    }
    public override void OnPhotonJoinRoomFailed(object[] codeAndMsg)
    {
        PhotonNetwork.CreateRoom("testRoom");
    }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.Instantiate("Player", new Vector3(0, 5, 0), Quaternion.identity, 0);
    }
    public void leave()
    {
        PhotonNetwork.LeaveRoom();
    }
}