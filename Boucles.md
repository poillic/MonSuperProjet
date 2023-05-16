 # Boucles
Cette suite d'exercice est d�di�e � l'apprentissage des boucles while, for, foreach.

# Nombres Pairs
�nonc� de l'exercice - Afficher les nombres pairs

Vous devez cr�er une fonction nomm�e `ShowEvenNumbers` qui prend en param�tre un entier positif `n` et retourne une cha�ne de caract�res contenant tous les nombres pairs de 0 � `n`. Utilisez une boucle `for` pour r�soudre cet exercice.

Voici la signature de la fonction :

```csharp
public string ShowEvenNumbers(int n)
```

Contraintes :
- Le param�tre `n` est un entier positif repr�sentant la limite sup�rieure des nombres pairs � afficher.
- Utilisez une boucle `for` pour it�rer de 0 � `n`.
- � chaque it�ration, v�rifiez si le nombre courant est pair en utilisant l'op�rateur modulo (`%`). Si le reste de la division par 2 est �gal � 0, le nombre est pair.
- Si le nombre est pair, ajoutez-le � une cha�ne de caract�res en utilisant une s�paration appropri�e, comme un espace ou une virgule.
- � la fin de la boucle, retournez la cha�ne de caract�res contenant tous les nombres pairs.

Exemple d'utilisation de la fonction :

```csharp
int n1 = 10;
string result1 = ShowEvenNumbers(n1);
Console.WriteLine("Nombres pairs jusqu'� " + n1 + ": " + result1);
// Affiche : "Nombres pairs jusqu'� 10: 0 2 4 6 8 10"

int n2 = 5;
string result2 = ShowEvenNumbers(n2);
Console.WriteLine("Nombres pairs jusqu'� " + n2 + ": " + result2);
// Affiche : "Nombres pairs jusqu'� 5: 0 2 4"
```

Dans cet exemple, la fonction `ShowEvenNumbers` est appel�e avec deux entiers diff�rents. Dans le premier cas, `n` est �gal � 10, ce qui signifie que les nombres pairs de 0 � 10 doivent �tre retourn�s sous forme de cha�ne de caract�res. Les nombres pairs de 0 � 10 sont 0, 2, 4, 6, 8 et 10. La fonction les retourne dans une cha�ne de caract�res s�par�s par un espace. Dans le deuxi�me cas, `n` est �gal � 5, ce qui signifie que les nombres pairs de 0 � 5 doivent �tre retourn�s. Les nombres pairs de 0 � 5 sont 0, 2 et 4. La fonction les retourne �galement dans une cha�ne de caract�res s�par�s par un espace.

� vous de coder la fonction `ShowEvenNumbers` en utilisant une boucle `for`, l'op�rateur modulo et une structure de contr�le conditionnelle pour construire la cha�ne de caract�res contenant les nombres pairs de 0 � `n` selon les contraintes donn�es.

# Calculer la somme
Vous devez cr�er une fonction nomm�e `CalculateSum` qui prend en param�tre un entier positif `n` et retourne la somme des entiers de 1 � `n`. Utilisez une boucle `while` pour r�soudre cet exercice.

Voici la signature de la fonction :

```csharp
public int CalculateSum(int n)
```

Contraintes :
- Le param�tre `n` est un entier positif repr�sentant la limite sup�rieure des entiers � sommer.
- Initialisez une variable `sum` � 0 qui va stocker la somme.
- Utilisez une boucle `while` avec une condition pour it�rer tant que le nombre courant est inf�rieur ou �gal � `n`.
- � chaque it�ration, ajoutez le nombre courant � la variable `sum`.
- Augmentez le nombre courant de 1 � chaque it�ration.
- � la fin de la boucle, retournez la valeur de `sum`.

Exemple d'utilisation de la fonction :

```csharp
int n1 = 5;
int result1 = CalculateSum(n1);
Console.WriteLine("La somme des entiers de 1 � " + n1 + " est : " + result1);
// Affiche : "La somme des entiers de 1 � 5 est : 15"

int n2 = 10;
int result2 = CalculateSum(n2);
Console.WriteLine("La somme des entiers de 1 � " + n2 + " est : " + result2);
// Affiche : "La somme des entiers de 1 � 10 est : 55"
```

Dans cet exemple, la fonction `CalculateSum` est appel�e avec deux entiers diff�rents. Dans le premier cas, `n` est �gal � 5, ce qui signifie que la somme des entiers de 1 � 5 doit �tre calcul�e. La somme des entiers de 1 � 5 est �gale � 1 + 2 + 3 + 4 + 5 = 15. La fonction retourne donc la valeur 15. Dans le deuxi�me cas, `n` est �gal � 10, ce qui signifie que la somme des entiers de 1 � 10 doit �tre calcul�e. La somme des entiers de 1 � 10 est �gale � 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 = 55. La fonction retourne donc la valeur 55.

� vous de coder la fonction `CalculateSum` en utilisant une boucle `while` et une variable de somme pour calculer la somme des entiers de 1 � `n` selon les contraintes donn�es.

# Compter les voyelles
Vous devez cr�er une fonction nomm�e `CountVowels` qui prend en param�tre une cha�ne de caract�res `text` et compte le nombre de voyelles (a, e, i, o, u) pr�sentes dans la cha�ne. Utilisez une boucle `foreach` pour r�soudre cet exercice.

Voici la signature de la fonction :

```csharp
public int CountVowels(string text)
```

Contraintes :
- Le param�tre `text` est une cha�ne de caract�res dans laquelle vous devez compter les voyelles.
- Initialisez une variable `count` � 0 qui va stocker le nombre de voyelles.
- Utilisez une boucle `foreach` pour parcourir chaque caract�re de la cha�ne `text`.
- � chaque it�ration, v�rifiez si le caract�re courant est une voyelle (a, e, i, o, u), en utilisant une condition avec l'op�rateur `||` pour combiner plusieurs comparaisons.
- Si le caract�re courant est une voyelle, augmentez la valeur de `count` de 1.
- � la fin de la boucle, retournez la valeur de `count`.

Exemple d'utilisation de la fonction :

```csharp
string text1 = "Hello, world!";
int result1 = CountVowels(text1);
Console.WriteLine("Le nombre de voyelles dans la cha�ne '" + text1 + "' est : " + result1);
// Affiche : "Le nombre de voyelles dans la cha�ne 'Hello, world!' est : 3"

string text2 = "Programming is fun!";
int result2 = CountVowels(text2);
Console.WriteLine("Le nombre de voyelles dans la cha�ne '" + text2 + "' est : " + result2);
// Affiche : "Le nombre de voyelles dans la cha�ne 'Programming is fun!' est : 5"
```

Dans cet exemple, la fonction `CountVowels` est appel�e avec deux cha�nes de caract�res diff�rentes. Dans le premier cas, la cha�ne `text1` est "Hello, world!". La fonction compte le nombre de voyelles dans cette cha�ne et trouve qu'il y en a 3 (o, o, e). La fonction retourne donc la valeur 3. Dans le deuxi�me cas, la cha�ne `text2` est "Programming is fun!". La fonction compte le nombre de voyelles dans cette cha�ne et trouve qu'il y en a 5 (o, a, i, i, u). La fonction retourne donc la valeur 5.

� vous de coder la fonction `CountVowels` en utilisant une boucle `foreach` et une variable de comptage pour d�terminer le nombre de voyelles dans la cha�ne `text` selon les contraintes donn�es.