namespace Delegation
{
    class Book
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int YearPublished { get; set; }

        public override string ToString()
        {
            return $"{Title}\t\t{Price:C}\t{YearPublished}";
        }
    }
}
