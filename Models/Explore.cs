namespace FrontToBack.Models
{
    public class Explore
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImgSrcName { get; set; }
        public double Rating { get; set; }
		public int Count { get; set; }
		public string Description { get; set; }
        public bool IsOpen { get; set; }
    }
}
