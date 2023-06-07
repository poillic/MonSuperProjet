 # Boucles
Cette suite d'exercice est dédiée à l'apprentissage des boucles while, for, foreach.

# Afficher les nombres de 1 à 10

Description:
Écrivez une fonction nommée `ShowOneToTen` qui construit une chaîne de caractères avec mes nombres de 1 à 10. Utilisez une boucle `for` pour résoudre cet exercice.

Contraintes:
- Utilisez une boucle `for` pour itérer de 1 à 10 inclusivement.
- Affichez chaque nombre avec un espace après sauf si il s'agit du dernier.

Signature de la fonction:
```csharp
public string ShowOneToTen()
```

Exemple d'utilisation:
```csharp
ShowOneToTen();
```

Sortie attendue:
```
1 2 3 4 5 6 7 8 9 10
```

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

# Factorielle
Écrivez une fonction nommée `CalculateFactorial` qui prend en paramètre un entier positif `n` et retourne le factoriel de `n`. Le factoriel d'un nombre `n` est le produit de tous les entiers positifs de 1 à `n`.

Voici la signature de la fonction :

```csharp
public int CalculateFactorial(int n)
```

Exemple d'utilisation :
```csharp
int result = CalculateFactorial(5);
Console.WriteLine(result); // Affiche 120
```

Dans cet exercice, vous devez calculer le factoriel d'un nombre `n`. Le factoriel d'un nombre `n` est obtenu en multipliant tous les entiers positifs de 1 à `n`. Par exemple, le factoriel de 5 (représenté par `5!`) est égal à 1 * 2 * 3 * 4 * 5, soit 120. La fonction doit retourner le résultat du calcul.

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

# Les étoiles
Écrivez une fonction nommée `PrintStars` qui prend en paramètre un entier positif `n` et retourne une chaîne de caractères contenant `n` étoiles (*). Chaque étoile est séparée par un espace.

Voici la signature de la fonction :

```csharp
public string PrintStars(int n)
```

Exemple d'utilisation :
```csharp
string result = PrintStars(5);
Console.WriteLine(result); // Affiche "*****"
```

Dans cet exercice, vous devez générer une chaîne de caractères contenant `n` étoiles, en les séparant par un espace. Par exemple, si `n` est égal à 5, la fonction doit renvoyer la chaîne "*****".

# Un sur deux
Écrivez une fonction nommée `AlternativePrint` qui prend en paramètres un entier positif `n`, un caractère `first` et un caractère `second`. La fonction retourne une chaîne de caractères où les caractères `first` et `second` alternent en fonction de l'indice de la boucle. Si l'indice est pair, le caractère `first` est ajouté à la chaîne, sinon le caractère `second` est ajouté.

Voici la signature de la fonction :

```csharp
public string AlternativePrint(int n, char first, char second)
```

Exemple d'utilisation :
```csharp
string result = AlternativePrint(7, '*', '-');
Console.WriteLine(result); // Affiche "*-*-*-*"
```

Dans cet exercice, vous devez générer une chaîne de caractères de longueur `n` où les caractères `first` et `second` alternent. Si l'indice de la boucle est pair, vous devez ajouter le caractère `first` à la chaîne, sinon vous devez ajouter le caractère `second`. Par exemple, si `n` est égal à 7, `first` est le caractère "*" et `second` est le caractère "-", la fonction doit renvoyer la chaîne "*-+-+-+-".

# Générer une chaîne des puissances de 2

Description:
Écrivez une fonction nommée `GeneratePowerOfTwoString` qui prend en paramètre un entier positif `n`. Cette fonction doit générer et retourner une chaîne de caractères contenant les `n` premières puissances de 2, séparées par des sauts de ligne.

Contraintes:
- Utilisez une boucle `do-while` pour résoudre cet exercice.
- Assurez-vous de traiter correctement le cas où `n` est égal à zéro (0) ou négatif.

Signature de la fonction:
```csharp
public string GeneratePowerOfTwoString(int n)
```

Exemple d'utilisation:
```csharp
string result = GeneratePowerOfTwoString(5);
Console.WriteLine(result);
```

Sortie attendue:
```
1 2 4 8 16
```

Dans cet exemple, la fonction `GeneratePowerOfTwoString` est appelée avec `n` égal à 5. Elle génère une chaîne de caractères contenant les cinq premières puissances de 2 (1, 2, 4, 8, 16) séparées par des sauts de ligne. La chaîne résultante est ensuite affichée à l'aide de la fonction `Console.WriteLine`.