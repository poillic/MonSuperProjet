 # Boucles
Cette suite d'exercice est dédiée à l'apprentissage des tableaux et continue l'apprentissage des boucles.

# Calcul de la somme d'un tableau de float

Écrivez une fonction nommée `CalculateSum` qui prend en paramètre un tableau de nombres à virgule flottante (`float`) et retourne la somme de tous les éléments du tableau.

Voici la signature de la fonction :

```csharp
public float CalculateSum(float[] array)
```

La fonction `CalculateSum` initialise une variable `res` à 0 pour stocker la somme. Ensuite, à l'aide d'une boucle `foreach`, elle parcourt tous les éléments du tableau `array`. À chaque itération, elle ajoute la valeur de l'élément à la variable `res`. En fin de boucle, elle retourne la valeur de `res`, qui est la somme totale des éléments du tableau.


```csharp
float[] numbers = { 1.5f, 2.3f, 3.7f, 4.1f };
float sum = CalculateSum(numbers);
Console.WriteLine("Somme des éléments : " + sum); // Résultat attendu : 11.6
```

# Calcul de la somme d'un tableau d'int

Écrivez une fonction nommée `CalculateSum` qui prend en paramètre un tableau de nombres entiers (`int`) et retourne la somme de tous les éléments du tableau.

Voici la signature de la fonction :

```csharp
public int CalculateSum(int[] array)
```

La fonction `CalculateSum` initialise une variable `res` à 0 pour stocker la somme. Ensuite, à l'aide d'une boucle `foreach`, elle parcourt tous les éléments du tableau `array`. À chaque itération, elle ajoute la valeur de l'élément à la variable `res`. En fin de boucle, elle retourne la valeur de `res`, qui est la somme totale des éléments du tableau.


```csharp
int[] numbers = { 1, 2, 3, 4 };
int sum = CalculateSum(numbers);
Console.WriteLine("Somme des éléments : " + sum); // Résultat attendu : 10
```

# Trouver le plus grand nombre dans un tableau

Écrivez une fonction nommée `BiggestNumber` qui prend en paramètre un tableau d'entiers (`int`) et retourne le plus grand nombre présent dans le tableau.

Voici la signature de la fonction :

```csharp
public int BiggestNumber(int[] array)
```

La fonction `BiggestNumber` initialise une variable `res` avec la première valeur du tableau `array`. Ensuite, à l'aide d'une boucle `for`, elle parcourt les éléments du tableau à partir de l'indice 1. À chaque itération, elle compare la valeur de l'élément avec celle de la variable `res`. Si l'élément est plus grand que `res`, la variable `res` est mise à jour avec la nouvelle valeur. En fin de boucle, la fonction retourne la valeur de `res`, qui est le plus grand nombre dans le tableau.

```csharp
int[] numbers = { 5, 12, 3, 8, 10 };
int max = BiggestNumber(numbers);
Console.WriteLine("Plus grand nombre : " + max); // Résultat attendu : 12
```

# Trouver le plus petit nombre dans un tableau

Écrivez une fonction nommée `FindMinimum` qui prend en paramètre un tableau d'entiers (`int[]`) et retourne l'élément minimum du tableau.

Voici la signature de la fonction :
```csharp
public int FindMinimum(int[] array)
```


    
Résolvez cet exercice en utilisant une boucle `for` pour parcourir le tableau et une variable `res` pour stocker le minimum. Commencez par initialiser `res` avec la première valeur du tableau (`array[0]`). Ensuite, parcourez le reste du tableau et comparez chaque élément avec `res`. Si un élément est inférieur à `res`, mettez à jour la valeur de `res` avec cet élément.


Exemple d'utilisation :
```csharp
int[] numbers = { 5, 3, 8, 2, 1 };
int min = FindMinimum(numbers);
Console.WriteLine("Le minimum du tableau est : " + min);
```

Résultat :
```
Le minimum du tableau est : 1
```

# Trouver le mot le plus long dans un tableau

Écrivez une fonction nommée `LongestWord` qui prend en paramètre un tableau de chaînes de caractères (`string`) et retourne le mot le plus long présent dans le tableau.

Voici la signature de la fonction :

```csharp
public string LongestWord(string[] array)
```

La fonction `LongestWord` initialise une variable `res` avec la première chaîne de caractères du tableau `array`. Ensuite, à l'aide d'une boucle `for`, elle parcourt les éléments du tableau à partir de l'indice 1. À chaque itération, elle compare la longueur de la chaîne de caractères de l'élément avec celle de la variable `res`. Si la longueur de l'élément est supérieure à celle de `res`, la variable `res` est mise à jour avec la nouvelle chaîne de caractères. En fin de boucle, la fonction retourne la valeur de `res`, qui est le mot le plus long dans le tableau.

```csharp
string[] words = { "cat", "elephant", "dog", "giraffe" };
string longest = LongestWord(words);
Console.WriteLine("Mot le plus long : " + longest); // Résultat attendu : "elephant"
```

# Inverser un tableau

Écrivez une fonction nommée `ReverseArray` qui prend en paramètre un tableau d'entiers (`int[]`) et retourne un nouveau tableau contenant les mêmes éléments, mais dans l'ordre inverse.

Voici la signature de la fonction :

```csharp
public int[] ReverseArray(int[] array)
```

La fonction `ReverseArray` utilise deux variables `left` et `right` initialisées respectivement à 0 et à la longueur du tableau moins 1. Elle effectue ensuite une boucle `while` tant que `left` est inférieur à `right`. À chaque itération, elle effectue un échange entre les éléments aux indices `left` et `right` du tableau en utilisant une variable temporaire `tmp`. Ensuite, elle décrémente `right` et incrémente `left`. Ce processus se répète jusqu'à ce que `left` soit supérieur ou égal à `right`, ce qui signifie que tout le tableau a été inversé. Enfin, la fonction retourne le tableau inversé.

```csharp
int[] numbers = { 1, 2, 3, 4, 5 };
int[] reversed = ReverseArray(numbers);
Console.WriteLine("Tableau inversé : " + string.Join(", ", reversed)); // Résultat attendu : "5, 4, 3, 2, 1"
```

# Compter le nombre d'éléments

Écrivez une fonction nommée `CountOccurrences` qui prend en paramètres un tableau d'entiers `array` et un entier `number`. La fonction doit retourner le nombre d'occurrences de `number` dans le tableau `array`.

Voici la signature de la fonction :

```csharp
public int CountOccurrences(int[] array, int number)
```

Exemple d'utilisation :

```csharp
int[] numbers = { 2, 3, 2, 5, 2, 6, 2 };
int targetNumber = 2;

int count = CountOccurrences(numbers, targetNumber);
Console.WriteLine($"Le nombre d'occurrences de {targetNumber} dans le tableau est : {count}");
```

Résultat attendu :
```
Le nombre d'occurrences de 2 dans le tableau est : 4
```
