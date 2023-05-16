 # Boucles
Cette suite d'exercice est dédiée à l'apprentissage des boucles while, for, foreach.

# Nombres Pairs
Énoncé de l'exercice - Afficher les nombres pairs

Vous devez créer une fonction nommée `ShowEvenNumbers` qui prend en paramètre un entier positif `n` et retourne une chaîne de caractères contenant tous les nombres pairs de 0 à `n`. Utilisez une boucle `for` pour résoudre cet exercice.

Voici la signature de la fonction :

```csharp
public string ShowEvenNumbers(int n)
```

Contraintes :
- Le paramètre `n` est un entier positif représentant la limite supérieure des nombres pairs à afficher.
- Utilisez une boucle `for` pour itérer de 0 à `n`.
- À chaque itération, vérifiez si le nombre courant est pair en utilisant l'opérateur modulo (`%`). Si le reste de la division par 2 est égal à 0, le nombre est pair.
- Si le nombre est pair, ajoutez-le à une chaîne de caractères en utilisant une séparation appropriée, comme un espace ou une virgule.
- À la fin de la boucle, retournez la chaîne de caractères contenant tous les nombres pairs.

Exemple d'utilisation de la fonction :

```csharp
int n1 = 10;
string result1 = ShowEvenNumbers(n1);
Console.WriteLine("Nombres pairs jusqu'à " + n1 + ": " + result1);
// Affiche : "Nombres pairs jusqu'à 10: 0 2 4 6 8 10"

int n2 = 5;
string result2 = ShowEvenNumbers(n2);
Console.WriteLine("Nombres pairs jusqu'à " + n2 + ": " + result2);
// Affiche : "Nombres pairs jusqu'à 5: 0 2 4"
```

Dans cet exemple, la fonction `ShowEvenNumbers` est appelée avec deux entiers différents. Dans le premier cas, `n` est égal à 10, ce qui signifie que les nombres pairs de 0 à 10 doivent être retournés sous forme de chaîne de caractères. Les nombres pairs de 0 à 10 sont 0, 2, 4, 6, 8 et 10. La fonction les retourne dans une chaîne de caractères séparés par un espace. Dans le deuxième cas, `n` est égal à 5, ce qui signifie que les nombres pairs de 0 à 5 doivent être retournés. Les nombres pairs de 0 à 5 sont 0, 2 et 4. La fonction les retourne également dans une chaîne de caractères séparés par un espace.

À vous de coder la fonction `ShowEvenNumbers` en utilisant une boucle `for`, l'opérateur modulo et une structure de contrôle conditionnelle pour construire la chaîne de caractères contenant les nombres pairs de 0 à `n` selon les contraintes données.

# Calculer la somme
Vous devez créer une fonction nommée `CalculateSum` qui prend en paramètre un entier positif `n` et retourne la somme des entiers de 1 à `n`. Utilisez une boucle `while` pour résoudre cet exercice.

Voici la signature de la fonction :

```csharp
public int CalculateSum(int n)
```

Contraintes :
- Le paramètre `n` est un entier positif représentant la limite supérieure des entiers à sommer.
- Initialisez une variable `sum` à 0 qui va stocker la somme.
- Utilisez une boucle `while` avec une condition pour itérer tant que le nombre courant est inférieur ou égal à `n`.
- À chaque itération, ajoutez le nombre courant à la variable `sum`.
- Augmentez le nombre courant de 1 à chaque itération.
- À la fin de la boucle, retournez la valeur de `sum`.

Exemple d'utilisation de la fonction :

```csharp
int n1 = 5;
int result1 = CalculateSum(n1);
Console.WriteLine("La somme des entiers de 1 à " + n1 + " est : " + result1);
// Affiche : "La somme des entiers de 1 à 5 est : 15"

int n2 = 10;
int result2 = CalculateSum(n2);
Console.WriteLine("La somme des entiers de 1 à " + n2 + " est : " + result2);
// Affiche : "La somme des entiers de 1 à 10 est : 55"
```

Dans cet exemple, la fonction `CalculateSum` est appelée avec deux entiers différents. Dans le premier cas, `n` est égal à 5, ce qui signifie que la somme des entiers de 1 à 5 doit être calculée. La somme des entiers de 1 à 5 est égale à 1 + 2 + 3 + 4 + 5 = 15. La fonction retourne donc la valeur 15. Dans le deuxième cas, `n` est égal à 10, ce qui signifie que la somme des entiers de 1 à 10 doit être calculée. La somme des entiers de 1 à 10 est égale à 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 = 55. La fonction retourne donc la valeur 55.

À vous de coder la fonction `CalculateSum` en utilisant une boucle `while` et une variable de somme pour calculer la somme des entiers de 1 à `n` selon les contraintes données.

# Compter les voyelles
Vous devez créer une fonction nommée `CountVowels` qui prend en paramètre une chaîne de caractères `text` et compte le nombre de voyelles (a, e, i, o, u) présentes dans la chaîne. Utilisez une boucle `foreach` pour résoudre cet exercice.

Voici la signature de la fonction :

```csharp
public int CountVowels(string text)
```

Contraintes :
- Le paramètre `text` est une chaîne de caractères dans laquelle vous devez compter les voyelles.
- Initialisez une variable `count` à 0 qui va stocker le nombre de voyelles.
- Utilisez une boucle `foreach` pour parcourir chaque caractère de la chaîne `text`.
- À chaque itération, vérifiez si le caractère courant est une voyelle (a, e, i, o, u), en utilisant une condition avec l'opérateur `||` pour combiner plusieurs comparaisons.
- Si le caractère courant est une voyelle, augmentez la valeur de `count` de 1.
- À la fin de la boucle, retournez la valeur de `count`.

Exemple d'utilisation de la fonction :

```csharp
string text1 = "Hello, world!";
int result1 = CountVowels(text1);
Console.WriteLine("Le nombre de voyelles dans la chaîne '" + text1 + "' est : " + result1);
// Affiche : "Le nombre de voyelles dans la chaîne 'Hello, world!' est : 3"

string text2 = "Programming is fun!";
int result2 = CountVowels(text2);
Console.WriteLine("Le nombre de voyelles dans la chaîne '" + text2 + "' est : " + result2);
// Affiche : "Le nombre de voyelles dans la chaîne 'Programming is fun!' est : 5"
```

Dans cet exemple, la fonction `CountVowels` est appelée avec deux chaînes de caractères différentes. Dans le premier cas, la chaîne `text1` est "Hello, world!". La fonction compte le nombre de voyelles dans cette chaîne et trouve qu'il y en a 3 (o, o, e). La fonction retourne donc la valeur 3. Dans le deuxième cas, la chaîne `text2` est "Programming is fun!". La fonction compte le nombre de voyelles dans cette chaîne et trouve qu'il y en a 5 (o, a, i, i, u). La fonction retourne donc la valeur 5.

À vous de coder la fonction `CountVowels` en utilisant une boucle `foreach` et une variable de comptage pour déterminer le nombre de voyelles dans la chaîne `text` selon les contraintes données.