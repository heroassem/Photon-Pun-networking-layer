# 🎮 Photon PUN Networking Layer

> A robust, event-driven networking solution for multiplayer games using Photon PUN

[![GitHub](https://img.shields.io/badge/GitHub-Photon--Pun--networking--layer-blue?logo=github)](https://github.com/heroassem/Photon-Pun-networking-layer)
[![License](https://img.shields.io/badge/License-MIT-green)]()
[![Unity](https://img.shields.io/badge/Unity-2020.3%2B-black?logo=unity)]()
[![Status](https://img.shields.io/badge/Status-Active-brightgreen)]()

---

## 📋 Overview

The **Photon PUN Networking Layer** is a lightweight, event-driven networking abstraction built on top of Photon PUN 2. It provides a clean, scalable architecture for managing multiplayer game connections, lobbies, rooms, and player interactions.

This layer simplifies complex networking logic and provides a unified event system for all network events, making it easy to integrate multiplayer functionality into your Unity games.

---

## ✨ Key Features

| Feature | Description |
|---------|-------------|
| 🔄 **Event-Driven Architecture** | Clean event system for all network callbacks with automatic invocation |
| 🎯 **Singleton Pattern** | Single instance across scenes with DontDestroyOnLoad persistence |
| 🏠 **Lobby Management** | Built-in lobby system with room list caching and real-time updates |
| 🎲 **Room Management** | Seamless room creation, joining, and player management |
| 👥 **Player Events** | Track player entries and exits with dedicated event callbacks |
| 🔌 **Connection Handling** | Robust connection state management and disconnection handling |

---

## 🚀 Quick Start

### Prerequisites

```
✓ Unity 2020.3 or higher
✓ Photon PUN 2 from Asset Store
✓ Photon Account with AppID
```

### Installation (5 Steps)

```
1️⃣  Download scripts from repository
2️⃣  Create Assets/Scripts/Networking folder
3️⃣  Add NetworkManager.cs and NetworkEvent.cs
4️⃣  Attach NetworkManager to GameObject in scene
5️⃣  Configure AppID in Window → Photon PUN 2 Setup
```

---

## 📂 File Structure

```
Assets/
├── Scripts/
│   └── Networking/
│       ├── NetworkManager.cs      (Main networking manager)
│       └── NetworkEvent.cs        (Event system)
└── Your Game Files/
```

---

## 🏗️ Architecture Overview

### NetworkManager.cs
```
Core networking manager that handles:
├── Photon PUN connection initialization
├── Lobby and room management
├── Player tracking and events
└── Scene synchronization
```

### NetworkEvent.cs
```
Event system that provides:
├── Centralized event declarations
├── Type-safe event invocation
└── Decoupled event handling
```

---

## 📚 API Reference

### 🔔 Network Events

```csharp
// Connection Events
OnConnectedToMasterEvent              // Connected to Photon server
OnDisconnectedEvent(DisconnectCause)  // Disconnected from server

// Lobby Events
OnJoinedLobbyEvent                    // Joined the lobby
OnLeftLobby                           // Left the lobby

// Room Events
OnCreatedRoomEvent                    // Room created
OnJoinedRoomEvent                     // Joined a room
OnLeftRoomEvent                       // Left a room

// Player Events
OnPlayerEnteredRoomEvent(Player)      // Player joined room
OnPlayerLeftRoomEvent(Player)         // Player left room

// Update Events
OnRoomListUpdateEvent(List<RoomInfo>) // Room list updated
```

### 📦 Manager Properties

```csharp
NetworkManager.instance              // Access the singleton instance
cachedRoomList                        // List of available rooms
networkEvent                          // Event system instance
IsOpen                                // Room accepts new players?
```

---

## 💻 Code Examples

### Basic Setup - Subscribe to Events

```csharp
using UnityEngine;
using Photon.Realtime;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        // Subscribe to events
        NetworkManager.instance.networkEvent.OnJoinedLobbyEvent += OnLobbyJoined;
        NetworkManager.instance.networkEvent.OnRoomListUpdateEvent += OnRoomListUpdated;
    }

    private void OnLobbyJoined()
    {
        Debug.Log("✓ Successfully joined lobby!");
    }

    private void OnRoomListUpdated(List<RoomInfo> rooms)
    {
        Debug.Log($"📋 Available rooms: {rooms.Count}");
    }

    private void OnDisable()
    {
        // Unsubscribe to prevent memory leaks
        if (NetworkManager.instance != null)
        {
            NetworkManager.instance.networkEvent.OnJoinedLobbyEvent -= OnLobbyJoined;
            NetworkManager.instance.networkEvent.OnRoomListUpdateEvent -= OnRoomListUpdated;
        }
    }
}
```

### Browse Rooms

```csharp
public class RoomBrowser : MonoBehaviour
{
    private void Start()
    {
        NetworkManager.instance.networkEvent.OnRoomListUpdateEvent += DisplayRooms;
    }

    private void DisplayRooms(List<RoomInfo> rooms)
    {
        Debug.Log("╔════════════════════════╗");
        Debug.Log("║   Available Rooms      ║");
        Debug.Log("╚════════════════════════╝");
        
        foreach (RoomInfo room in rooms)
        {
            Debug.Log($"🎮 {room.Name} - {room.PlayerCount}/{room.MaxPlayers}");
        }
    }
}
```

### Handle Player Events

```csharp
public class PlayerManager : MonoBehaviour
{
    private void Start()
    {
        var networkEvent = NetworkManager.instance.networkEvent;
        networkEvent.OnPlayerEnteredRoomEvent += OnPlayerEntered;
        networkEvent.OnPlayerLeftRoomEvent += OnPlayerLeft;
    }

    private void OnPlayerEntered(Player player)
    {
        Debug.Log($"👋 {player.NickName} joined the room");
    }

    private void OnPlayerLeft(Player player)
    {
        Debug.Log($"👋 {player.NickName} left the room");
    }
}
```

### Connection Handler

```csharp
public class ConnectionManager : MonoBehaviour
{
    private void Start()
    {
        var networkEvent = NetworkManager.instance.networkEvent;
        networkEvent.OnConnectedToMasterEvent += OnConnected;
        networkEvent.OnDisconnectedEvent += OnDisconnected;
    }

    private void OnConnected()
    {
        Debug.Log("✓ Connected to Photon Master");
    }

    private void OnDisconnected(DisconnectCause cause)
    {
        Debug.LogWarning($"✗ Disconnected: {cause}");
    }
}
```

---

## ⭐ Best Practices

### Memory Management
```
✓ Always unsubscribe from events in OnDisable()
✓ Cache NetworkManager.instance for frequent access
✓ Implement proper null checks
```

### Performance Tips
```
✓ Use event system instead of polling
✓ Avoid subscribing to events multiple times
✓ Clean up listeners when scenes unload
```

### Security Considerations
```
✓ Validate player data before using it
✓ Implement proper authorization checks
✓ Never trust client-side validation
```

### Code Organization
```
✓ Keep game logic decoupled from networking
✓ Create separate managers for different concerns
✓ Use consistent naming conventions
```

---

## 🔧 Troubleshooting

### ❌ Connection Issues

**Problem:** Can't connect to Photon
```
✓ Check Photon AppID is configured
✓ Verify internet connection
✓ Check firewall settings
✓ Ensure Photon PUN 2 is imported
```

### ❌ Events Not Firing

**Problem:** Subscribed event not triggering
```
✓ Confirm correct event name
✓ Check NetworkManager exists in scene
✓ Verify connection state is correct
✓ Check subscription/unsubscription balance
```

### ❌ Room Not Appearing

**Problem:** Created room doesn't show in list
```
✓ Wait for room list update
✓ Check room is not private/closed
✓ Verify room filters match
✓ Check cachedRoomList directly
```

---

## 📖 Documentation Links

- 📚 [Photon PUN 2 Documentation](https://doc.photonengine.com/pun/v2/)
- 🎮 [Photon Dashboard](https://dashboard.photonengine.com)
- 💬 [Photon Forum](https://forum.photonengine.com/)

---

## 🤝 Contributing

We welcome contributions! Here's how you can help:

```
🐛 Report bugs and issues
🚀 Submit pull requests with improvements
💡 Suggest new features
📝 Improve documentation
```

---

## 📄 License

```
MIT License - Free to use and modify
Perfect for educational and commercial projects
```

---

## 💬 Getting Help

1. **Read the documentation** above
2. **Review the code examples**
3. **Check Photon's official docs**
4. **Open an issue on GitHub**

---

## 🎯 Project Stats

```
📦 Scripts: 2 (NetworkManager.cs + NetworkEvent.cs)
🎯 Total Events: 9
🔌 Callbacks: 11
📊 Lines of Code: ~150
⚡ Performance: Optimized
```

---

## 📦 What's Inside

```
✓ Singleton NetworkManager
✓ Event-driven architecture
✓ Lobby management
✓ Room management
✓ Player tracking
✓ Connection handling
✓ Automatic scene sync
✓ Room list caching
```

---

## 🚀 Next Steps

1. **Download** the repository
2. **Import** Photon PUN 2
3. **Copy** NetworkManager.cs and NetworkEvent.cs
4. **Attach** NetworkManager to a GameObject
5. **Start** building your multiplayer game! 🎮

---

<div align="center">

### Made with ❤️ for Game Developers

[⭐ Star us on GitHub](https://github.com/heroassem/Photon-Pun-networking-layer) | [🐛 Report Issues](https://github.com/heroassem/Photon-Pun-networking-layer/issues)

**Happy Networking! 🌐**

</div>

---

## 📞 Support

For questions or support:
- 📧 Check GitHub Issues
- 📚 Review Documentation
- 🎮 See Code Examples
- 💻 Join Photon Community

---

**Version:** 1.0.0 | **Last Updated:** 2026 | **Status:** ✅ Active & Maintained
