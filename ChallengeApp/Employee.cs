namespace ChallengeApp
{
    public class Employee
    {
        private List<int> score = new List<int>();
        public string Name { get; set; }
        public int Age { get; set; }
        public Employee(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void AddScore(int points)
        { 
            this.score.Add(points);
        }
        public int GetScore()
        {
            return this.score.Sum();
        }


    }
}
