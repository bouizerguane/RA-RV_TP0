Titre : Promenade relaxante

Objectif :
Marcher dans la forêt pour se détendre et profiter de la nature.

Déroulement :
1.	Début : message à l’écran → « Utilisez W/A/S/D pour marcher et respirez profondément pour vous détendre. »
2.	Exploration : se déplacer librement à la première personne sur le terrain avec arbres et rochers.
3.	Ambiance : son de forêt en boucle (oiseaux) pour immersion.

-----------------------------------------------------------

Etapes suivies pour la création de la scène :

1.	Insertion d’un terrain.
2.	Importer ‘’URP Tree Models’’.
3.	Dans ‘’Inspector’’ de l’objet terrain :
    a.	Choisir Paint Terrain pour ajouter avec une broche des ‘’Raise or Lower Terrain’’.
    b.	Utiliser ‘’Paint Texture’’ pour ajouter une texture de type ‘’Grass’’, en ajoutant un layer.
    c.	Utiliser ‘’Paint tree’’ pour ajouter des arbres.
4.	Ajouter ‘’SkyBox’’ en cochant ‘’Frog’’, avec la modification de la densité.
5.	Pour se déplacer dans la forêt, nous allons ajouter l’asset ‘’ Starter Assets – FirstPerson’’.
    a.	Supprimer la caméra principale.
    b.	Ajouter l’objet ‘’ NestedParent_Unpack’’.
6.	Ajouter l’ambiance de la fôret :
    a.	Insérer un fichier mp3 contenant un son.
    b.	Insérer un ‘’Empty Object’’ et lui assigner le son ajouter, faire les réglages nécessaires. 
7.	Ajouter un texte de bienvenue contenant « Bienvenue ! Utilisez W/A/S/D pour marcher et respirez profondément pour vous détendre. » et après 5 secondes (ou le temps choisi), il disparaît automatiquement

