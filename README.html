<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Photon PUN Networking Layer</title>
    <style>
        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }

        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            min-height: 100vh;
            padding: 20px;
        }

        .container {
            max-width: 1200px;
            margin: 0 auto;
            background: white;
            border-radius: 15px;
            overflow: hidden;
            box-shadow: 0 20px 60px rgba(0, 0, 0, 0.3);
        }

        /* Header Section */
        .header {
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            color: white;
            padding: 60px 40px;
            text-align: center;
            position: relative;
            overflow: hidden;
        }

        .header::before {
            content: '';
            position: absolute;
            top: 0;
            left: 0;
            right: 0;
            bottom: 0;
            background: url('data:image/svg+xml,<svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 1200 120"><path d="M0,50 Q300,0 600,50 T1200,50 L1200,120 L0,120 Z" fill="rgba(255,255,255,0.1)"/></svg>');
            background-repeat: no-repeat;
            background-size: cover;
        }

        .header-content {
            position: relative;
            z-index: 1;
        }

        .header h1 {
            font-size: 3em;
            margin-bottom: 10px;
            text-shadow: 2px 2px 4px rgba(0, 0, 0, 0.2);
        }

        .header p {
            font-size: 1.2em;
            opacity: 0.95;
        }

        /* Navigation */
        .nav {
            display: flex;
            justify-content: center;
            gap: 30px;
            padding: 20px;
            background: #f8f9fa;
            flex-wrap: wrap;
        }

        .nav a {
            text-decoration: none;
            color: #667eea;
            font-weight: 600;
            padding: 8px 16px;
            border-radius: 5px;
            transition: all 0.3s ease;
        }

        .nav a:hover {
            background: #667eea;
            color: white;
        }

        /* Content Sections */
        .content {
            padding: 40px;
        }

        .section {
            margin-bottom: 50px;
        }

        .section-title {
            font-size: 2em;
            color: #667eea;
            margin-bottom: 20px;
            padding-bottom: 10px;
            border-bottom: 3px solid #667eea;
            display: inline-block;
        }

        .section-subtitle {
            font-size: 1.3em;
            color: #333;
            margin: 25px 0 15px 0;
            font-weight: 600;
        }

        p {
            color: #555;
            line-height: 1.8;
            margin-bottom: 15px;
            font-size: 1.05em;
        }

        /* Features Grid */
        .features-grid {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
            gap: 20px;
            margin: 20px 0;
        }

        .feature-card {
            background: linear-gradient(135deg, #f5f7fa 0%, #c3cfe2 100%);
            padding: 25px;
            border-radius: 10px;
            border-left: 5px solid #667eea;
            transition: transform 0.3s ease, box-shadow 0.3s ease;
        }

        .feature-card:hover {
            transform: translateY(-5px);
            box-shadow: 0 10px 25px rgba(0, 0, 0, 0.1);
        }

        .feature-card h3 {
            color: #667eea;
            margin-bottom: 10px;
            font-size: 1.2em;
        }

        .feature-card p {
            color: #666;
            font-size: 0.95em;
            margin: 0;
        }

        /* Code Block */
        .code-block {
            background: #282c34;
            color: #abb2bf;
            padding: 20px;
            border-radius: 8px;
            overflow-x: auto;
            margin: 20px 0;
            font-family: 'Courier New', monospace;
            font-size: 0.9em;
            line-height: 1.5;
            border-left: 4px solid #667eea;
        }

        .code-block code {
            color: #61dafb;
        }

        .keyword {
            color: #c678dd;
        }

        .string {
            color: #98c379;
        }

        .comment {
            color: #5c6370;
        }

        /* File Structure */
        .file-structure {
            background: #f5f5f5;
            padding: 20px;
            border-radius: 8px;
            font-family: monospace;
            margin: 20px 0;
            border-left: 4px solid #667eea;
        }

        .file-structure pre {
            margin: 0;
            color: #333;
            line-height: 1.6;
        }

        /* Setup Steps */
        .steps {
            list-style: none;
            counter-reset: step-counter;
            margin: 20px 0;
        }

        .steps li {
            counter-increment: step-counter;
            margin-bottom: 20px;
            padding-left: 40px;
            position: relative;
        }

        .steps li::before {
            content: counter(step-counter);
            position: absolute;
            left: 0;
            top: 0;
            background: #667eea;
            color: white;
            width: 35px;
            height: 35px;
            border-radius: 50%;
            display: flex;
            align-items: center;
            justify-content: center;
            font-weight: bold;
        }

        /* API Reference Table */
        .api-table {
            width: 100%;
            border-collapse: collapse;
            margin: 20px 0;
            box-shadow: 0 2px 8px rgba(0, 0, 0, 0.1);
            border-radius: 8px;
            overflow: hidden;
        }

        .api-table th {
            background: #667eea;
            color: white;
            padding: 15px;
            text-align: left;
            font-weight: 600;
        }

        .api-table td {
            padding: 15px;
            border-bottom: 1px solid #e0e0e0;
            color: #555;
        }

        .api-table tr:hover {
            background: #f5f5f5;
        }

        .api-table tr:last-child td {
            border-bottom: none;
        }

        /* Badges */
        .badge {
            display: inline-block;
            background: #667eea;
            color: white;
            padding: 5px 12px;
            border-radius: 20px;
            font-size: 0.85em;
            margin-right: 10px;
            margin-bottom: 10px;
        }

        .badge-success {
            background: #28a745;
        }

        .badge-warning {
            background: #ffc107;
            color: #333;
        }

        /* Footer */
        .footer {
            background: #f8f9fa;
            padding: 40px;
            text-align: center;
            border-top: 1px solid #e0e0e0;
            color: #666;
        }

        .footer a {
            color: #667eea;
            text-decoration: none;
            font-weight: 600;
        }

        .footer a:hover {
            text-decoration: underline;
        }

        /* Responsive */
        @media (max-width: 768px) {
            .header h1 {
                font-size: 2em;
            }

            .header {
                padding: 40px 20px;
            }

            .content {
                padding: 20px;
            }

            .nav {
                flex-direction: column;
                gap: 10px;
            }

            .features-grid {
                grid-template-columns: 1fr;
            }

            .api-table {
                font-size: 0.9em;
            }

            .api-table th, .api-table td {
                padding: 10px;
            }
        }

        /* Highlight */
        .highlight {
            background: #fff3cd;
            padding: 2px 6px;
            border-radius: 3px;
            font-weight: 600;
        }

        .info-box {
            background: #e7f3ff;
            border-left: 4px solid #2196F3;
            padding: 15px;
            border-radius: 5px;
            margin: 20px 0;
        }

        .info-box::before {
            content: 'ℹ️ ';
            font-weight: bold;
            margin-right: 10px;
        }

        .success-box {
            background: #d4edda;
            border-left: 4px solid #28a745;
            padding: 15px;
            border-radius: 5px;
            margin: 20px 0;
            color: #155724;
        }

        .success-box::before {
            content: '✓ ';
            font-weight: bold;
            margin-right: 10px;
            color: #28a745;
        }
    </style>
</head>
<body>
    <div class="container">
        <!-- Header -->
        <div class="header">
            <div class="header-content">
                <h1>🎮 Photon PUN Networking Layer</h1>
                <p>A robust, event-driven networking solution for multiplayer games using Photon PUN</p>
            </div>
        </div>

        <!-- Navigation -->
        <div class="nav">
            <a href="#overview">Overview</a>
            <a href="#features">Features</a>
            <a href="#installation">Installation</a>
            <a href="#architecture">Architecture</a>
            <a href="#api">API Reference</a>
            <a href="#usage">Usage</a>
            <a href="#examples">Examples</a>
        </div>

        <!-- Main Content -->
        <div class="content">
            <!-- Overview Section -->
            <div class="section" id="overview">
                <h2 class="section-title">📋 Overview</h2>
                <p>The <span class="highlight">Photon PUN Networking Layer</span> is a lightweight, event-driven networking abstraction built on top of Photon PUN 2. It provides a clean, scalable architecture for managing multiplayer game connections, lobbies, rooms, and player interactions.</p>
                
                <div class="info-box">
                    This layer simplifies complex networking logic and provides a unified event system for all network events, making it easy to integrate multiplayer functionality into your Unity games.
                </div>

                <div class="success-box">
                    Perfect for developers who want a structured, maintainable approach to multiplayer networking without reinventing the wheel!
                </div>
            </div>

            <!-- Features Section -->
            <div class="section" id="features">
                <h2 class="section-title">✨ Key Features</h2>
                <div class="features-grid">
                    <div class="feature-card">
                        <h3>🔄 Event-Driven Architecture</h3>
                        <p>Clean event system for all network callbacks with automatic invocation of listeners</p>
                    </div>
                    <div class="feature-card">
                        <h3>🎯 Singleton Pattern</h3>
                        <p>Single instance across scenes with DontDestroyOnLoad for persistent connectivity</p>
                    </div>
                    <div class="feature-card">
                        <h3>🏠 Lobby Management</h3>
                        <p>Built-in lobby system with room list caching and real-time updates</p>
                    </div>
                    <div class="feature-card">
                        <h3>🎲 Room Management</h3>
                        <p>Seamless room creation, joining, and player management</p>
                    </div>
                    <div class="feature-card">
                        <h3>👥 Player Events</h3>
                        <p>Track player entries and exits with dedicated event callbacks</p>
                    </div>
                    <div class="feature-card">
                        <h3>🔌 Connection Handling</h3>
                        <p>Robust connection state management and disconnection handling</p>
                    </div>
                </div>
            </div>

            <!-- Installation Section -->
            <div class="section" id="installation">
                <h2 class="section-title">⚙️ Installation & Setup</h2>
                
                <h3 class="section-subtitle">Prerequisites</h3>
                <ul class="steps">
                    <li>Unity 2020.3 or higher</li>
                    <li>Photon PUN 2 imported from the Asset Store</li>
                    <li>A Photon account with AppID configured</li>
                </ul>

                <h3 class="section-subtitle">Installation Steps</h3>
                <ol class="steps">
                    <li>
                        <strong>Clone or Download</strong>
                        <p>Download the scripts from this repository</p>
                    </li>
                    <li>
                        <strong>Create Scripts Folder</strong>
                        <p>Create a <code>Scripts/Networking</code> folder in your Assets directory</p>
                    </li>
                    <li>
                        <strong>Add Scripts</strong>
                        <p>Place <code>NetworkManager.cs</code> and <code>NetworkEvent.cs</code> in your networking folder</p>
                    </li>
                    <li>
                        <strong>Create GameObject</strong>
                        <p>Create an empty GameObject in your main scene and attach <code>NetworkManager</code> script</p>
                    </li>
                    <li>
                        <strong>Configure Photon</strong>
                        <p>Set up your Photon AppID in Window → Photon PUN 2 Setup</p>
                    </li>
                </ol>

                <div class="file-structure">
                    <pre>Assets/
├── Scripts/
│   └── Networking/
│       ├── NetworkManager.cs
│       └── NetworkEvent.cs
└── Photon/
    └── (PUN 2 files)</pre>
                </div>
            </div>

            <!-- Architecture Section -->
            <div class="section" id="architecture">
                <h2 class="section-title">🏗️ Architecture</h2>
                
                <h3 class="section-subtitle">Component Overview</h3>
                
                <h4 style="color: #667eea; margin-top: 20px; margin-bottom: 10px;">NetworkManager.cs</h4>
                <p>The core networking manager that handles:</p>
                <ul style="margin-left: 20px; margin-bottom: 20px;">
                    <li>Photon PUN connection initialization</li>
                    <li>Lobby and room management</li>
                    <li>Player tracking and events</li>
                    <li>Scene synchronization</li>
                </ul>

                <h4 style="color: #667eea; margin-top: 20px; margin-bottom: 10px;">NetworkEvent.cs</h4>
                <p>The event system that provides:</p>
                <ul style="margin-left: 20px; margin-bottom: 20px;">
                    <li>Centralized event declarations</li>
                    <li>Type-safe event invocation</li>
                    <li>Decoupled event handling</li>
                </ul>

                <div class="code-block">
<span class="comment">// Event Flow</span>
NetworkManager → OnConnectedToMaster() → NetworkEvent.InvokeOnConnectedToMaster()
    ↓
All subscribed listeners receive the event
                </div>
            </div>

            <!-- API Reference Section -->
            <div class="section" id="api">
                <h2 class="section-title">📚 API Reference</h2>
                
                <h3 class="section-subtitle">NetworkEvent Properties</h3>
                <table class="api-table">
                    <thead>
                        <tr>
                            <th>Event</th>
                            <th>Parameters</th>
                            <th>Description</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td><code>OnJoinedLobbyEvent</code></td>
                            <td>None</td>
                            <td>Fired when player joins the lobby</td>
                        </tr>
                        <tr>
                            <td><code>OnLeftRoomEvent</code></td>
                            <td>None</td>
                            <td>Fired when player leaves a room</td>
                        </tr>
                        <tr>
                            <td><code>OnJoinedRoomEvent</code></td>
                            <td>None</td>
                            <td>Fired when player joins a room</td>
                        </tr>
                        <tr>
                            <td><code>OnCreatedRoomEvent</code></td>
                            <td>None</td>
                            <td>Fired when a room is created</td>
                        </tr>
                        <tr>
                            <td><code>OnConnectedToMasterEvent</code></td>
                            <td>None</td>
                            <td>Fired when connected to Photon server</td>
                        </tr>
                        <tr>
                            <td><code>OnRoomListUpdateEvent</code></td>
                            <td><code>List&lt;RoomInfo&gt;</code></td>
                            <td>Fired when room list updates</td>
                        </tr>
                        <tr>
                            <td><code>OnPlayerEnteredRoomEvent</code></td>
                            <td><code>Player</code></td>
                            <td>Fired when a player joins the room</td>
                        </tr>
                        <tr>
                            <td><code>OnPlayerLeftRoomEvent</code></td>
                            <td><code>Player</code></td>
                            <td>Fired when a player leaves the room</td>
                        </tr>
                        <tr>
                            <td><code>OnDisconnectedEvent</code></td>
                            <td><code>DisconnectCause</code></td>
                            <td>Fired when disconnected from server</td>
                        </tr>
                    </tbody>
                </table>

                <h3 class="section-subtitle">NetworkManager Properties</h3>
                <table class="api-table">
                    <thead>
                        <tr>
                            <th>Property</th>
                            <th>Type</th>
                            <th>Description</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td><code>instance</code></td>
                            <td>static NetworkManager</td>
                            <td>Singleton instance accessor</td>
                        </tr>
                        <tr>
                            <td><code>cachedRoomList</code></td>
                            <td>List&lt;RoomInfo&gt;</td>
                            <td>Current list of available rooms</td>
                        </tr>
                        <tr>
                            <td><code>networkEvent</code></td>
                            <td>NetworkEvent</td>
                            <td>Event system instance</td>
                        </tr>
                        <tr>
                            <td><code>IsOpen</code></td>
                            <td>bool</td>
                            <td>Whether the current room accepts new players</td>
                        </tr>
                    </tbody>
                </table>
            </div>

            <!-- Usage Section -->
            <div class="section" id="usage">
                <h2 class="section-title">🚀 Usage Guide</h2>
                
                <h3 class="section-subtitle">Basic Setup</h3>
                <div class="code-block">
<span class="keyword">using</span> UnityEngine;

<span class="keyword">public class</span> <span class="string">GameManager</span> : MonoBehaviour
{
    <span class="keyword">private void</span> Start()
    {
        <span class="comment">// Subscribe to network events</span>
        NetworkManager.instance.networkEvent.OnJoinedLobbyEvent += OnLobbyJoined;
        NetworkManager.instance.networkEvent.OnRoomListUpdateEvent += OnRoomListUpdated;
    }

    <span class="keyword">private void</span> OnLobbyJoined()
    {
        Debug.Log(<span class="string">"Successfully joined lobby!"</span>);
    }

    <span class="keyword">private void</span> OnRoomListUpdated(List&lt;RoomInfo&gt; rooms)
    {
        Debug.Log(<span class="string">$"Available rooms: {rooms.Count}"</span>);
    }
}
                </div>

                <h3 class="section-subtitle">Accessing Room List</h3>
                <div class="code-block">
<span class="comment">// Get cached room list</span>
List&lt;RoomInfo&gt; rooms = NetworkManager.instance.cachedRoomList;

<span class="comment">// Display rooms</span>
<span class="keyword">foreach</span> (RoomInfo room <span class="keyword">in</span> rooms)
{
    Debug.Log(room.Name);
}
                </div>

                <h3 class="section-subtitle">Handling Player Events</h3>
                <div class="code-block">
<span class="keyword">private void</span> Start()
{
    NetworkManager.instance.networkEvent.OnPlayerEnteredRoomEvent += OnPlayerEntered;
    NetworkManager.instance.networkEvent.OnPlayerLeftRoomEvent += OnPlayerLeft;
}

<span class="keyword">private void</span> OnPlayerEntered(Player player)
{
    Debug.Log($<span class="string">"{player.NickName} joined the room"</span>);
}

<span class="keyword">private void</span> OnPlayerLeft(Player player)
{
    Debug.Log($<span class="string">"{player.NickName} left the room"</span>);
}
                </div>
            </div>

            <!-- Examples Section -->
            <div class="section" id="examples">
                <h2 class="section-title">💡 Complete Examples</h2>
                
                <h3 class="section-subtitle">Example: Room Browser</h3>
                <div class="code-block">
<span class="keyword">public class</span> <span class="string">RoomBrowser</span> : MonoBehaviour
{
    <span class="keyword">private void</span> OnEnable()
    {
        NetworkManager.instance.networkEvent.OnRoomListUpdateEvent 
            += DisplayRooms;
    }

    <span class="keyword">private void</span> DisplayRooms(List&lt;RoomInfo&gt; rooms)
    {
        Debug.Log(<span class="string">"=== Available Rooms ==="</span>);
        <span class="keyword">foreach</span> (RoomInfo room <span class="keyword">in</span> rooms)
        {
            Debug.Log($<span class="string">"{room.Name} - {room.PlayerCount}/{room.MaxPlayers}"</span>);
        }
    }
}
                </div>

                <h3 class="section-subtitle">Example: Connection Manager</h3>
                <div class="code-block">
<span class="keyword">public class</span> <span class="string">ConnectionManager</span> : MonoBehaviour
{
    <span class="keyword">private void</span> Start()
    {
        <span class="keyword">var</span> networkEvent = NetworkManager.instance.networkEvent;
        
        networkEvent.OnConnectedToMasterEvent += OnConnected;
        networkEvent.OnDisconnectedEvent += OnDisconnected;
    }

    <span class="keyword">private void</span> OnConnected()
    {
        Debug.Log(<span class="string">"Connected to Photon Master"</span>);
    }

    <span class="keyword">private void</span> OnDisconnected(DisconnectCause cause)
    {
        Debug.Log($<span class="string">"Disconnected: {cause}"</span>);
    }
}
                </div>
            </div>

            <!-- Best Practices Section -->
            <div class="section">
                <h2 class="section-title">⭐ Best Practices</h2>
                
                <div style="margin: 20px 0;">
                    <span class="badge badge-success">Performance</span>
                    <p>Always unsubscribe from events in OnDisable() to prevent memory leaks</p>
                </div>

                <div style="margin: 20px 0;">
                    <span class="badge badge-success">Security</span>
                    <p>Validate player data before trusting it in networked operations</p>
                </div>

                <div style="margin: 20px 0;">
                    <span class="badge badge-success">Debugging</span>
                    <p>Subscribe to OnDisconnectedEvent to handle connection failures gracefully</p>
                </div>

                <div style="margin: 20px 0;">
                    <span class="badge badge-success">Architecture</span>
                    <p>Use the event system to keep your game logic decoupled from networking</p>
                </div>

                <div class="info-box">
                    Consider caching the NetworkManager.instance reference and events in your components for better performance in frequently-called methods.
                </div>
            </div>

            <!-- Support Section -->
            <div class="section">
                <h2 class="section-title">🤝 Support & Contribution</h2>
                <p>This is an open-source project. Feel free to:</p>
                <ul style="margin-left: 20px; margin-bottom: 20px;">
                    <li>Report bugs and issues</li>
                    <li>Submit pull requests with improvements</li>
                    <li>Suggest new features</li>
                    <li>Improve documentation</li>
                </ul>
                
                <p><strong>Repository:</strong> <a href="https://github.com/heroassem/Photon-Pun-networking-layer" target="_blank">Photon-Pun-networking-layer</a></p>
            </div>

            <!-- License Section -->
            <div class="section">
                <h2 class="section-title">📄 License</h2>
                <p>This project is provided as-is for educational and commercial use. Feel free to modify and integrate it into your projects.</p>
            </div>
        </div>

        <!-- Footer -->
        <div class="footer">
            <p>🎮 <strong>Photon PUN Networking Layer</strong> - Making multiplayer development easier</p>
            <p style="margin-top: 15px; font-size: 0.9em;">Created with ❤️ for game developers</p>
            <p style="margin-top: 15px;"><a href="https://github.com/heroassem/Photon-Pun-networking-layer">View on GitHub</a></p>
        </div>
    </div>
</body>
</html>
