namespace Course.Entities
{
    abstract class People
    {
        public string Name { get; set; } = string.Empty;
        public double AnnualIncome { get; set;}

        public People(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double PayTax();
    }
}