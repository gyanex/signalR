using System;

public class UserNotification
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid ContentId { get; set; }
    public string NotificationName { get; set; }
    public Guid ChannelId { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid UserNotifyId { get; set; }

}