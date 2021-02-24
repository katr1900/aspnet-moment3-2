using System;
namespace Moment32.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }
        public string Category { get; set; }
    }
}
