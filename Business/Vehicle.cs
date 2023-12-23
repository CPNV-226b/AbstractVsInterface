namespace InterfaceVsAbstract
{
    //déclaration "abstraite" de la classe
    public abstract class Vehicle
    {
        private bool _engineStatus = false;
        private string _brand;
        private string _model;

        //Cette méthode n'est pas implémenté (abstraite), c'est à l'enfant (classe fille)
        //de le faire
        public abstract string Brand { get;}

        //Cette méthode est implémentée dans la classe abstraite,
        //l'enfant (classe ville) va en hérité (pas besoin de la re-coder)
        public string Model
        {
            get
            {
                return _model.ToUpper();
            }
        }

        //Cette méthode n'est pas implémenté (abstraite), c'est à l'enfant (classe fille)
        //de le faire
        public abstract void StartEngine();

        //Cette méthode est implémentée dans la classe abstraite,
        //l'enfant (classe ville) va en hérité (pas besoin de la re-coder)
        public void StopEngine()
        {
            _engineStatus = false;
        }
    }
}
