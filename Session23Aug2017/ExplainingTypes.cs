namespace ExplainingTypes
{
    interface ICoffeeMachine
    {
        public void AddCoffee();
        public void AddMilk();
    }

    class BasicCoffeeMachine: ICoffeeMachine
    {
        public void AddCoffee()
        {

        }

        public void AddMilk()
        {

        }
    }

    class McDonaldsCoffeeMachine: ICoffeeMachine
    {
        public void AddEspresso()
        {
            AddCoffee();
            AddWater();
        }

        public void AddCoffee()
        {

        }

        public void AddWater()
        {

        }

        public void AddMilk()
        {

        }

        public void AddWhippedCream()
        {

        }
    }

    class StarbucksCoffeeMachine: McDonaldsCoffeeMachine
    {

        public void AddCoffee()
        {
            
        }

        public void AddMilk()
        {
            
        }

        public void AddWater()
        {

        }

        public void AddCaramel()
        {

        }

        public void AddFerreroRocher()
        {

        }
    }
}