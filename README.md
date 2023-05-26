# Introduction
Bienvenue dans la mise à niveau de la formation Développeur Unity. Nous allons nous concentrer sur l’apprentissage de la programmation via le C#. Dans ce document vous aurez tous les énoncés des exercices à faire ranger par chapitre.
Chaque cours se présentera comme ceci :
- Présentation théorique de la nouvelle notion
- Reprise des exemples donnés dans le cours
- Exercices d’application
- Correction

# Maths - Nouveau projet
Dans votre projet, vous devez créer une nouvelle classe Maths dans laquelle vous coderez pour faire les exercices suivants.

# Maths - Les variables
Les premières lignes
Créer une variable pour chaque type suivant :
- `public int age = 10`
- `public float time = 10.3`
- `public string name = “Toto”`
- `public bool isOk = false`


Lancer ensuite le test unitaire Exercice1 pour tester votre code.

# Maths - Les opérateurs arithmétiques
Opérations arithmétiques
Vous devez créer 5 fonctions, une pour chaque opération arithmétique. 

Voici les signatures de ces fonctions : 
- `public int Add( int A, int B )` : Additionne A plus B
- `public int Substract( int A, int B )` : Soustrait A moins B
- `public float Multiply( float A, float B )` : Multiplie A par B
- `public float Divide( float A, float B )` : Divise A par B
- `public int Modulo( int A, int B )` : Divise A par B et renvoie le reste

Chacune de ces fonctions à un test associé, validez les 5 tests pour passer à la suite.

# Maths - Multiplier par 2
Vous devez écrire une fonction nommée `Double` qui prend en paramètre un nombre de type `float` et retourne cette valeur multipliée par 2. Vous pouvez réutiliser une fonction déjà créée pour éviter la répétition de code.

Voici la signature de la fonction :

```csharp
public float Double(float number)
```

Contraintes :
- Le paramètre `number` est un nombre de type `float`.
- Le résultat de la fonction doit être un nombre de type `float` représentant le double de la valeur fournie.

Exemple d'utilisation de la fonction :

```csharp
float inputNumber = 5.25f;
float doubledNumber = Double(inputNumber);
Console.WriteLine("Le nombre doublé est : " + doubledNumber);
```

Dans cet exemple, la fonction `Double` doit prendre le nombre `5.25` comme paramètre, le multiplier par 2, ce qui donnera `10.5`, puis renvoyer ce résultat. Le programme affichera donc "Le nombre doublé est : 10.5" dans la console.

À vous de coder la fonction `Double` en utilisant le paramètre `number` pour effectuer la multiplication par 2 et renvoyer le résultat.

# Maths - Périmètre d'un rectangle
Vous devez écrire une fonction nommée `RectanglePerimeter` qui prend en paramètre la largeur (`width`) et la hauteur (`height`) d'un rectangle et retourne son périmètre. Le périmètre d'un rectangle est la somme des longueurs des quatre côtés.

Voici la signature de la fonction :

```csharp
public float RectanglePerimeter(float width, float height)
```

Contraintes :
- Les paramètres `width` et `height` sont des nombres de type `float` représentant respectivement la largeur et la hauteur du rectangle.
- Le résultat de la fonction doit être un nombre de type `float` représentant le périmètre du rectangle.

Exemple d'utilisation de la fonction :

```csharp
float rectangleWidth = 4.5f;
float rectangleHeight = 3.2f;
float perimeter = RectanglePerimeter(rectangleWidth, rectangleHeight);
Console.WriteLine("Le périmètre du rectangle est : " + perimeter);
```

Dans cet exemple, la fonction `RectanglePerimeter` doit prendre la largeur `4.5` et la hauteur `3.2` du rectangle comme paramètres, calculer le périmètre en additionnant les longueurs des côtés (2 * largeur + 2 * hauteur), ce qui donnera `15.4`, puis renvoyer ce résultat. Le programme affichera donc "Le périmètre du rectangle est : 15.4" dans la console.

À vous de coder la fonction `RectanglePerimeter` en utilisant les paramètres `width` et `height` pour calculer le périmètre du rectangle et le renvoyer comme résultat.

# Maths - Aire d'un rectangle
Vous devez écrire une fonction nommée `RectangleArea` qui prend en paramètre la largeur (`width`) et la hauteur (`height`) d'un rectangle et retourne son aire. L'aire d'un rectangle représente la superficie de la forme géométrique, c'est-à-dire toute la partie intérieure de la figure.

Voici la signature de la fonction :

```csharp
public float RectangleArea(float width, float height)
```

Contraintes :
- Les paramètres `width` et `height` sont des nombres de type `float` représentant respectivement la largeur et la hauteur du rectangle.
- Le résultat de la fonction doit être un nombre de type `float` représentant l'aire du rectangle.

Exemple d'utilisation de la fonction :

```csharp
float rectangleWidth = 4.5f;
float rectangleHeight = 3.2f;
float area = RectangleArea(rectangleWidth, rectangleHeight);
Console.WriteLine("L'aire du rectangle est : " + area);
```

Dans cet exemple, la fonction `RectangleArea` doit prendre la largeur `4.5` et la hauteur `3.2` du rectangle comme paramètres, calculer l'aire en multipliant la largeur par la hauteur (largeur * hauteur), ce qui donnera `14.4`, puis renvoyer ce résultat. Le programme affichera donc "L'aire du rectangle est : 14.4" dans la console.

À vous de coder la fonction `RectangleArea` en utilisant les paramètres `width` et `height` pour calculer l'aire du rectangle et la renvoyer comme résultat.

# Maths - Calculer l'âge
Vous devez écrire une fonction nommée `CalculateAge` qui prend en paramètre l'année de naissance d'une personne et retourne son âge. Pour effectuer ce calcul, vous pouvez utiliser la méthode `DateTime.Now.Year` qui renvoie l'année en cours.

Voici la signature de la fonction :

```csharp
public int CalculateAge(int birthYear)
```

Contraintes :
- L'année de naissance (`birthYear`) est un entier positif.
- Assurez-vous de définir la variable `birthYear` correctement dans la signature de la fonction.
- Le résultat de la fonction doit être un entier représentant l'âge de la personne.

Exemple d'utilisation de la fonction :

```csharp
int yearOfBirth = 1990;
int age = CalculateAge(yearOfBirth);
Console.WriteLine("La personne a " + age + " ans.");
```

Dans cet exemple, si l'année en cours est 2023, la fonction `CalculateAge` doit calculer l'âge en soustrayant l'année de naissance (1990) de l'année en cours (2023), ce qui donnera un résultat de 33. Le programme affichera donc "La personne a 33 ans." dans la console.

À vous de coder la fonction `CalculateAge` en utilisant l'année de naissance fournie pour déterminer l'âge de la personne et le retourner comme résultat.

# Maths - Calculer le Body Mass Index ( IMC en français )
Vous devez écrire une fonction nommée `CalculateBMI` qui prend en paramètre la taille (`height`) et le poids (`mass`) d'une personne et retourne son indice de masse corporelle (IMC).

Voici la signature de la fonction :

```csharp
public float CalculateBMI(float height, float mass)
```

Contraintes :
- Les paramètres `height` et `mass` sont des nombres de type `float` représentant respectivement la taille (en mètres) et le poids (en kilogrammes) de la personne.
- Assurez-vous que la taille et le poids fournis sont des valeurs positives et non nulles. Si l'un des paramètres est invalide (inférieur ou égal à zéro), vous devez lever une exception de type `ArgumentException` avec un message d'erreur approprié.

Exemple d'utilisation de la fonction :

```csharp
float personHeight = 1.75f; // 1.75 mètres
float personWeight = 68.5f; // 68.5 kilogrammes
float bmi = CalculateBMI(personHeight, personWeight);
Console.WriteLine("L'IMC de la personne est : " + bmi);
```

Dans cet exemple, la fonction `CalculateBMI` doit prendre la taille `1.75` et le poids `68.5` de la personne comme paramètres, calculer l'indice de masse corporelle en utilisant la formule : poids (en kilogrammes) / (taille (en mètres) * taille (en mètres)), ce qui donnera un résultat d'environ `22.4`, puis renvoyer ce résultat. Le programme affichera donc "L'IMC de la personne est : 22.4" dans la console.

À vous de coder la fonction `CalculateBMI` en utilisant les paramètres `height` et `mass` pour calculer l'IMC de la personne et le renvoyer comme résultat.

# Maths - Conversion Celsius vers Farenheit
Vous devez écrire une fonction nommée `CelsiusToFahrenheit` qui prend en paramètre une température en degrés Celsius (`celsius`) et la convertit en degrés Fahrenheit.

Voici la signature de la fonction :

```csharp
public float CelsiusToFahrenheit(float celsius)
```

Contraintes :
- Le paramètre `celsius` est un nombre de type `float` représentant la température en degrés Celsius.
- La formule de conversion à utiliser est : Fahrenheit = Celsius * 9 / 5 + 32.
- Le résultat de la fonction doit être un nombre de type `float` représentant la température convertie en degrés Fahrenheit.

Exemple d'utilisation de la fonction :

```csharp
float temperatureCelsius = 25.0f;
float temperatureFahrenheit = CelsiusToFahrenheit(temperatureCelsius);
Console.WriteLine(temperatureCelsius + " degrés Celsius équivalent à " + temperatureFahrenheit + " degrés Fahrenheit.");
```

Dans cet exemple, la fonction `CelsiusToFahrenheit` doit prendre la température de `25.0` degrés Celsius comme paramètre, effectuer la conversion en utilisant la formule (25 * 9 / 5 + 32), ce qui donnera un résultat d'environ `77.0` degrés Fahrenheit, puis renvoyer ce résultat. Le programme affichera donc "25.0 degrés Celsius équivalent à 77.0 degrés Fahrenheit." dans la console.

À vous de coder la fonction `CelsiusToFahrenheit` en utilisant le paramètre `celsius` pour effectuer la conversion de température et renvoyer le résultat en degrés Fahrenheit.

# Maths - Conversion Farenheit vers Celsius
Vous devez écrire une fonction nommée `FahrenheitToCelsius` qui prend en paramètre une température en degrés Fahrenheit (`fahrenheit`) et la convertit en degrés Celsius.

Voici la signature de la fonction :

```csharp
public float FahrenheitToCelsius(float fahrenheit)
```

Contraintes :
- Le paramètre `fahrenheit` est un nombre de type `float` représentant la température en degrés Fahrenheit.
- La formule de conversion à utiliser est : Celsius = (Fahrenheit - 32) * 5 / 9.
- Le résultat de la fonction doit être un nombre de type `float` représentant la température convertie en degrés Celsius.

Exemple d'utilisation de la fonction :

```csharp
float temperatureFahrenheit = 77.0f;
float temperatureCelsius = FahrenheitToCelsius(temperatureFahrenheit);
Console.WriteLine(temperatureFahrenheit + " degrés Fahrenheit équivalent à " + temperatureCelsius + " degrés Celsius.");
```

Dans cet exemple, la fonction `FahrenheitToCelsius` doit prendre la température de `77.0` degrés Fahrenheit comme paramètre, effectuer la conversion en utilisant la formule ((77 - 32) * 5 / 9), ce qui donnera un résultat d'environ `25.0` degrés Celsius, puis renvoyer ce résultat. Le programme affichera donc "77.0 degrés Fahrenheit équivalent à 25.0 degrés Celsius." dans la console.

À vous de coder la fonction `FahrenheitToCelsius` en utilisant le paramètre `fahrenheit` pour effectuer la conversion de température et renvoyer le résultat en degrés Celsius.

# Clamp
