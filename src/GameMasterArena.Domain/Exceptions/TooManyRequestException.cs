﻿using System.Net;

namespace GameMasterArena.Domain.Exceptions;

public class TooManyRequestException : Exception
{
    public HttpStatusCode StatusCode { get; } = HttpStatusCode.TooManyRequests;

    public string TitleMessage { get; protected set; } = String.Empty;
}
