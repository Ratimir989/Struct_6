using System;

namespace Struct_6
{
    class Accauntant
    {
        public bool AskForBonus(Position worker, int hours)
        {
            if ((int)worker < hours)
                return true;
            return false;
        }
    }
    enum Position { QualityAssurance = 40, ProjectManager = 60, HumanResources = 80, SeniorDeveloper = 100 }
    class Program
    {
        static void Main(string[] args)
        {
            Accauntant acc = new Accauntant();
            Position senDeveloer = Position.SeniorDeveloper;
            Console.WriteLine(acc.AskForBonus(senDeveloer, 101) ? "Senior Developer has premium" : "Senior Developer hasnt premium");
            Console.ReadKey();
        }
    }
}
