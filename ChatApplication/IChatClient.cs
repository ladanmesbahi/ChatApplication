namespace ChatApplication
{
	public interface IChatClient
	{
		Task ReceiveMessage(string message);
	}
}
