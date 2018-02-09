using System;
using AsterNET.IO;

namespace AsterNET
{
    public class SocketConnectionTimeoutEnlarger : IDisposable
    {
        private readonly int _fallBackTimout;
        private readonly SocketConnection _socket;

        public SocketConnectionTimeoutEnlarger(SocketConnection socket, int timeOutMiliseconds)
        {
            _fallBackTimout = socket.ReadTimeout;
            _socket = socket;
            _socket.ReadTimeout = timeOutMiliseconds;
        }

        public void Dispose()
        {
            _socket.ReadTimeout = _fallBackTimout;
        }
    }
}
