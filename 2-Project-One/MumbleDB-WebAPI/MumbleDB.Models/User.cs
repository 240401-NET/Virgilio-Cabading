using System;
using System.Collections.Generic;

namespace MumbleDB.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Name { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Message> MessageFromUsers { get; set; } = new List<Message>();

    public virtual ICollection<Message> MessageToUsers { get; set; } = new List<Message>();
}
