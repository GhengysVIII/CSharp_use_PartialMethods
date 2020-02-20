namespace use_PartialMethods {

    // Partie 1
    partial class Voiture { // Dans une classe partielle obligé !
        
        partial void AuDemarrage(); // Déclaration de la signature de la methode partielle
                                    // Ne peut pas avoir de modificateur d'accès !
                                    // Doit avoir un type de retour void !
                                    // Peut être une methode statique
                                    

        public void Demarrer() => AuDemarrage(); // Methode d'accès à la methode partielle
                                                 // (On ne peut pas avoir accès à la methode partielle directement)
    }

    partial class Voiture { // Classe partielle bis

        partial void AuDemarrage() =>                // Corps de la methode partiel 
            System.Console.WriteLine("VROUUUUUM");
       
    }
}