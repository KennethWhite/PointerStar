﻿using PointerStar.Shared;

namespace PointerStar.Server.Room;

public interface IRoomManager
{
    Task<RoomState> AddUserToRoomAsync(string roomId, User user, string connectionId);
    Task<RoomState?> DisconnectAsync(string connectionId);
    Task<RoomState?> SubmitVoteAsync(string vote, string connectionId);
}