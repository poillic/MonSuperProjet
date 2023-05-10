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

# Multiplier par 2
La fonction doit prendre en paramètre un float et retourner cette valeur multiplier par 2.
_Vous pouvez réutiliser une fonction déjà créer pour éviter la répétition de code_
Voici la signature de la fonction :

`public float Double( float number )`

# Périmètre d'un rectangle
La fonction doit retourner le périmètre d'un rectangle. Cette fonction prend en paramètre la width ( largeur ) et la hauteur ( height ) du rectangle et retourne son périmètre.

Voici la signature de la fonction :

`public float RectanglePerimeter( float width, float height )`

_Rappel : Le calcul d’un périmètre d’un rectangle consiste à mesurer la longueur du pourtour d’un rectangle, soit, la somme des longueurs des 4 côtés._

# Aire d'un rectangle
La fonction doit retourner l'aire d'un rectangle. Cette fonction prend en paramètre la width ( largeur ) et la hauteur ( height ) du rectangle et retourne son aire.

Voici la signature de la fonction :

`public float RectangleArea( float width, float height )`

_Rappel :  l’aire est une surface, elle représente la superficie de la forme géométrique, soit toute la partie intérieure de la figure._
