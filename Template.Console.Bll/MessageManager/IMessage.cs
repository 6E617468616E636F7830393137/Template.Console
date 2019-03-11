using Template.Console.Dto.Models;

namespace Template.Console.Bll.MessageManager
{
    public interface IMessage
    {
        MessageModel setMessage(string data);
        string getMessage(MessageModel data);
    }
}
