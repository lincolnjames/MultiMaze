﻿
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using MazeClient.Share;

namespace MazeServer
{
    internal class ServerGameManager
    {
        private static ServerGameManager? instance = null;
        public Define.GameState state = Define.GameState.InGameScene;
        public ClientManager client = new ClientManager();
        public Map map = new Map();

        public const int MAX_PLAYER_NUM = 3;

        private ServerGameManager()
        { 
        }

        // GameManager의 인스턴스를 반환하는 public static 메서드
        public static ServerGameManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ServerGameManager();
                }
                return instance;
            }
        }
    }
}
