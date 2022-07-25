using DucksGalore.Ducks;

namespace DucksGalore
{
    public partial class Form1 : Form
    {
        Duck duck;
        List<Duck> ducks = new List<Duck>();
        List<string> names = new List<string> { "Phillpot", "Danschzen", "ConkerPlops", "Norman", "Constantinopula" };
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();

            random.Next(1, 5);
            for (int i = 0; i < 3; i++)
            {
                
                if (i % 2 == 0)
                {
                    duck = new MallardDuck();
                    duck.Name = names[random.Next(0, 4)];
                    ducks.Add((MallardDuck) duck);

                }
                else if(i % 3 == 0)
                {
                    duck = new FunkyDuck();
                    duck.Name = names[random.Next(0, 4)];
                    ducks.Add((FunkyDuck)duck);
                }
                else 
                {
                    duck = new MallardDuck();
                    duck.Name = names[random.Next(0, 4)];
                    duck.ChangeFlyBehaviour(new FlyNoWings());
                    ducks.Add((MallardDuck)duck);
                }
            }
            int posX = 1, posY = 1;
            //gather ducks from created list
            foreach(Duck d in ducks)
            {
                posX+= 100;
                posY+= 50;
                Label label = new Label();
                label.Location = new Point(posX, posY);
                label.Text = $"{d.Name}";
                this.Controls.Add(label);

            }
            
            
        }
    }
}