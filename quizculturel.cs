using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class quizculturel : Form
    {   //l'appel de cette classe fait lorsque en trouve deux carte differents
        int reponse_correct = 1; //numero de question correcte 
        int nbquestion = 0; //les nombres des question que je voudrais l'affichier 
        int score = 0; //score de question juste
        public quizculturel()
        {
            InitializeComponent();
            poser_question(nbquestion);
        }

        private void verifier_question(object sender, EventArgs e)
        {   //est une fonction verifie la reponse juste ou non 
            var senderObject = (Button)sender;
            int ButtonTag = Convert.ToInt32(senderObject.Tag);
            if (ButtonTag == reponse_correct)
            {

                score += 20;
                progressBar1.Value += 20;

            }


            if (nbquestion == 2)
            {

                MessageBox.Show(
                    "FIN DE QUIZ" + Environment.NewLine +
                    "TU A UN SCORE = " + score + Environment.NewLine +
                    "Click OK POUR RETOURNE A NOTRE JEUX GEUSSDIV"
                    );
                quizculturel.ActiveForm.Close();

                nbquestion = 0;
                poser_question(nbquestion);

            }
            nbquestion++;
            poser_question(nbquestion);


        }
        private void poser_question(int q)
        {   //est une fonction que contient 100 question et un nombre aleatoire
            Random aleatoire = new Random();
            q = aleatoire.Next(1, 80);
            switch (q)
            {
                case 1:


                    label1.Text = "De quelle ville Billie Eilish est-elle originaire";
                    button1.Text = "Newyork";
                    button2.Text = "Los Angeles";
                    button3.Text = "Liverpool";
                    button4.Text = "paris";
                    reponse_correct = 2;

                    break;

                case 2:

                    label1.Text = "Quel est le plus petit pays du monde ?";
                    button1.Text = "benin";
                    button2.Text = "angola";
                    button3.Text = "vatican";
                    button4.Text = "capvert";
                    reponse_correct = 3;

                    break;
                case 3:

                    label1.Text = "Quelle est la capitale du Canada ?";
                    button1.Text = "Ottawa";
                    button2.Text = "Syrie";
                    button3.Text = "Seychelles";
                    button4.Text = "Chypre";
                    reponse_correct = 1;

                    break;
                case 4:

                    label1.Text = "Dans quelle ville les premiers Jeux olympiques modernes se sont-ils tenus ?";
                    button1.Text = "Athenes, 1896";
                    button2.Text = "Allemagne,1875";
                    button3.Text = "Argentine,1892";
                    button4.Text = "Belgique,1984";
                    reponse_correct = 1;
                    break;

                case 5:

                    label1.Text = "En quelle annee Netflix a-t-il ete cree";
                    button1.Text = "1997";
                    button2.Text = "2001";
                    button3.Text = "2009";
                    button4.Text = "2015 ";
                    reponse_correct = 1;
                    break;
                case 6:

                    label1.Text = "Quel est le 6e Président de la Ve République française ?";
                    button1.Text = "Nicolas Sarkozy";
                    button2.Text = "Nicolas Dannel";
                    button3.Text = "Jacques Chirac";
                    button4.Text = " EmmanuelMacron";
                    reponse_correct = 1;
                    break;
                case 7:

                    label1.Text = "Citez le nom du premier film de Disney ";
                    button1.Text = "Aladin";
                    button2.Text = "Fantacia";
                    button3.Text = "blancheNiege ";
                    button4.Text = "belle et la béte ";
                    reponse_correct = 3;
                    break;
                case 8:

                    label1.Text = "Comment la société de vêtements Nike s’appelait-elle à l’origine ?";
                    button1.Text = " styleS";
                    button2.Text = "Blue Ribbon sports";
                    button3.Text = "Total look";
                    button4.Text = "tag mode";
                    reponse_correct = 2;
                    break;
                case 9:

                    label1.Text = "De combien de touches un piano classique est-il doté ?";
                    button1.Text = "121";
                    button2.Text = "66";
                    button3.Text = "89";
                    button4.Text = "88";
                    reponse_correct = 4;
                    break;
                case 10:

                    label1.Text = "Quelle langue comprend le plus grand nombre de mots";
                    button1.Text = "Francais";
                    button2.Text = " Espagnol";
                    button3.Text = "Anglais";
                    button4.Text = "Arabe";
                    reponse_correct = 3;
                    break;
                case 11:

                    label1.Text = "C++ a été développé par";
                    button1.Text = "Thomas Kushz";
                    button2.Text = "John Kemney";
                    button3.Text = "Bjarne Stroutstrup";
                    button4.Text = " James Goling";
                    reponse_correct = 3;
                    break;
                case 12:

                    label1.Text = "François-Marie Arouet est le nom de naissance de…";
                    button1.Text = "Voltaire";
                    button2.Text = "Diderot";
                    button3.Text = "Albert Camus";
                    button4.Text = "Albert David";
                    reponse_correct = 1;
                    break;
                case 13:

                    label1.Text = "En quelle année Napoléon a-t-il remporté la bataille d’Austerlitz ?";
                    button1.Text = "1804";
                    button2.Text = "1805";
                    button3.Text = "1806";
                    button4.Text = "1809";
                    reponse_correct = 2;
                    break;
                case 14:

                    label1.Text = "Si j’habite à Blois, je suis dans la région…";
                    button1.Text = "Centre";
                    button2.Text = "Centre Paris";
                    button3.Text = "Centre-France";
                    button4.Text = "Centre-Val-de-Loire";
                    reponse_correct = 4;
                    break;
                case 15:

                    label1.Text = "Le drapeau du Portugal est…";
                    button1.Text = "Orange, vert et bleu";
                    button2.Text = "Vert et rouge";
                    button3.Text = "Bleu et blanc";
                    button4.Text = " Noir et rouge";
                    reponse_correct = 2;
                    break;
                case 16:

                    label1.Text = "Dans le film Quatre mariages et un enterrement, qui joue le rôle de Charles ?";
                    button1.Text = "Hugh Grant";
                    button2.Text = "Rowan Salmano";
                    button3.Text = "Rowan Atkinson";
                    button4.Text = "Jude Law";
                    reponse_correct = 1;
                    break;
                case 17:

                    label1.Text = "Au bowling, combien de quilles se trouvent sur la dernière ligne ?";
                    button1.Text = "5";
                    button2.Text = "4";
                    button3.Text = "3";
                    button4.Text = "6";
                    reponse_correct = 2;
                    break;
                case 18:

                    label1.Text = "Le vent le plus fort jamais enregistré par une station météo soufflait à…";
                    button1.Text = "372 km/h";
                    button2.Text = "399 km/h";
                    button3.Text = "408 km/h";
                    button4.Text = "398 km/h";
                    reponse_correct = 3;
                    break;
                case 19:

                    label1.Text = "La chanson Cette année-là…, c’était quelle année au fait ?";
                    button1.Text = "1968";
                    button2.Text = "1963";
                    button3.Text = "1964";
                    button4.Text = "1962";
                    reponse_correct = 4;
                    break;

                case 20:

                    label1.Text = "J’ai arrêté d’apprendre […] ça me faisait mal aux dents.";
                    button1.Text = "l’alemand";
                    button2.Text = "l’allemand";
                    button3.Text = "l’Allemand";
                    button4.Text = "l’allemands";
                    reponse_correct = 2;
                    break;
                case 21:

                    label1.Text = "ADN est l’abréviation de…";
                    button1.Text = "atome de Newton";
                    button2.Text = "aminase dipeptidique nuclée";
                    button3.Text = "acide désoxyribonucléique";
                    button4.Text = "analyse des noyaux";
                    reponse_correct = 3;
                    break;
                case 22:

                    label1.Text = "Le watt est l’unité qui mesure…";
                    button1.Text = "La consommation électrique";
                    button2.Text = "L’énergie";
                    button3.Text = "La puissance";
                    button4.Text = "L’intensité lumineuse";
                    reponse_correct = 3;
                    break;
                case 23:

                    label1.Text = "Quel est le plus long fleuve du monde?";
                    button1.Text = "kongo";
                    button2.Text = "Lora";
                    button3.Text = "Amazon";
                    button4.Text = "nil";
                    reponse_correct = 4;
                    break;
                case 24:

                    label1.Text = "En quelle année l’entreprise suisse Chocolat Suchard a-t-elle été fondée ?";
                    button1.Text = "1826";
                    button2.Text = "1825";
                    button3.Text = "1823";
                    button4.Text = "1805";
                    reponse_correct = 1;
                    break;
                case 25:

                    label1.Text = "Quels sont les six pays fondateurs de la Communauté européenne du charbon et de l’acier ?";
                    button1.Text = "Allemagne, Belgique, France, Italie, Luxembourg et Pays-Bas";
                    button2.Text = "Italie, Espagne, Allemagne, Belgique, France et Pays-Bas";
                    button3.Text = "Italie,  Allemagne, Belgique et Pays-Bas";
                    button4.Text = "Espagne, Allemagne, Belgique, France, Italie et Pays-Bas";
                    reponse_correct = 1;
                    break;
                case 26:

                    label1.Text = "Quelle est la température moyenne de notre planète ?";
                    button1.Text = "25";
                    button2.Text = "24";
                    button3.Text = "15";
                    button4.Text = "14";
                    reponse_correct = 3;
                    break;
                case 27:

                    label1.Text = "Le koala est un animal qui vit uniquement en Australie. Il se nourrit…";
                    button1.Text = "de noix et de fruits";
                    button2.Text = "de pousses de bambou";
                    button3.Text = "de pousses";
                    button4.Text = "de feuilles d’eucalyptus";
                    reponse_correct = 4;
                    break;
                case 28:

                    label1.Text = "Combien de départements composaient l’ancienne région Lorraine ?";
                    button1.Text = "3";
                    button2.Text = "4";
                    button3.Text = "5";
                    button4.Text = "6";
                    reponse_correct = 2;
                    break;
                case 29:

                    label1.Text = "Quel objet transporte en permanence une habitante mystérieuse et intrigante de Twin Peaks ?";
                    button1.Text = "Un parapluie";
                    button2.Text = "Une bûche";
                    button3.Text = "Un journal";
                    button4.Text = "Un carton";
                    reponse_correct = 2;
                    break;
                case 30:

                    label1.Text = "La pomme de terre a été servie pour la première fois au roi de France par Parmentier en…";
                    button1.Text = "1785";
                    button2.Text = "1540";
                    button3.Text = "1783";
                    button4.Text = "1541";
                    reponse_correct = 1;
                    break;
                case 31:

                    label1.Text = "Quel duo pop a été le premier groupe occidental à jouer en République populaire de Chine ?";
                    button1.Text = "Wham";
                    button2.Text = "Simon and Garfunkel";
                    button3.Text = "Chas and Dave";
                    button4.Text = "Right Said Fred";
                    reponse_correct = 1;
                    break;
                case 32:

                    label1.Text = "En quelle année Louis Reard a-t-il inventé le bikini ?";
                    button1.Text = "1945";
                    button2.Text = "1944";
                    button3.Text = "1947";
                    button4.Text = "1946";
                    reponse_correct = 4;
                    break;
                case 33:

                    label1.Text = "En 1768, le capitaine James Cook partit explorer quel océan ?";
                    button1.Text = "l'océan Pacifique";
                    button2.Text = "océan Atlantique";
                    button3.Text = "océan Indien";
                    button4.Text = "océan Arctique";
                    reponse_correct = 1;
                    break;
                case 34:

                    label1.Text = "Quelle est la vitesse du son ?";
                    button1.Text = "120 km/h";
                    button2.Text = "1.200 km/h";
                    button3.Text = "240 km/h";
                    button4.Text = "1.220 km/h";
                    reponse_correct = 2;
                    break;
                case 35:

                    label1.Text = " Quelle est la température de surface moyenne sur Vénus?";
                    button1.Text = "450 ° C";
                    button2.Text = "470 ° C";
                    button3.Text = "460 ° C";
                    button4.Text = "480 ° C ";
                    reponse_correct = 3;
                    break;
                case 36:

                    label1.Text = "En quelle année le produit WD40 a-t-il été inventé par le chimiste Norm Larsen?";
                    button1.Text = "1953";
                    button2.Text = "1954";
                    button3.Text = "1952";
                    button4.Text = "1951";
                    reponse_correct = 1;
                    break;
                case 37:

                    label1.Text = "En quelle année les Beatles se sont-ils rendus aux États-Unis pour la première fois?";
                    button1.Text = "1965";
                    button2.Text = "1962";
                    button3.Text = "1964";
                    button4.Text = "1967";
                    reponse_correct = 3;
                    break;
                case 38:

                    label1.Text = "«Future Nostalgia» contenant le single «Don't Start Now» est le deuxième album studio de quel chanteur anglais?";
                    button1.Text = " Michael Jackson";
                    button2.Text = "Dua lipa";
                    button3.Text = "Bilie elish";
                    button4.Text = "Justin Bieber";
                    reponse_correct = 2;
                    break;
                case 39:

                    label1.Text = "Combien de buts en championnat Jurgen Klinsmann a-t-il marqués pour Tottenham Hotspur lors de la saison 1994/1995 de Premier";
                    button1.Text = "21";
                    button2.Text = "22";
                    button3.Text = "23";
                    button4.Text = "20";
                    reponse_correct = 1;
                    break;
                case 40:

                    label1.Text = "Combien de tournesols y avait-il dans la troisième version de Van Gogh du tableau «Tournesols»?";
                    button1.Text = "12";
                    button2.Text = "13";
                    button3.Text = "50";
                    button4.Text = "21";
                    reponse_correct = 1;
                    break;
                case 41:

                    label1.Text = "La fin de la Première Guerre mondiale";
                    button1.Text = "1916";
                    button2.Text = "1912";
                    button3.Text = "1918";
                    button4.Text = "1914";
                    reponse_correct = 3;
                    break;
                case 42:

                    label1.Text = "Quel âge avait Michael quand il est décédé tristement en 2009?";
                    button1.Text = "50";
                    button2.Text = "61";
                    button3.Text = "49";
                    button4.Text = "47";
                    reponse_correct = 1;
                    break;
                case 43:

                    label1.Text = "Quelle est la taille de la grille sur un jeu de Scrabble ";
                    button1.Text = "15 * 15";
                    button2.Text = "16 * 16";
                    button3.Text = "13 * 13";
                    button4.Text = " 12 * 12";
                    reponse_correct = 1;
                    break;
                case 44:

                    label1.Text = " Quel est le nom de la plus grande entreprise technologique de Corée du Sud?";
                    button1.Text = " Sumsung";
                    button2.Text = "Hawawi";
                    button3.Text = "Apple";
                    button4.Text = " Google";
                    reponse_correct = 1;
                    break;
                case 45:

                    label1.Text = "En quelle année le premier camion Tonka a-t-il été fabriqué";
                    button1.Text = "1945";
                    button2.Text = "1946";
                    button3.Text = "1947";
                    button4.Text = "1944";
                    reponse_correct = 3;
                    break;
                case 46:

                    label1.Text = "Combien de camées autoréférentiels Alfred Hitchcock a-t-il réalisés dans ses films ";
                    button1.Text = "37";
                    button2.Text = "33";
                    button3.Text = "35";
                    button4.Text = "34";
                    reponse_correct = 1;
                    break;
                case 47:

                    label1.Text = "Quel pays a remporté la Coupe du monde de 1982 en Espagne en battant l'Allemagne de l'Ouest 3-1?";
                    button1.Text = "Paris";
                    button2.Text = " Argentine";
                    button3.Text = "Italie";
                    button4.Text = " Russie";
                    reponse_correct = 3;
                    break;
                case 48:

                    label1.Text = "Combien de cœurs a une pieuvre?";
                    button1.Text = "3";
                    button2.Text = "4";
                    button3.Text = "2";
                    button4.Text = "5";
                    reponse_correct = 1;
                    break;
                case 49:

                    label1.Text = "Si la Terre était transformée en trou noir, quel serait le diamètre de son horizon d'événement?";
                    button1.Text = "62 mm";
                    button2.Text = " 22 mm";
                    button3.Text = "20 mm";
                    button4.Text = "23 mm";
                    reponse_correct = 3;
                    break;
                case 50:

                    label1.Text = "Quelle pop star américaine a eu le succès des charts 2015 avec les singles `` Sorry '' et `` Love Yourself ''?";
                    button1.Text = "Justin Bieber";
                    button2.Text = "Dua lipa";
                    button3.Text = "Miley Cyrus ";
                    button4.Text = " Émile Berliner";
                    reponse_correct = 1;
                    break;
                case 51:
                    label1.Text = "De quel courant philosophique Plotin est-il le grand représentant ?";
                    button1.Text = "Le néoplatonisme";
                    button2.Text = "Le scepticisme";
                    button3.Text = "Le stoïcisme";
                    button4.Text = "L'aristotélisme";
                    reponse_correct = 1;
                    break;
                case 52:
                    label1.Text = "Quelle pièce est absolument à protéger dans un jeu d’échec ";
                    button1.Text = " roi";
                    button2.Text = " dame";
                    button3.Text = "tours ";
                    button4.Text = "fous ";
                    reponse_correct = 1;
                    break;
                case 53:
                    label1.Text = "Combien y a-t-il de signes astrologiques chinois";
                    button1.Text = "13";
                    button2.Text = "20";
                    button3.Text = "12 ";
                    button4.Text = " 50";
                    reponse_correct = 3;
                    break;
                case 54:
                    label1.Text = "Combien de dieu trône a l’Olympe ";
                    button1.Text = "13";
                    button2.Text = "12";
                    button3.Text = " 20";
                    button4.Text = " 41";
                    reponse_correct = 2;
                    break;
                case 55:
                    label1.Text = "En quelle année est mort JFK";
                    button1.Text = "1996";
                    button2.Text = "1986";
                    button3.Text = "1869 ";
                    button4.Text = " 1963";
                    reponse_correct = 4;
                    break;
                case 56:
                    label1.Text = "Quel est le 2ème nom de l’hippocampe ?";
                    button1.Text = "Cheval";
                    button2.Text = "Vache";
                    button3.Text = "Cheval de mer ";
                    button4.Text = "Lion";
                    reponse_correct = 1;
                    break;
                case 57:
                    label1.Text = "Lequel des pays suivants a la plus petite masse terrestre ?";
                    button1.Text = "Bulgarie";
                    button2.Text = "Bangladesh";
                    button3.Text = " Autriche";
                    button4.Text = " Costa Rica";
                    reponse_correct = 4;
                    break;
                case 58:
                    label1.Text = "Lequel des pays suivants n'est pas un pays enclavé et a donc un accès à la mer ouverte ?";
                    button1.Text = " Malí";
                    button2.Text = "Portugal";
                    button3.Text = " Suiza  ";
                    button4.Text = " Zambia ";
                    reponse_correct = 2;
                    break;
                case 59:
                    label1.Text = "Quel pays n'est pas directement limitrophe de Arabie saoudite ?";
                    button1.Text = " Irak";
                    button2.Text = "Jordanie";
                    button3.Text = "Koweït ";
                    button4.Text = "Bahreïn  ";
                    reponse_correct = 4;
                    break;
                case 60:
                    label1.Text = "Lequel des pays suivants est une enclave, c'est-à-dire qu'il est entièrement entouré par un autre pays ?";
                    button1.Text = "Îles Cook";
                    button2.Text = " Lesotho";
                    button3.Text = "  Svalbard ";
                    button4.Text = "Nauru ";
                    reponse_correct = 2;
                    break;
                case 61:
                    label1.Text = "Combien y a-t-il d'îles aux Philippines ?";
                    button1.Text = " 7641";
                    button2.Text = "21200";
                    button3.Text = " 74521";
                    button4.Text = " 6301";
                    reponse_correct = 1;
                    break;
                case 62:
                    label1.Text = "Lequel des pays suivants a le plus petit nombre d'habitants ?";
                    button1.Text = "Estonie";
                    button2.Text = "Mongolie";
                    button3.Text = "Lituanie ";
                    button4.Text = " Serbie";
                    reponse_correct = 1;
                    break;
                case 63:
                    label1.Text = "Depuis quand l'Équateur est indépendante ?";
                    button1.Text = "1822";
                    button2.Text = "1863";
                    button3.Text = " 1856";
                    button4.Text = " 1821";
                    reponse_correct = 1;
                    break;
                case 64:
                    label1.Text = "Quelle est la capitale de Liberia ?";
                    button1.Text = "Gbarnga";
                    button2.Text = " Kakata";
                    button3.Text = "Liberia";
                    button4.Text = "Monrovia ";
                    reponse_correct = 4;
                    break;
                case 65:
                    label1.Text = "Dans quel pays se situe la ville d'Istanbul ?";
                    button1.Text = "Tunis";
                    button2.Text = "Libia";
                    button3.Text = " Turquie";
                    button4.Text = "Algérie ";
                    reponse_correct = 3;
                    break;
                case 66:
                    label1.Text = "Dans quelle ville des Etats-Unis la Maison-Blanche se trouve-t-elle ?";
                    button1.Text = " Chikago";
                    button2.Text = "Washington";
                    button3.Text = "Boston ";
                    button4.Text = " New york";
                    reponse_correct = 2;
                    break;
                case 67:
                    label1.Text = "De quel pays Londres est-elle la capitale ?";
                    button1.Text = " Royaume-Uni";
                    button2.Text = "Bahmas";
                    button3.Text = "Andorre ";
                    button4.Text = " Royaume ";
                    reponse_correct = 1;
                    break;
                case 68:
                    label1.Text = "Quelle est la capitale de l’Australie ?";
                    button1.Text = "Canberra";
                    button2.Text = "Sydney";
                    button3.Text = " Australia";
                    button4.Text = "Melbourne ";
                    reponse_correct = 1;
                    break;
                case 69:
                    label1.Text = "Quelle est la capitale du Brésil ?";
                    button1.Text = "Rio de Janeiro";
                    button2.Text = "Sao Paulo";
                    button3.Text = " Brasilia";
                    button4.Text = " Brésil";
                    reponse_correct = 3;
                    break;
                case 70:
                    label1.Text = "Quelle est la capitale de la Birmanie ?";
                    button1.Text = "Rangoon";
                    button2.Text = "Naypyidaw";
                    button3.Text = "Mandalay ";
                    button4.Text = "Birmanie ";
                    reponse_correct = 2;
                    break;
                case 71:
                    label1.Text = "Quelle est la capitale de la Nouvelle-Zélande ?";
                    button1.Text = "Wellington";
                    button2.Text = "Christchurch";
                    button3.Text = "Auckland ";
                    button4.Text = " Nouvelle-Zélande";
                    reponse_correct = 1;
                    break;
                case 72:
                    label1.Text = "Quelle est la capitale de la Turquie ?";
                    button1.Text = "Ankara";
                    button2.Text = "Istanbul";
                    button3.Text = "Izmir ";
                    button4.Text = " Turquie";
                    reponse_correct = 1;
                    break;
                case 73:
                    label1.Text = "Quelle est la capitale de l'Inde ?";
                    button1.Text = "New Delhi";
                    button2.Text = " India";
                    button3.Text = " Calcutta";
                    button4.Text = "Mumbai ";
                    reponse_correct = 1;
                    break;
                case 74:
                    label1.Text = "Quelle est la capitale du Nigeria ?";
                    button1.Text = "Port Harcourt";
                    button2.Text = "Lagos";
                    button3.Text = "Abuja ";
                    button4.Text = " Nigeria";
                    reponse_correct = 3;
                    break;
                case 75:
                    label1.Text = "Quelle est la capitale de la Suisse ?";
                    button1.Text = "Zurich";
                    button2.Text = "Genève";
                    button3.Text = " Suise";
                    button4.Text = "Berne ";
                    reponse_correct = 4;
                    break;
                case 76:
                    label1.Text = "Quelle est la capitale du Maroc ?";
                    button1.Text = "Maroc";
                    button2.Text = "Rabat";
                    button3.Text = " Casablanca";
                    button4.Text = " Marrakech";
                    reponse_correct = 2;
                    break;
                case 77:
                    label1.Text = "Quelle est la capitale du Pakistan ?";
                    button1.Text = " Pakistan";
                    button2.Text = "Islamabad";
                    button3.Text = " Karachi";
                    button4.Text = " Lahore";
                    reponse_correct = 2;
                    break;
                case 78:
                    label1.Text = "Quelle est la capitale du Belize ?";
                    button1.Text = "Belmopan";
                    button2.Text = "Belize";
                    button3.Text = " Belize City";
                    button4.Text = " Dangriga";
                    reponse_correct = 1;
                    break;
                case 79:
                    label1.Text = "Quelle est la capitale de la Bolivie ?";
                    button1.Text = "La Paz";
                    button2.Text = " Sucre";
                    button3.Text = " Trinidad";
                    button4.Text = " Bolivie";
                    reponse_correct = 2;
                    break;
                case 80:
                    label1.Text = "Quelle est la capitale de la Tanzanie";
                    button1.Text = "Dodoma";
                    button2.Text = "Tanga";
                    button3.Text = " Tanzanie";
                    button4.Text = "Dar es Salam ";
                    reponse_correct = 1;
                    break;
                case 81:
                    label1.Text = "";
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = " ";
                    button4.Text = " ";
                    reponse_correct = 1;
                    break;
            }
        }
    }
}
