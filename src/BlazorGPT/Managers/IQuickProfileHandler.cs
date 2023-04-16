﻿using BlazorGPT.Data;

namespace BlazorGPT.Managers;

public interface IQuickProfileHandler
{
    Task<Conversation> Send(Conversation conversation, IEnumerable<QuickProfile>? beforeProfiles = null);
    Task<Conversation> Receive(ChatWrapper chatWrapper, Conversation conversation,
        IEnumerable<QuickProfile>? profiles = null);
}