 # Conditions
Cette suite d'exercice est dédiée à l'apprentissage des conditions if, if/else, if/else if et les switch.

# Est Positif
Vous devez créer une fonction nommée `IsPositive` qui prend en paramètre un entier `number` et renvoie `true` si le nombre est positif, et `false` sinon.

Voici la signature de la fonction :

```csharp
public bool IsPositive(int number)
```

Contraintes :
- Le paramètre `number` est un entier que vous devez vérifier.
- Utilisez une condition pour vérifier si le nombre est supérieur à zéro.
- Si le nombre est supérieur à zéro, retournez `true`, sinon retournez `false`.

Exemple d'utilisation de la fonction :

```csharp
int num1 = 10;
bool result1 = IsPositive(num1);
Console.WriteLine("Le nombre " + num1 + " est positif : " + result1);
// Affiche : "Le nombre 10 est positif : True"

int num2 = -5;
bool result2 = IsPositive(num2);
Console.WriteLine("Le nombre " + num2 + " est positif : " + result2);
// Affiche : "Le nombre -5 est positif : False"
```

Dans cet exemple, la fonction `IsPositive` est appelée avec deux nombres différents. Dans le premier cas, le nombre `num1` est 10. La fonction vérifie si ce nombre est positif et retourne `true` car 10 est supérieur à zéro. Dans le deuxième cas, le nombre `num2` est -5. La fonction vérifie si ce nombre est positif et retourne `false` car -5 n'est pas supérieur à zéro.

À vous de coder la fonction `IsPositive` en utilisant une condition pour déterminer si le nombre `number` est positif ou non selon les contraintes données.

# Pair ou Impair
Vous devez créer une fonction nommée `IsEven` qui prend en paramètre un nombre entier et retourne `true` si le nombre est pair et `false` s'il est impair.

Voici la signature de la fonction :

```csharp
public bool IsEven(int number)
```

Contraintes :
- Le paramètre `number` est un nombre entier.
- Utilisez l'opérateur modulo `%` pour déterminer si le nombre est pair.
- Si le reste de la division de `number` par 2 est égal à 0, la fonction doit retourner `true`.
- Sinon, la fonction doit retourner `false`.

Exemple d'utilisation de la fonction :

```csharp
int nombre1 = 4;
bool estPair1 = IsEven(nombre1);
Console.WriteLine(nombre1 + " est pair ? " + estPair1); // Affiche : "4 est pair ? True"

int nombre2 = 7;
bool estPair2 = IsEven(nombre2);
Console.WriteLine(nombre2 + " est pair ? " + estPair2); // Affiche : "7 est pair ? False"
```

Dans cet exemple, la fonction `IsEven` est appelée avec deux nombres : `4` et `7`. Le premier nombre est pair, car le reste de la division par 2 est égal à 0, donc la fonction retourne `true`. Le deuxième nombre est impair, car le reste de la division par 2 n'est pas égal à 0, donc la fonction retourne `false`. Les résultats sont ensuite affichés à l'écran.

À vous de coder la fonction `IsEven` en utilisant l'opérateur modulo pour déterminer si le nombre est pair ou impair et renvoyer le résultat attendu.

# Le plus grand
Vous devez créer une fonction nommée `BiggerNumber` qui prend en paramètre deux nombres à virgule (`float`) et retourne le plus grand des deux nombres. Si les deux nombres sont égaux, la fonction doit retourner le premier nombre.

Voici la signature de la fonction :

```csharp
public float BiggerNumber(float number1, float number2)
```

Contraintes :
- Les paramètres `number1` et `number2` sont des nombres à virgule (`float`).
- Comparez les deux nombres pour déterminer le plus grand.
- Si `number1` est supérieur à `number2`, retournez `number1`.
- Si `number2` est supérieur à `number1`, retournez `number2`.
- Si les deux nombres sont égaux, retournez `number1`.

Exemple d'utilisation de la fonction :

```csharp
float num1 = 5.7f;
float num2 = 3.9f;
float plusGrand = BiggerNumber(num1, num2);
Console.WriteLine("Le plus grand nombre entre " + num1 + " et " + num2 + " est : " + plusGrand); // Affiche : "Le plus grand nombre entre 5.7 et 3.9 est : 5.7"

float num3 = 2.4f;
float num4 = 7.1f;
float plusGrand2 = BiggerNumber(num3, num4);
Console.WriteLine("Le plus grand nombre entre " + num3 + " et " + num4 + " est : " + plusGrand2); // Affiche : "Le plus grand nombre entre 2.4 et 7.1 est : 7.1"
```

Dans cet exemple, la fonction `BiggerNumber` est appelée avec deux paires de nombres (`num1` et `num2`, `num3` et `num4`). La fonction compare les nombres et retourne le plus grand des deux. Les résultats sont ensuite affichés à l'écran.

À vous de coder la fonction `BiggerNumber` en utilisant des instructions conditionnelles (`if`) pour comparer les nombres et renvoyer le résultat attendu.

# Impair et supérieur à 10
Vous devez créer une fonction nommée `OddAndMoreTen` qui prend en paramètre un nombre entier (`int`) et retourne `true` si le nombre est à la fois impair et supérieur à 10. Sinon, la fonction doit retourner `false`.

Voici la signature de la fonction :

```csharp
public bool OddAndMoreTen(int number)
```

Contraintes :
- Le paramètre `number` est un nombre entier.
- Utilisez des opérations conditionnelles pour vérifier si le nombre est impair et supérieur à 10.
- Si le nombre est impair et supérieur à 10, retournez `true`.
- Sinon, retournez `false`.

Exemple d'utilisation de la fonction :

```csharp
int nombre1 = 13;
bool resultat1 = OddAndMoreTen(nombre1);
Console.WriteLine(nombre1 + " est impair et supérieur à 10 ? " + resultat1); // Affiche : "13 est impair et supérieur à 10 ? True"

int nombre2 = 14;
bool resultat2 = OddAndMoreTen(nombre2);
Console.WriteLine(nombre2 + " est impair et supérieur à 10 ? " + resultat2); // Affiche : "14 est impair et supérieur à 10 ? False"

int nombre2 = 9;
bool resultat2 = OddAndMoreTen(nombre2);
Console.WriteLine(nombre2 + " est impair et supérieur à 10 ? " + resultat2); // Affiche : "9 est impair et supérieur à 10 ? False"
```

Dans cet exemple, la fonction `OddAndMoreTen` est appelée avec trois nombres : `13`, `14` et `9`. Le premier nombre est impair et supérieur à 10, donc la fonction retourne `true`. Le deuxième nombre n'est pas impair, donc la fonction retourne `false`. Le troisième nombre n'est pas supérieur à 10, la fonction retourn `false`. Les résultats sont ensuite affichés à l'écran.

À vous de coder la fonction `OddAndMoreTen` en utilisant des opérations conditionnelles (`if`) pour vérifier les conditions spécifiées et renvoyer le résultat attendu.

# Comparer trois nombres

Vous devez créer une fonction nommée `CompareThreeNumbers` qui prend en paramètre trois entiers `a`, `b` et `c`, et renvoie `true` si le premier nombre `a` est égal à l'un des deux autres nombres `b` ou `c`, sinon renvoie `false`.

Voici la signature de la fonction :

```csharp
public bool CompareThreeNumbers(int a, int b, int c)
```

Contraintes :
- Les paramètres `a`, `b` et `c` sont des entiers que vous devez comparer.
- Utilisez des conditions pour vérifier si `a` est égal à `b` ou à `c`.
- Si `a` est égal à `b` ou à `c`, retournez `true`, sinon retournez `false`.

Exemple d'utilisation de la fonction :

```csharp
int num1 = 10;
int num2 = 5;
int num3 = 10;
bool result1 = CompareThreeNumbers(num1, num2, num3);
Console.WriteLine("Le nombre " + num1 + " est égal à l'un des deux autres : " + result1);
// Affiche : "Le nombre 10 est égal à l'un des deux autres : True"

int num4 = 7;
int num5 = 3;
int num6 = 9;
bool result2 = CompareThreeNumbers(num4, num5, num6);
Console.WriteLine("Le nombre " + num4 + " est égal à l'un des deux autres : " + result2);
// Affiche : "Le nombre 7 est égal à l'un des deux autres : False"
```

Dans cet exemple, la fonction `CompareThreeNumbers` est appelée avec deux jeux de trois nombres différents. Dans le premier cas, le nombre `num1` est égal à `num3` (tous deux valent 10), donc la fonction retourne `true`. Dans le deuxième cas, le nombre `num4` n'est égal à aucun des deux autres nombres `num5` et `num6` (7 est différent de 3 et de 9), donc la fonction retourne `false`.

À vous de coder la fonction `CompareThreeNumbers` en utilisant des conditions pour comparer les trois nombres `a`, `b` et `c` selon les contraintes données.

# Multiple de 3 et de 5
Vous devez créer une fonction nommée `ThreeAndFive` qui prend en paramètre un nombre entier (`int`) et retourne `true` si le nombre est à la fois multiple de 3 et de 5. Sinon, la fonction doit retourner `false`.

Voici la signature de la fonction :

```csharp
public bool ThreeAndFive(int number)
```

Contraintes :
- Le paramètre `number` est un nombre entier.
- Utilisez des opérations conditionnelles pour vérifier si le nombre est à la fois multiple de 3 et de 5.
- Si le nombre est à la fois multiple de 3 et de 5, retournez `true`.
- Sinon, retournez `false`.

Exemple d'utilisation de la fonction :

```csharp
int nombre1 = 15;
bool resultat1 = ThreeAndFive(nombre1);
Console.WriteLine(nombre1 + " est multiple de 3 et de 5 ? " + resultat1); // Affiche : "15 est multiple de 3 et de 5 ? True"

int nombre2 = 9;
bool resultat2 = ThreeAndFive(nombre2);
Console.WriteLine(nombre2 + " est multiple de 3 et de 5 ? " + resultat2); // Affiche : "9 est multiple de 3 et de 5 ? False"
```

Dans cet exemple, la fonction `ThreeAndFive` est appelée avec deux nombres : `15` et `9`. Le premier nombre est à la fois multiple de 3 et de 5, donc la fonction retourne `true`. Le deuxième nombre n'est pas multiple de 3 et de 5, donc la fonction retourne `false`. Les résultats sont ensuite affichés à l'écran.

À vous de coder la fonction `ThreeAndFive` en utilisant des opérations conditionnelles (`if`) pour vérifier les conditions spécifiées et renvoyer le résultat attendu.

# Est multiple ?
Vous devez créer une fonction nommée `IsMultiple` qui prend en paramètre deux nombres entiers (`int`). Le premier nombre est le nombre à vérifier, et le deuxième nombre est le multiple.

La fonction doit retourner `true` si le premier nombre est un multiple du deuxième nombre, et `false` sinon.

Voici la signature de la fonction :

```csharp
public bool IsMultiple(int number, int multiple)
```

Contraintes :
- Les paramètres `number` et `multiple` sont des nombres entiers.
- Utilisez l'opération modulo `%` pour vérifier si `number` est un multiple de `multiple`.
- Si le reste de la division de `number` par `multiple` est égal à 0, la fonction doit retourner `true`.
- Sinon, la fonction doit retourner `false`.

Exemple d'utilisation de la fonction :

```csharp
int nombre1 = 12;
int multiple1 = 3;
bool resultat1 = IsMultiple(nombre1, multiple1);
Console.WriteLine(nombre1 + " est un multiple de " + multiple1 + " ? " + resultat1); // Affiche : "12 est un multiple de 3 ? True"

int nombre2 = 7;
int multiple2 = 4;
bool resultat2 = IsMultiple(nombre2, multiple2);
Console.WriteLine(nombre2 + " est un multiple de " + multiple2 + " ? " + resultat2); // Affiche : "7 est un multiple de 4 ? False"
```

Dans cet exemple, la fonction `IsMultiple` est appelée avec deux paires de nombres : (`12`, `3`) et (`7`, `4`). Le premier nombre de chaque paire est vérifié pour voir s'il est un multiple du deuxième nombre. Le premier nombre de la première paire (`12`) est un multiple de `3`, donc la fonction retourne `true`. Le premier nombre de la deuxième paire (`7`) n'est pas un multiple de `4`, donc la fonction retourne `false`. Les résultats sont ensuite affichés à l'écran.

À vous de coder la fonction `IsMultiple` en utilisant l'opération modulo pour vérifier si le premier nombre est un multiple du deuxième nombre et renvoyer le résultat attendu.

# Vérifier si un nombre est compris dans une plage

Écrivez une fonction nommée `IsInRange` qui prend en paramètre un entier `number`, une valeur minimale `min` et une valeur maximale `max`. La fonction doit renvoyer `true` si le nombre `number` est compris entre `min` et `max`, inclusivement. Sinon, elle doit renvoyer `false`.

Signature de la fonction :
```csharp
public bool IsInRange(int number, int min, int max)
```

Exemple d'utilisation :
```csharp
int num1 = 10;
bool result1 = IsInRange(num1, 5, 15);
Console.WriteLine("Le nombre " + num1 + " est compris entre 5 et 15 : " + result1);
// Affiche : "Le nombre 10 est compris entre 5 et 15 : True"

int num2 = 20;
bool result2 = IsInRange(num2, 5, 15);
Console.WriteLine("Le nombre " + num2 + " est compris entre 5 et 15 : " + result2);
// Affiche : "Le nombre 20 est compris entre 5 et 15 : False"
```

# Vérifier si une année est bissextile

Écrivez une fonction nommée `IsLeapYear` qui prend en paramètre une année `year` et renvoie `true` si cette année est bissextile, et `false` sinon. Une année est bissextile si elle est divisible par 4 mais non divisible par 100, sauf si elle est également divisible par 400.

Signature de la fonction :
```csharp
public bool IsLeapYear(int year)
```

Exemple d'utilisation :
```csharp
int year1 = 2020;
bool result1 = IsLeapYear(year1);
Console.WriteLine("L'année " + year1 + " est bissextile : " + result1);
// Affiche : "L'année 2020 est bissextile : True"

int year2 = 2022;
bool result2 = IsLeapYear(year2);
Console.WriteLine("L'année " + year2 + " est bissextile : " + result2);
// Affiche : "L'année 2022 est bissextile : False"
```

# Déterminer le plus grand parmi trois nombres

Écrivez une fonction nommée `MaxOfThreeNumbers` qui prend en paramètre trois entiers `a`, `b` et `c` et renvoie le plus grand nombre parmi les trois.

Signature de la fonction :
```csharp
public int MaxOfThreeNumbers(int a, int b, int c)
```

Exemple d'utilisation :
```csharp
int num1 = 10;
int num2 = 15;
int num3 = 7;
int result = MaxOfThreeNumbers(num1, num2, num3);
Console.WriteLine("Le plus grand nombre parmi " + num1 + ", " + num2 + " et " + num3 + " est : " + result);
// Affiche : "Le plus grand nombre parmi 10, 15 et 7 est : 15"
```

# Triangle Rectangle
Vous devez créer une fonction nommée `IsTriangleRectangle` qui prend en paramètre les longueurs des trois côtés d'un triangle (`int a, int b, int c`) et retourne `true` si le triangle est un triangle rectangle, ayant c pour hypothénuse, et `false` sinon. Vous pouvez supposer que les longueurs des côtés sont fournies dans l'ordre correct pour former un triangle.

Voici la signature de la fonction :

```csharp
public bool IsTriangleRectangle(int a, int b, int c)
```

Contraintes :
- Les paramètres `a`, `b` et `c` sont des nombres entiers représentant les longueurs des côtés d'un triangle.
- Utilisez le théorème de Pythagore pour vérifier si le triangle est rectangle.
- Si le carré de la longueur du côté le plus long est égal à la somme des carrés des longueurs des deux autres côtés, la fonction doit retourner `true`.
- Sinon, la fonction doit retourner `false`.

Exemple d'utilisation de la fonction :

```csharp
int a1 = 3, b1 = 4, c1 = 5;
bool resultat1 = IsTriangleRectangle(a1, b1, c1);
Console.WriteLine("Les côtés du triangle sont : " + a1 + ", " + b1 + ", " + c1);
Console.WriteLine("Est-ce un triangle rectangle ? " + resultat1); // Affiche : "Est-ce un triangle rectangle ? True" car 9 + 16 = 25

int a2 = 5, b2 = 12, c2 = 13;
bool resultat2 = IsTriangleRectangle(a2, b2, c2);
Console.WriteLine("Les côtés du triangle sont : " + a2 + ", " + b2 + ", " + c2);
Console.WriteLine("Est-ce un triangle rectangle ? " + resultat2); // Affiche : "Est-ce un triangle rectangle ? True" car 25 + 144 = 169

int a3 = 6, b3 = 8, c3 = 9;
bool resultat3 = IsTriangleRectangle(a3, b3, c3);
Console.WriteLine("Les côtés du triangle sont : " + a3 + ", " + b3 + ", " + c3);
Console.WriteLine("Est-ce un triangle rectangle ? " + resultat3); // Affiche : "Est-ce un triangle rectangle ? False" 36 + 64 != 81
```

Dans cet exemple, la fonction `IsTriangleRectangle` est appelée avec trois jeux de longueurs de côtés de triangle. Dans le premier cas, les longueurs des côtés sont `3`, `4` et `5`, ce qui correspond à un triangle rectangle (3^2 + 4^2 = 5^2). La fonction retourne donc `true`. Dans le deuxième cas, les longueurs des côtés sont `5`, `12` et `13`, également correspondant à un triangle rectangle. La fonction retourne encore `true`. Dans le troisième cas, les longueurs des côtés sont `6`, `8` et `10`, ce qui ne correspond pas à un triangle rectangle. La fonction retourne donc `false`. Les résultats sont ensuite affichés à l'écran.

À vous de coder la fonction `IsTriangleRectangle` en utilisant le théorème de Pythagore pour vérifier si le triangle est rectangle et renvoyer le résultat attendu.

# Voyelles
Énoncé de l'exercice - Vérifier si un caractère est une voyelle

Vous devez créer une fonction nommée `IsVowel` qui prend en paramètre un caractère (`char lettre`) et retourne `true` si le caractère est une voyelle (a, e, i, o, u, en minuscules ou en majuscules), et `false` sinon.

Voici la signature de la fonction :

```csharp
public bool IsVowel(char lettre)
```

Contraintes :
- Le paramètre `lettre` est un caractère représentant une lettre de l'alphabet.
- Assurez-vous de gérer les lettres en minuscules et en majuscules.
- Utilisez une comparaison avec les voyelles a, e, i, o, u (en minuscules ou en majuscules) pour déterminer si la lettre est une voyelle.
- Si la lettre est une voyelle, la fonction doit retourner `true`.
- Sinon, la fonction doit retourner `false`.

Exemple d'utilisation de la fonction :

```csharp
char lettre1 = 'A';
bool resultat1 = IsVowel(lettre1);
Console.WriteLine("La lettre " + lettre1 + " est une voyelle ? " + resultat1); // Affiche : "La lettre A est une voyelle ? True"

char lettre2 = 'b';
bool resultat2 = IsVowel(lettre2);
Console.WriteLine("La lettre " + lettre2 + " est une voyelle ? " + resultat2); // Affiche : "La lettre b est une voyelle ? False"

char lettre3 = 'e';
bool resultat3 = IsVowel(lettre3);
Console.WriteLine("La lettre " + lettre3 + " est une voyelle ? " + resultat3); // Affiche : "La lettre e est une voyelle ? True"
```

Dans cet exemple, la fonction `IsVowel` est appelée avec trois caractères différents. La première lettre est 'A' (en majuscule), qui correspond à une voyelle. La fonction retourne donc `true`. La deuxième lettre est 'b', qui n'est pas une voyelle. La fonction retourne donc `false`. La troisième lettre est 'e' (en minuscule), qui est une voyelle. La fonction retourne donc `true`. Les résultats sont ensuite affichés à l'écran.

À vous de coder la fonction `IsVowel` en utilisant une comparaison avec les voyelles a, e, i, o, u (en minuscules ou en majuscules) pour déterminer si le caractère est une voyelle et renvoyer le résultat attendu.