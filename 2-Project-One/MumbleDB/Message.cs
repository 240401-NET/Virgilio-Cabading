using System;
using System.Collections.Generic;

namespace MumbleDB;

public partial class Message
{
    public int MessageId { get; set; }

    public string Message1 { get; set; } = null!;

    public int FromUserId { get; set; }

    public int ToUserId { get; set; }

    public virtual User FromUser { get; set; } = null!;

    public virtual User ToUser { get; set; } = null!;
}
