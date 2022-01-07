// See https://aka.ms/new-console-template for more information
using DesignPatterns.Composite;

Console.WriteLine("Hello, World!");

var compositeBase = new ItemComposite();

var receipt = new ItemLeaf("Receipt");
compositeBase.AddComponent(receipt);

var subComposite1 = new ItemComposite();
compositeBase.AddComponent(subComposite1);

var hammer = new ItemLeaf("Hammer");
subComposite1.AddComponent(hammer);

var subComposite2 = new ItemComposite();
compositeBase.AddComponent(subComposite2);

var subSubComposite1 = new ItemComposite();
subComposite2.AddComponent(subSubComposite1);

var phone = new ItemLeaf("Phone");
var headPhone = new ItemLeaf("Headphones");
subSubComposite1.AddComponent(phone);
subSubComposite1.AddComponent(headPhone);

var subSubComposite2 = new ItemComposite();
subComposite2.AddComponent(subSubComposite2);

var charger = new ItemLeaf("Charger");
subSubComposite2.AddComponent(charger);

compositeBase.Display();

var l = new List<IItemComponent>();

charger.Load(l);

Console.WriteLine("Fin");



// Gestion d'inventaire
// Implémenter le patter composite

// 2 types de containers : Consommables et les armes.
// Actions : Ajouter, supprimer une arme/un consommable et pouvoir récupérer la liste des consommables,
// la liste des armes ou la liste des items peu importe leur type.
// Gestion de la charge : 1 arme possède une charge utile (entre 1 et 10) et votre inventaire ne peut
// pas dépasser une charge de 100.
// Poches : Vous avez un nombre de poches finis (5) et vous ne pouvez donc pas embarquer plus de 5
// consommables
// L'api externe doit être "SIMPLE" !!

// Optionnel
// Implémenter la pattern composite avec la notion de génériques (List<T>) / LinQ.

