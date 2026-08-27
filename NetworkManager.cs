using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using ExitGames.Client.Photon;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    [HideInInspector] public List<RoomInfo> cachedRoomList { get; private set; } = new List<RoomInfo>();
    [HideInInspector] public NetworkEvent networkEvent { get; set; } = new NetworkEvent();

    public static NetworkManager instance { get; private set; }

    [HideInInspector] public bool IsOpen { get; set; } = false;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //---Start Connection---
    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
        PhotonNetwork.AutomaticallySyncScene = true;
    }

    //---On Connected to photon server---
    public override void OnConnectedToMaster()
    {
        if (!PhotonNetwork.InLobby)
        {
            PhotonNetwork.JoinLobby();
        }
    }

    //---On Joined Lobby---
    public override void OnJoinedLobby()
    {
        networkEvent.InvokeOnJoinedLobby();
    }

    //---On Disconnect from server---
    public override void OnDisconnected(DisconnectCause cause)
    {
        networkEvent.InvokeOnDisconnected(cause);
    }

    //---On Join to room---
    public override void OnJoinedRoom()
    {
        networkEvent.InvokeOnJoinedRoom();
    }

    //---On Create room---
    public override void OnCreatedRoom()
    {
        networkEvent.InvokeOnCreatedRoom();
    }

    //---On Left from room---
    public override void OnLeftRoom()
    {
        PhotonNetwork.LeaveLobby();

        networkEvent.InvokeOnLeftRoom();
    }

    //---On Left from lobby---
    public override void OnLeftLobby()
    {
        if (PhotonNetwork.IsConnected)
        {
            PhotonNetwork.JoinLobby();
        }
    }

    //---On Room List Update---
    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        foreach (RoomInfo info in roomList)
        {
            int index = cachedRoomList.FindIndex(x => x.Name == info.Name);

            if (info.RemovedFromList)
            {
                if (index != -1)
                    cachedRoomList.RemoveAt(index);
            }
            else
            {
                if (index != -1)
                    cachedRoomList[index] = info;
                else
                    cachedRoomList.Add(info);
            }
        }

        networkEvent.InvokeOnRoomListUpdate(cachedRoomList);
    }

    //---On Player Entered Room---
    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        networkEvent.InvokeOnPlayerEnteredRoom(newPlayer);
    }

    //---On Player Left Room---
    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        networkEvent.InvokeOnPlayerLeftRoom(otherPlayer);
    }
}
