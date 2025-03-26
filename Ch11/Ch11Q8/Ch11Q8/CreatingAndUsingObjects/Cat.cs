// Class Cat

namespace Ch11Q8.CreatingAndUsingObjects
{
    public class Cat
    {
        private static int serialNum = 1;
        private string name;
        private string color;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }

        public Cat()
        {
            this.name = "Cat" + serialNum;
            this.color = "Grey";
            serialNum++;
        }

        public Cat(string color)
        {
            this.name = "Cat" + serialNum;
            this.color = color;
            serialNum++;
        }

        public void SayMiau()
        {
            Console.WriteLine($"{name} said Miauuuuuu!");
        }
    }
}