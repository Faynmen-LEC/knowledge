namespace WebApi.Entities
{
	public class Driver
	{
        public int Id { get; set; }
		public required string Name { get; set;}
		public string Team { get; set;}	= string.Empty;
        public string Number { get; set; }= string.Empty;
    }
}
