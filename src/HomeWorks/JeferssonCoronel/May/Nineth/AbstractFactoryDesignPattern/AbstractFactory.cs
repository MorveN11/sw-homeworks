namespace HomeWorks.JeferssonCoronel.May.Nineth.AbstractFactoryDesignPattern
{
    public interface IBuilding
    {
        void DefineBuildingLevel(int level);
        void DefineMaterial(string material);
        void Build();
    }

    public class SiberianBuilding : IBuilding
    {
        private int _level;
        private string _material = "wood";
        public void DefineBuildingLevel(int level)
        {
            _level = level;
        }

        public void DefineMaterial(string material)
        {
            _material = material;
        }

        public void Build()
        {
            Console.WriteLine("The level " + _level + " building was successfully constructed with the " + _material +
                              " material.");
        }
    }

    public class EgyptianBuilding : IBuilding
    {
        private int _level = 1;
        private string _material = "sand";
        public void DefineBuildingLevel(int level)
        {
            _level = level;
        }

        public void DefineMaterial(string material)
        {
            _material = material;
        }

        public void Build()
        {
            Console.WriteLine("The level " + _level + " building was successfully constructed with the " + _material +
                              " material.");
        }
    }

    public interface IMilitaryUnit
    {
        void GetDescription();
        void DefineLevel(int level);
        void DefineDamagePerAttack(int damagePercent);
        void Attack();
        void Defend();
    }

    public class SiberianMilitaryUnit : IMilitaryUnit
    {
        private int _level;
        private int _damagePercent = 10;

        public void GetDescription()
        {
            Console.WriteLine("The Siberian military unit of level " + _level + " with " + _damagePercent + "% damage " +
                              "attack was successfully created.");
        }

        public void DefineLevel(int level)
        {
            _level = level;
        }

        public void DefineDamagePerAttack(int damagePercent)
        {
            _damagePercent = damagePercent;
        }

        public void Attack()
        {
            Console.WriteLine("- The Siberian soldier attacks with his spear that inflicts " + _damagePercent +"% damage.");
        }

        public void Defend()
        {
            Console.WriteLine("- The Siberian soldier defends with a wooden board.");
        }
    }

    public class EgyptianMilitaryUnit : IMilitaryUnit
    {
        private int _level = 1;
        private int _damagePercent = 20;

        public void GetDescription()
        {
            Console.WriteLine("The Egyptian military unit of level " + _level + " with " + _damagePercent + "% damage " +
                              "attack was successfully created.");
        }

        public void DefineLevel(int level)
        {
            _level = level;
        }

        public void DefineDamagePerAttack(int damagePercent)
        {
            _damagePercent = damagePercent;
        }

        public void Attack()
        {
            Console.WriteLine("- The Egyptian soldier attacks with his sword that inflicts " + _damagePercent +"% damage.");
        }

        public void Defend()
        {
            Console.WriteLine("- The Siberian soldier defends with a shield.");
        }
    }

    public interface IFactoryCivilization
    {
        IBuilding CreateBuilding();
        IMilitaryUnit CreateMilitaryUnit();
    }

    public class SiberianFactory : IFactoryCivilization
    {
        public IBuilding CreateBuilding()
        {
            return new SiberianBuilding();
        }

        public IMilitaryUnit CreateMilitaryUnit()
        {
            return new SiberianMilitaryUnit();
        }
    }

    public class EgyptianFactory : IFactoryCivilization
    {
        public IBuilding CreateBuilding()
        {
            return new EgyptianBuilding();
        }

        public IMilitaryUnit CreateMilitaryUnit()
        {
            return new EgyptianMilitaryUnit();
        }
    }


    public class StrategyGame(IFactoryCivilization civilizationFactory)
    {
        public void InitBuildingConstruction(int level, string material) {
            IBuilding building = civilizationFactory.CreateBuilding();
            building.DefineBuildingLevel(level);
            building.DefineMaterial(material);
            building.Build();
        }

        public void InitMilitaryUnit(int level, int damagePercent) {
            IMilitaryUnit militaryUnit = civilizationFactory.CreateMilitaryUnit();
            militaryUnit.DefineLevel(level);
            militaryUnit.DefineDamagePerAttack(damagePercent);
            militaryUnit.GetDescription();
            militaryUnit.Attack();
            militaryUnit.Defend();
        }
    }

    public static class Program
    {
        static void Main(string[] args)
        {
            IFactoryCivilization egyptianCivilization = new EgyptianFactory();
            StrategyGame egyptianGame = new StrategyGame(egyptianCivilization);
            egyptianGame.InitBuildingConstruction(2, "stone");
            egyptianGame.InitMilitaryUnit(1, 23);

            Console.WriteLine("\n --------------------------- \n");

            IFactoryCivilization siberianCivilization = new SiberianFactory();
            StrategyGame siberianGame = new StrategyGame(siberianCivilization);
            siberianGame.InitBuildingConstruction(1, "hay");
            siberianGame.InitMilitaryUnit(4, 60);
        }
    }
}
