 # Boucles
Cette suite d'exercice est d�di�e � l'apprentissage des tableaux et continue l'apprentissage des boucles.

# Calcul de la somme d'un tableau de float

�crivez une fonction nomm�e `CalculateSum` qui prend en param�tre un tableau de nombres � virgule flottante (`float`) et retourne la somme de tous les �l�ments du tableau.

Voici la signature de la fonction :

```csharp
public float CalculateSum(float[] array)
```

La fonction `CalculateSum` initialise une variable `res` � 0 pour stocker la somme. Ensuite, � l'aide d'une boucle `foreach`, elle parcourt tous les �l�ments du tableau `array`. � chaque it�ration, elle ajoute la valeur de l'�l�ment � la variable `res`. En fin de boucle, elle retourne la valeur de `res`, qui est la somme totale des �l�ments du tableau.


```csharp
float[] numbers = { 1.5f, 2.3f, 3.7f, 4.1f };
float sum = CalculateSum(numbers);
Console.WriteLine("Somme des �l�ments : " + sum); // R�sultat attendu : 11.6
```

# Calcul de la somme d'un tableau d'int

�crivez une fonction nomm�e `CalculateSum` qui prend en param�tre un tableau de nombres entiers (`int`) et retourne la somme de tous les �l�ments du tableau.

Voici la signature de la fonction :

```csharp
public int CalculateSum(int[] array)
```

La fonction `CalculateSum` initialise une variable `res` � 0 pour stocker la somme. Ensuite, � l'aide d'une boucle `foreach`, elle parcourt tous les �l�ments du tableau `array`. � chaque it�ration, elle ajoute la valeur de l'�l�ment � la variable `res`. En fin de boucle, elle retourne la valeur de `res`, qui est la somme totale des �l�ments du tableau.


```csharp
int[] numbers = { 1, 2, 3, 4 };
int sum = CalculateSum(numbers);
Console.WriteLine("Somme des �l�ments : " + sum); // R�sultat attendu : 10
```

# Trouver le plus grand nombre dans un tableau

�crivez une fonction nomm�e `BiggestNumber` qui prend en param�tre un tableau d'entiers (`int`) et retourne le plus grand nombre pr�sent dans le tableau.

Voici la signature de la fonction :

```csharp
public int BiggestNumber(int[] array)
```

La fonction `BiggestNumber` initialise une variable `res` avec la premi�re valeur du tableau `array`. Ensuite, � l'aide d'une boucle `for`, elle parcourt les �l�ments du tableau � partir de l'indice 1. � chaque it�ration, elle compare la valeur de l'�l�ment avec celle de la variable `res`. Si l'�l�ment est plus grand que `res`, la variable `res` est mise � jour avec la nouvelle valeur. En fin de boucle, la fonction retourne la valeur de `res`, qui est le plus grand nombre dans le tableau.

```csharp
int[] numbers = { 5, 12, 3, 8, 10 };
int max = BiggestNumber(numbers);
Console.WriteLine("Plus grand nombre : " + max); // R�sultat attendu : 12
```

# Trouver le plus petit nombre dans un tableau

�crivez une fonction nomm�e `FindMinimum` qui prend en param�tre un tableau d'entiers (`int[]`) et retourne l'�l�ment minimum du tableau.

Voici la signature de la fonction :
```csharp
public int FindMinimum(int[] array)
```


    
R�solvez cet exercice en utilisant une boucle `for` pour parcourir le tableau et une variable `res` pour stocker le minimum. Commencez par initialiser `res` avec la premi�re valeur du tableau (`array[0]`). Ensuite, parcourez le reste du tableau et comparez chaque �l�ment avec `res`. Si un �l�ment est inf�rieur � `res`, mettez � jour la valeur de `res` avec cet �l�ment.


Exemple d'utilisation :
```csharp
int[] numbers = { 5, 3, 8, 2, 1 };
int min = FindMinimum(numbers);
Console.WriteLine("Le minimum du tableau est : " + min);
```

R�sultat :
```
Le minimum du tableau est : 1
```

# Trouver le mot le plus long dans un tableau

�crivez une fonction nomm�e `LongestWord` qui prend en param�tre un tableau de cha�nes de caract�res (`string`) et retourne le mot le plus long pr�sent dans le tableau.

Voici la signature de la fonction :

```csharp
public string LongestWord(string[] array)
```

La fonction `LongestWord` initialise une variable `res` avec la premi�re cha�ne de caract�res du tableau `array`. Ensuite, � l'aide d'une boucle `for`, elle parcourt les �l�ments du tableau � partir de l'indice 1. � chaque it�ration, elle compare la longueur de la cha�ne de caract�res de l'�l�ment avec celle de la variable `res`. Si la longueur de l'�l�ment est sup�rieure � celle de `res`, la variable `res` est mise � jour avec la nouvelle cha�ne de caract�res. En fin de boucle, la fonction retourne la valeur de `res`, qui est le mot le plus long dans le tableau.

```csharp
string[] words = { "cat", "elephant", "dog", "giraffe" };
string longest = LongestWord(words);
Console.WriteLine("Mot le plus long : " + longest); // R�sultat attendu : "elephant"
```

# Inverser un tableau

�crivez une fonction nomm�e `ReverseArray` qui prend en param�tre un tableau d'entiers (`int[]`) et retourne un nouveau tableau contenant les m�mes �l�ments, mais dans l'ordre inverse.

Voici la signature de la fonction :

```csharp
public int[] ReverseArray(int[] array)
```

La fonction `ReverseArray` utilise deux variables `left` et `right` initialis�es respectivement � 0 et � la longueur du tableau moins 1. Elle effectue ensuite une boucle `while` tant que `left` est inf�rieur � `right`. � chaque it�ration, elle effectue un �change entre les �l�ments aux indices `left` et `right` du tableau en utilisant une variable temporaire `tmp`. Ensuite, elle d�cr�mente `right` et incr�mente `left`. Ce processus se r�p�te jusqu'� ce que `left` soit sup�rieur ou �gal � `right`, ce qui signifie que tout le tableau a �t� invers�. Enfin, la fonction retourne le tableau invers�.

```csharp
int[] numbers = { 1, 2, 3, 4, 5 };
int[] reversed = ReverseArray(numbers);
Console.WriteLine("Tableau invers� : " + string.Join(", ", reversed)); // R�sultat attendu : "5, 4, 3, 2, 1"
```

# Compter le nombre d'�l�ments

�crivez une fonction nomm�e `CountOccurrences` qui prend en param�tres un tableau d'entiers `array` et un entier `number`. La fonction doit retourner le nombre d'occurrences de `number` dans le tableau `array`.

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

R�sultat attendu :
```
Le nombre d'occurrences de 2 dans le tableau est : 4
```
