namespace InterfaceVsAbstract
{
    public class Truck : Vehicle
    {
        //la propriété Modèle est héritée de la classe abstraite
        //pas besoin de la re-coder

        //imposée par la classe abstraite, mais le comportement
        //est à coder
        public override string Brand => throw new NotImplementedException();

        //imposée par la classe abstraite
        public override void StartEngine()
        {
            throw new NotImplementedException();
        }

        //il s'agit d'une méthode supplémentaire à la classe abstraite
        public void CarryGoods()
        {
            throw new NotImplementedException();
        }
    }
}
