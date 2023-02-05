namespace ClassLibrary1
{
	public interface IRainingNumber
	{
		int Number { get; }
		int Speed { get; }
		double XPosition { get; }
		double YPosition { get; }
		public void Move();
    }
}