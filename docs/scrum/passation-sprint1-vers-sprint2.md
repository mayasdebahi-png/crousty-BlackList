# Passation : sprint 1 vers sprint 2

De : Mayas Debahi (Scrum Master du sprint 1)
Pour : Zhang Jiamo (Scrum Master du sprint 2)

## Où on en est

- Sprint 1 terminé : les 5 TODO (S1-01 à S1-05) sont fusionnés dans `main`.
- Les 5 issues du sprint sont fermées et les cartes sont dans « Fait » du tableau GitHub Projects « Sprint 1 ».
- Version v0.1 publiée (Release « Sprint 1 : Démarrer »).
- GitHub Actions est verte sur `main` : `dotnet test` donne 23 tests, 0 échec, 1 réussi, 22 ignorés (sprints suivants).
- Le compte rendu du sprint 1 est dans `docs/scrum/`.

## Points en suspens

- Chaque membre doit avoir au moins une pull request fusionnée : la plupart de celles du sprint 1 ont été écrites par Mayas.
- Un compte rendu par séance doit être rédigé dans `docs/scrum` (voir `MODELE-compte-rendu`).

## Pièges déjà rencontrés

- Lancer le site avec : `dotnet run --project src/CroustyClickCollect -p:UseAppHost=false` (Smart App Control bloque l'exécutable).
- Après une modification d'une vue Razor, arrêter (Ctrl+C) puis relancer le site.
- Pull request sur un fork : vérifier que le dépôt de base est celui de l'équipe (`mayasdebahi-png/crousty-BlackList`) et pas celui de l'enseignant.
- Arrêter MySQL avec le bouton « Stop » de XAMPP avant d'éteindre le PC : un arrêt brutal corrompt les tables Aria.
- Si MySQL est corrompu : arrêter MySQL puis `aria_chk -r` sur les fichiers `.MAI` de `C:\xampp\mysql\data\mysql`, et si une table n'est pas réparée, relancer avec `-o`. Ensuite, recréer les droits de `crousty_app` avec `GRANT` puis `FLUSH PRIVILEGES`.
- Le fichier `.env` reste sur chaque poste (il est dans `.gitignore`) : utilisateur `crousty_app`, mot de passe du script `sql/03-utilisateur-app.sql`.

## Comment on travaille

1. Une branche par TODO.
2. Une issue par TODO.
3. Une pull request reliée à l'issue (« Closes #n »).
4. Une relecture par un coéquipier, puis la fusion dans `main`.
5. La coche verte de GitHub Actions avant de fusionner.

## À faire en premier pour le sprint 2

1. Lire le sujet du sprint 2 dans `SPRINTS.md`.
2. Créer le tableau GitHub Projects « Sprint 2 » avec une carte par TODO.
3. Créer les issues et répartir les TODO entre les 3 membres.
4. Faire un point rapide avec l'équipe.