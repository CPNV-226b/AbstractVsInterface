namespace InterfaceVsAbstract
{
    //déclaration de l'interface
    //c'est un contrat (architecture)
    //imposé à toutes les classes qui désireront
    //l'implémenter
    public interface IPerson
    {
        //Un changement de signature ici, imposera les mêmes changements
        //à toutes les classes qui réalise l'interface
        public abstract string Name { get; set; }
        public abstract string DateOfBirth { get; }

        public abstract void Run(float distance, float pace);
    }
}
