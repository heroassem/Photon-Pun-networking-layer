using System;
using System.Collections.Generic;
using Photon.Realtime;

public class NetworkEvent
{
    public event Action OnJoinedLobbyEvent;
    public event Action OnLeftRoomEvent;
    public event Action OnJoinedRoomEvent;
    public event Action OnCreatedRoomEvent;
    public event Action OnConnectedToMasterEvent;
    public event Action<List<RoomInfo>> OnRoomListUpdateEvent;
    public event Action<Player> OnPlayerEnteredRoomEvent;
    public event Action<Player> OnPlayerLeftRoomEvent;
    public event Action<DisconnectCause> OnDisconnectedEvent;

    public void InvokeOnJoinedLobby() => OnJoinedLobbyEvent?.Invoke();
    public void InvokeOnLeftRoom() => OnLeftRoomEvent?.Invoke();
    public void InvokeOnJoinedRoom() => OnJoinedRoomEvent?.Invoke();
    public void InvokeOnCreatedRoom() => OnCreatedRoomEvent?.Invoke();
    public void InvokeOnConnectedToMaster() => OnConnectedToMasterEvent?.Invoke();
    public void InvokeOnRoomListUpdate(List<RoomInfo> roomList) => OnRoomListUpdateEvent?.Invoke(roomList);
    public void InvokeOnPlayerEnteredRoom(Player player) => OnPlayerEnteredRoomEvent?.Invoke(player);
    public void InvokeOnPlayerLeftRoom(Player player) => OnPlayerLeftRoomEvent?.Invoke(player);
    public void InvokeOnDisconnected(DisconnectCause cause) => OnDisconnectedEvent?.Invoke(cause);
}
