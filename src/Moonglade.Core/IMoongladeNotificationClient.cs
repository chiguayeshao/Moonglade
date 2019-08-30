﻿using System;
using System.Threading.Tasks;
using Edi.Practice.RequestResponseModel;
using Moonglade.Model;

namespace Moonglade.Core
{
    public interface IMoongladeNotificationClient
    {
        Task<Response> SendTestNotificationAsync();

        Task SendNewCommentNotificationAsync(CommentListItem comment, Func<string, string> funcCommentContentFormat);

        Task SendCommentReplyNotificationAsync(CommentReplyDetail model, string postLink);

        Task SendPingNotificationAsync(PingbackHistory receivedPingback);
    }
}