namespace Part2
{
    public class UniversityTeacher : AbstractTeacher
    {
        public string UniversityCode { get; set; }
        
        public int EnglishLevel { get; set; }
        public override double CalculateSalary()
        {
            if (Bonus > 10000)
            {
                throw new AmountException("bonus is more tha 10,000", Name);
            }

            var salary = BaseSalary * Level + ((BaseSalary / 10) * EnglishLevel) + Bonus;
            if (IsSenior && salary < 60000)
            {
                throw new AmountException("senior lecturer gets less than 60,000 salary", Name);
            }
            return salary;
        }
    }
}