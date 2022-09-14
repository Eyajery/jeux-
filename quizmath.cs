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
    public partial class quizmath : Form
    {
        //meme raisonnement, dans le classe quizculturel, pour la classe quizmath mais l'appel de cette classe fait lorsque en trouve deux cartes identiques

        int reponse_correct = 1;
        int nbquestion = 0;
        int score = 0;
        public quizmath()
        {
            InitializeComponent();
            poser_question(nbquestion);
        }

        private void verifier_question(object sender, EventArgs e)
        {
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
                    "Click OK  POUR RETOURNE A NOTRE JEUX GEUSSDIV"
                    );

                quizmath.ActiveForm.Close();
                nbquestion = 0;
                poser_question(nbquestion);
            }
            nbquestion++;
            poser_question(nbquestion);
        }
        private void poser_question(int q)
        {
            Random aleatoire = new Random();
            q = aleatoire.Next(1, 60);
            switch (q)
            {

                case 1:
                    label1.Text = "Combien y a-t-il de dizaines dans 10 000 ?";
                    button1.Text = "1000 dizaines";
                    button2.Text = "10000 dizaines";
                    button3.Text = "100 dizaines";
                    button4.Text = "100000 dizaines";
                    reponse_correct = 1;
                    break;

                case 2:
                    label1.Text = "Trouvez deux nombres consécutifs dont la somme est 99.";
                    button1.Text = "29 et 60";
                    button2.Text = "39 et 50";
                    button3.Text = "49 et 50";
                    button4.Text = "23 et 65";
                    reponse_correct = 3;
                    break;

                case 3:
                    label1.Text = " On multiplie mon nombre de crayons par 3 et on soustrait 2. Le résultat est 31. Combien ai-je de crayons?";
                    button1.Text = "10 crayons";
                    button2.Text = "11 crayons";
                    button3.Text = "12 crayons";
                    button4.Text = "13 crayons";
                    reponse_correct = 2;
                    break;

                case 4:
                    label1.Text = "Additionnez mentalement 278 et 536.";
                    button1.Text = "812";
                    button2.Text = "813";
                    button3.Text = "814";
                    button4.Text = "815";
                    reponse_correct = 3;
                    break;

                case 5:
                    label1.Text = "Quel est le périmètre d’un triangle dont deux côtés mesurent 3 et 5 centimètres et dont le troisième côté est le triple du plus petit ?"; button1.Text = "17 centimètres";
                    button2.Text = "16 centimètres";
                    button3.Text = "15 centimètres";
                    button4.Text = "18 centimètres";
                    reponse_correct = 1;
                    break;

                case 6:
                    label1.Text = " Quel est le quart de 5 + 41 × 3 ?";
                    button1.Text = "32";
                    button2.Text = "33";
                    button3.Text = "34";
                    button4.Text = "45";
                    reponse_correct = 1;
                    break;

                case 7:
                    label1.Text = "Lyne est née le jeudi 3 avril.Quel jour de la semaine est le 30 avril suivant ?";
                    button1.Text = "Dimanche";
                    button2.Text = "Mercredi";
                    button3.Text = "Mardi";
                    button4.Text = "jeudi";
                    reponse_correct = 2;
                    break;

                case 8:
                    label1.Text = " On soustrait le tiers d’un nombre à son double. Le résultat est 10. Quel est ce nombre ";
                    button1.Text = "6";
                    button2.Text = "5";
                    button3.Text = "4";
                    button4.Text = "3";
                    reponse_correct = 1;
                    break;

                case 9:
                    label1.Text = " L’année 2014 est-elle un nombre divisible par?";
                    button1.Text = "2";
                    button2.Text = "3";
                    button3.Text = "4";
                    button4.Text = "6";
                    reponse_correct = 1;
                    break;

                case 10:
                    label1.Text = "Quelle est la somme des angles d’un triangle ?";
                    button1.Text = "90";
                    button2.Text = "360";
                    button3.Text = "180";
                    button4.Text = "210";
                    reponse_correct = 3;
                    break;

                case 11:
                    label1.Text = " Soustrayez mentalement 831 et 479.";
                    button1.Text = "352";
                    button2.Text = "351";
                    button3.Text = "350";
                    button4.Text = "349";
                    reponse_correct = 1;
                    break;

                case 12:
                    label1.Text = " Dans un champ, il y a des coqs et des chevaux.On compte 20 pattes.Combien y a-t-il de coqs au maximum?";
                    button1.Text = "5 coqs.Il doit y avoir au moins 2 chevaux.";
                    button2.Text = "6 coqs.Il doit y avoir au moins 2 chevaux.";
                    button3.Text = "5 coqs.Il doit y avoir au moins 3 chevaux.";
                    button4.Text = "6 coqs.Il doit y avoir au moins 3 chevaux.";
                    reponse_correct = 2;
                    break;

                case 13:
                    label1.Text = " Quel est le plus grand nombre divisible par 4 avant 159 ?";
                    button1.Text = "154";
                    button2.Text = "155";
                    button3.Text = "157";
                    button4.Text = "156";
                    reponse_correct = 4;
                    break;

                case 14:
                    label1.Text = " Deux nombres sont entre eux comme 3 est à 5. L’un est inférieur à 23 et l’autre est supérieur à 31. Quels sont ces deux nombres?";
                    button1.Text = "21 et 35";
                    button2.Text = "21 et 34";
                    button3.Text = "22 et 35";
                    button4.Text = "22 et 34";
                    reponse_correct = 1;
                    break;

                case 15:
                    label1.Text = "Quelle est la somme des angles d’un rectangle ?";
                    button1.Text = "90 degrés";
                    button2.Text = "180 degrés";
                    button3.Text = "210 degrés";
                    button4.Text = "360 degrés";
                    reponse_correct = 4;
                    break;

                case 16:
                    label1.Text = " Combien y a-t-il de mois qui ont au moins 4 jeudis dans un trimestre ?";
                    button1.Text = "3 mois";
                    button2.Text = "4 mois";
                    button3.Text = "5 mois";
                    button4.Text = "6 mois";
                    reponse_correct = 1;
                    break;

                case 17:
                    label1.Text = "J’ai un sac de perles.J’en donne 3, puis la moitié de ce qui me reste.J’ai encore 6 perles.Combien avais-je de perles?";
                    button1.Text = "13 perles";
                    button2.Text = "14 perles";
                    button3.Text = "15 perles";
                    button4.Text = "16 perles";
                    reponse_correct = 3;
                    break;

                case 18:
                    label1.Text = "Dans une grille de mots croisés 10 × 10, il y a 2 cases noires dans chaque ligne et dans chaque colonne.Combien peut-on écrire de lettres ?";
                    button1.Text = "70 lettres";
                    button2.Text = "75 lettres";
                    button3.Text = "80 lettres";
                    button4.Text = "85 lettres";
                    reponse_correct = 3;
                    break;

                case 19:
                    label1.Text = " Multipliez mentalement 189 et 6.";
                    button1.Text = "1134";
                    button2.Text = "1133";
                    button3.Text = "1132";
                    button4.Text = "1131";
                    reponse_correct = 1;
                    break;

                case 20:
                    label1.Text = "Deux carrés de même grandeur sont juxtaposés par un côté. Combien de côtés la nouvelle figure a-t-elle ?";
                    button1.Text = "5 côtés";
                    button2.Text = "4 côtés";
                    button3.Text = "3 côtés";
                    button4.Text = "2 côtés";
                    reponse_correct = 2;
                    break;

                case 21:
                    label1.Text = " À l’aide d’opérations, représentez 24 avec trois 3.";
                    button1.Text = " Une représentation est : 33 – 3.";
                    button2.Text = " Une représentation est : 33 – 2.";
                    button3.Text = " Une représentation est : 33 – 1.";
                    button4.Text = " Une représentation est : 33 .";
                    reponse_correct = 1;
                    break;

                case 22:
                    label1.Text = "Combien y a-t-il de carrés dans cette suite : 3, 6, 9, 12, …, 195, 198 ?";
                    button1.Text = "2 carrés : 9, 36";
                    button2.Text = "3 carrés : 9, 36, 81";
                    button3.Text = "4 carrés : 9, 36, 81, 144";
                    button4.Text = "5 carrés : 9, 36, 81, 144 ,162 ";
                    reponse_correct = 3;
                    break;

                case 23:
                    label1.Text = " Quel est le tiers du double de 36 ?";
                    button1.Text = "24";
                    button2.Text = "25";
                    button3.Text = "26";
                    button4.Text = "27";
                    reponse_correct = 1;
                    break;

                case 24:
                    label1.Text = "Combien peut-on compter de chiffres dans une feuille de calendrier d’un mois de mai ";
                    button1.Text = "51 chiffres";
                    button2.Text = "52 chiffres";
                    button3.Text = "53 chiffres";
                    button4.Text = "54 chiffres";
                    reponse_correct = 3;
                    break;

                case 25:
                    label1.Text = " Du sommet d’un triangle équilatéral, on abaisse une perpendiculaire sur la base. Comment s’appelle chacun des deux triangles formés ?";
                    button1.Text = " Triangle rectangle";
                    button2.Text = " Triangle isocèle";
                    button3.Text = " Triangle équilatéral";
                    button4.Text = " Triangle quelconque";
                    reponse_correct = 1;
                    break;

                case 26:
                    label1.Text = " Un nombre additionné à son quart donne 35. Quel est ce nombre ?";
                    button1.Text = "25";

                    button2.Text = "26";
                    button3.Text = "27";
                    button4.Text = "28";
                    reponse_correct = 4;
                    break;

                case 27:
                    label1.Text = "Si le 5 mars d’une année est un jeudi. Quel est le jour de la semaine du 5 avril suivant ";
                    button1.Text = "Dimanche";
                    button2.Text = "Lundi";
                    button3.Text = "Mardi";
                    button4.Text = "Mercredi";
                    reponse_correct = 1;
                    break;

                case 28:
                    label1.Text = "Quel est le deuxième plus petit nombre qui est divisible à la fois par 4 et par 5 ?";
                    button1.Text = "40";
                    button2.Text = "42";
                    button3.Text = "44";
                    button4.Text = "46";
                    reponse_correct = 1;
                    break;

                case 29:
                    label1.Text = " Trouvez deux nombres dont la différence est 2 et dont le produit est 63.";
                    button1.Text = "7 et 8";
                    button2.Text = "7 et 9";
                    button3.Text = "8 et 9";
                    button4.Text = "5 et 9";
                    reponse_correct = 2;
                    break;

                case 30:
                    label1.Text = " On trace deux diagonales dans un carré. Combien peut-on compter de triangles de deux parties ?";
                    button1.Text = "2 triangles";
                    button2.Text = "4 triangles";
                    button3.Text = "6 triangles";
                    button4.Text = "8 triangles";
                    reponse_correct = 2;
                    break;

                case 31:
                    label1.Text = " Quel est le nombre qui suit logiquement 3, 8, 12, 15, 17 ?";
                    button1.Text = " Le nombre est 18";
                    button2.Text = " Le nombre est 19";
                    button3.Text = " Le nombre est 20";
                    button4.Text = " Le nombre est 21";
                    reponse_correct = 1;
                    break;

                case 32:
                    label1.Text = " Émile a 32 ans. Dans combien d’années, son âge sera-t-il un carré pour la troisième fois ?";
                    button1.Text = " Dans 22 ans";
                    button2.Text = "Dans 32 ans";
                    button3.Text = " Dans 42 ans";
                    button4.Text = "Dans 52 ans";
                    reponse_correct = 2;
                    break;

                case 33:
                    label1.Text = "Comment appelle-t-on le résultat d’une division ?";
                    button1.Text = "Quotient";
                    button2.Text = "résultat";
                    button3.Text = "diviseur";
                    button4.Text = "reste";
                    reponse_correct = 1;
                    break;

                case 34:
                    label1.Text = "Insérez un signe + ou – entre 2, 3, 4, 5, 6 sans en changer l’ordre. Le résultat doit être 0.";
                    button1.Text = " Une expression est : 2 –  3 – 4 + 5 – 6.";
                    button2.Text = " Une expression est : 2 + 3 + 4 + 5 – 6.";
                    button3.Text = " Une expression est : 2 + 3 – 4 + 5 – 6.";
                    button4.Text = " Une expression est : 2 + 3 – 4 + 5 + 6.";
                    reponse_correct = 3;
                    break;

                case 35:
                    label1.Text = "Combien peut-on compter de billes si on en trouve 5 sur chaque côté d’un triangle dont une à chaque intersection ?";
                    button1.Text = "10 billes";
                    button2.Text = "11 billes";
                    button3.Text = "12 billes";
                    button4.Text = "13 billes";
                    reponse_correct = 3;
                    break;

                case 36:
                    label1.Text = "Multipliez 25,25 par 100.";
                    button1.Text = "2525";
                    button2.Text = "25250";
                    button3.Text = "252500";
                    button4.Text = "2525000";
                    reponse_correct = 1;
                    break;

                case 37:
                    label1.Text = "Combien de fois peut-on soustraire 6 de 30 ?";
                    button1.Text = "1";
                    button2.Text = "2";
                    button3.Text = "3";
                    button4.Text = "4";
                    reponse_correct = 1;
                    break;

                case 38:
                    label1.Text = "Il faut 15 secondes pour lire un paragraphe. Combien de temps prendra-t-on pour lire 16 paragraphes de même longueur ?";
                    button1.Text = "2 minutes";
                    button2.Text = "4 minutes";
                    button3.Text = "6 minutes";
                    button4.Text = "8 minutes";

                    reponse_correct = 2;
                    break;

                case 39:
                    label1.Text = "Combien y a-t-il de centaines dans un million ?";
                    button1.Text = "10 0 centaines";
                    button2.Text = "10 00 centaines";
                    button3.Text = "10 000 centaines";
                    button4.Text = "100 000 centaines";

                    reponse_correct = 3;
                    break;

                case 40:
                    label1.Text = "Quelle est la figure géométrique qui correspond à la forme d’un dé à jouer ?";
                    button1.Text = "Cube";
                    button2.Text = "carré";
                    button3.Text = "triangle";
                    button4.Text = "rectangle";
                    reponse_correct = 1;
                    break;

                case 41:
                    label1.Text = "De quel nombre 24 est-il le tiers ?";
                    button1.Text = "70";
                    button2.Text = "71";
                    button3.Text = "72";
                    button4.Text = "73";
                    reponse_correct = 3;
                    break;

                case 42:
                    label1.Text = "Trouvez trois nombres consécutifs dont la somme est 66.";
                    button1.Text = "21, 22 et 23";
                    button2.Text = "20, 22 et 23";
                    button3.Text = "21, 22 et 24";
                    button4.Text = "21, 20 et 23";
                    reponse_correct = 1;
                    break;

                case 43:
                    label1.Text = " Marguerite a quatre filles. Chaque fille a deux frères. Combien y a-t-il d’enfants dans cette famille ?";
                    button1.Text = " 4 enfants";
                    button2.Text = "5 enfants";
                    button3.Text = "6 enfants";
                    button4.Text = "7 enfants";
                    reponse_correct = 3;
                    break;

                case 44:
                    label1.Text = " Vous écrivez SAMEDI à la suite. Quelle est la 20e lettre écrite ?";
                    button1.Text = "La lettre A";
                    button2.Text = " La lettre S";
                    button3.Text = " La lettre M";
                    button4.Text = " La lettre D";
                    reponse_correct = 1;
                    break;

                case 45:
                    label1.Text = "Comment s’appelle un polygone ayant 5 côtés ?";
                    button1.Text = " Pentagone";
                    button2.Text = "carre";
                    button3.Text = "rectangle";
                    button4.Text = "triangle";
                    reponse_correct = 1;
                    break;

                case 46:
                    label1.Text = "Quel est le plus petit nombre qui est formé de 4 lettres ?";
                    button1.Text = "0";
                    button2.Text = "1";
                    button3.Text = "2";
                    button4.Text = "3";
                    reponse_correct = 1;
                    break;

                case 47:
                    label1.Text = " On divise un nombre par 7. Le résultat est 3, reste 4. Quel est ce nombre ?";
                    button1.Text = "20";
                    button2.Text = "25";
                    button3.Text = "30";
                    button4.Text = "35";
                    reponse_correct = 2;
                    break;

                case 48:
                    label1.Text = "Combien y a-t-il de carrés parfaits, sauf 0, inférieurs à 200 ?";
                    button1.Text = "11 carrés parfaits";
                    button2.Text = "12 carrés parfaits";
                    button3.Text = "13 carrés parfaits";
                    button4.Text = "14 carrés parfaits";
                    reponse_correct = 4;
                    break;

                case 49:
                    label1.Text = "Éric écrit les nombres à la suite : 20, 21, 22, 23, etc. Quel sera le 20e nombre écrit ?";
                    button1.Text = "38";
                    button2.Text = "39";
                    button3.Text = "40";
                    button4.Text = "41";
                    reponse_correct = 2;
                    break;

                case 50:
                    label1.Text = "Combien un domino a-t-il de faces ?";
                    button1.Text = "2 faces";
                    button2.Text = "4 faces";
                    button3.Text = "6 faces";
                    button4.Text = "8 faces";
                    reponse_correct = 3;
                    break;

                case 51:
                    label1.Text = "Combien y a-t-il de jours entre le 2 mars et le 2 avril d’une même année ?";
                    button1.Text = "29 jours";
                    button2.Text = "30 jours";
                    button3.Text = "31 jours";
                    button4.Text = "32 jours";
                    reponse_correct = 2;
                    break;

                case 52:
                    label1.Text = "Quel est le carré qui suit 243 ?";
                    button1.Text = "254";
                    button2.Text = "255";
                    button3.Text = "256";
                    button4.Text = "257";
                    reponse_correct = 3;
                    break;

                case 53:
                    label1.Text = "Divisez mentalement 368 par 8.";
                    button1.Text = "24";
                    button2.Text = "43";
                    button3.Text = "35";
                    button4.Text = "46";
                    reponse_correct = 4;
                    break;

                case 54:
                    label1.Text = " Combien de poignées de mains seront échangées quand quatre personnes se rencontrent ?";
                    button1.Text = "2 poignées de mains";
                    button2.Text = "4 poignées de mains";
                    button3.Text = "5 poignées de mains 6 poignées de mains";
                    button4.Text = "6 poignées de mains";
                    reponse_correct = 4;
                    break;

                case 55:
                    label1.Text = "Comment s’appelle un polygone ayant 8 côtés ?";
                    button1.Text = "Octogone";
                    button2.Text = "Octagone";
                    button3.Text = "polygone";
                    button4.Text = "polygone à 8 côtés";
                    reponse_correct = 1;
                    break;

                case 56:
                    label1.Text = " Écrivez en chiffres douze mille douze cent deux.";
                    button1.Text = "12122";
                    button2.Text = "12121002";
                    button3.Text = "13 202";
                    button4.Text = "13100";
                    reponse_correct = 3;
                    break;

                case 57:
                    label1.Text = "À l’aide d’opérations, représentez 10 avec quatre 4.";
                    button1.Text = "(44 – 3) ÷ 4";
                    button2.Text = "(44 – 4) ÷ 3";
                    button3.Text = "(44 – 4) ÷ 4";
                    button4.Text = "(44 – 2) ÷ 4";
                    reponse_correct = 3;
                    break;

                case 58:
                    label1.Text = "Vrai ou faux. Quand on multiplie deux nombres, le premier est appelé multiplicande.";
                    button1.Text = "Vrai";
                    button2.Text = "faux";
                    button3.Text = "pas toujours";
                    button4.Text = "jamais";
                    reponse_correct = 1;
                    break;

                case 59:
                    label1.Text = "Trouvez la lettre qui suit logiquement dans cette suite : D, G, J, M.";
                    button1.Text = "O";
                    button2.Text = "S";
                    button3.Text = "P";
                    button4.Text = "T";
                    reponse_correct = 3;
                    break;

                case 60:
                    label1.Text = "Quel est le nombre de points d’un dé à jouer sur deux faces opposées ?";
                    button1.Text = "7 points";
                    button2.Text = "8 points";
                    button3.Text = "9 points";
                    button4.Text = "10 points";
                    reponse_correct = 1;
                    break;

                case 61:
                    label1.Text = "En quelle année a commencé le 21e siècle ?";
                    button1.Text = "1999";
                    button2.Text = "2000";
                    button3.Text = "2001";
                    button4.Text = "2002";
                    reponse_correct = 3;
                    break;

                case 62:
                    label1.Text = "En 2012, le 25 février était un samedi. Quel jour de la semaine était le 26 mars ?";
                    button1.Text = "Lundi";
                    button2.Text = "Mardi";
                    button3.Text = "Samedi";
                    button4.Text = "Dimanche";
                    reponse_correct = 1;
                    break;

                case 63:
                    label1.Text = " Quel est le nombre qui suit logiquement dans cette suite : 3, 6, 10, 15, 21 ?";
                    button1.Text = "27";
                    button2.Text = "28";
                    button3.Text = "29";
                    button4.Text = "30";
                    reponse_correct = 2;
                    break;

                case 64:
                    label1.Text = " Justine a 26 ans. Sa fille a 7 ans. Quel âge aura Justine quand elle aura le double de l’âge de sa fille ?";
                    button1.Text = "30 ans";
                    button2.Text = "33 ans";
                    button3.Text = "36 ans";
                    button4.Text = "38 ans";
                    reponse_correct = 4;
                    break;

                case 65:
                    label1.Text = " Comment s’appelle un quadrilatère qui a quatre angles droits ?";
                    button1.Text = "rectangle";
                    button2.Text = "carré";
                    button3.Text = " Carré ou rectangle";
                    button4.Text = "triangle";
                    reponse_correct = 3;
                    break;

                case 66:
                    label1.Text = " Quelle est la base de notre système de numération ?";
                    button1.Text = "2";
                    button2.Text = "10";
                    button3.Text = "8";
                    button4.Text = "16";
                    reponse_correct = 2;
                    break;

                case 67:
                    label1.Text = " Jules a 10 billes. Martine en a 5 de plus. Combien ont-ils de billes ensemble ?";
                    button1.Text = "23 billes";
                    button2.Text = "24 billes";
                    button3.Text = "25 billes";
                    button4.Text = "26 billes";
                    reponse_correct = 3;
                    break;

                case 68:
                    label1.Text = " Vous écrivez TRENTE à la suite. Combien de lettres avez-vous écrites avant d’écrire le septième E ?";
                    button1.Text = " 20 lettres";
                    button2.Text = " 21 lettres";
                    button3.Text = " 22 lettres";
                    button4.Text = " 23 lettres";
                    reponse_correct = 1;
                    break;

                case 69:
                    label1.Text = " Qu’obtient-on quand on additionne la somme de deux nombres et leur différence ?";
                    button1.Text = " Le plus grand nombre";
                    button2.Text = " Le double du plus grand nombre";
                    button3.Text = " Le triple du plus grand nombre";
                    button4.Text = " un nombre aléatoire";
                    reponse_correct = 2;
                    break;

                case 70:
                    label1.Text = " Comment s’appelle un polygone ayant 10 côtés ?";
                    button1.Text = "Octagone";
                    button2.Text = "Octogone";
                    button3.Text = " Décagone";
                    button4.Text = " Décatagone";
                    reponse_correct = 3;
                    break;

                case 71:
                    label1.Text = " Le nombre 864 est divisible par 4. En agençant les chiffres autrement, combien peut-on trouver de nombres divisibles par 4 ?";
                    button1.Text = "3 nombres : 468, 648, 684";
                    button2.Text = "3 nombres : 467, 648, 684";
                    button3.Text = "3 nombres : 468, 647, 684";
                    button4.Text = "3 nombres : 468, 648, 685";
                    reponse_correct = 1;
                    break;

                case 72:
                    label1.Text = " Combien d’allumettes a-t-on besoin pour écrire 16 en chiffres romains ?";
                    button1.Text = "2 allumettes : X";
                    button2.Text = "3 allumettes : XI";
                    button3.Text = "4 allumettes : XX";
                    button4.Text = "5 allumettes : XVI";
                    reponse_correct = 4;
                    break;

                case 73:
                    label1.Text = "Un nombre divisé par 5 est égal à ce nombre divisé par 4, moins 3. Quel est ce nombre";
                    button1.Text = "40";
                    button2.Text = "50";
                    button3.Text = "60";
                    button4.Text = "70";
                    reponse_correct = 3;
                    break;

                case 74:
                    label1.Text = " Divisez 63,45 par 100.";
                    button1.Text = "0,06345";
                    button2.Text = "0,6345";
                    button3.Text = "0,6435";
                    button4.Text = "0,6344";
                    reponse_correct = 2;
                    break;

                case 75:
                    label1.Text = " Combien un cube a-t-il de faces ?";
                    button1.Text = "3";
                    button2.Text = "4";
                    button3.Text = "5";
                    button4.Text = "6";
                    reponse_correct = 4;
                    break;

                case 76:
                    label1.Text = "On écrit les nombres de 1 à 100. Combien y a-t-il de nombres à la fois divisibles par 3 et par 5 ?";
                    button1.Text = "5 nombres : 30, 45, 60, 75, 90";
                    button2.Text = "5 nombres : 15, 30, 60, 75, 90";
                    button3.Text = "6 nombres : 15, 30, 45, 60, 75, 90";
                    button4.Text = "6 nombres : 15, 30, 45, 55, 75, 90";
                    reponse_correct = 3;
                    break;

                case 77:
                    label1.Text = " De quel nombre 16 est-il le quart ?";
                    button1.Text = "62";
                    button2.Text = "64";
                    button3.Text = "66";
                    button4.Text = "68";
                    reponse_correct = 2;
                    break;

                case 78:
                    label1.Text = " Luc et Lucie ont ensemble 100 $. Luc a 10 $ de moins que Lucie. Combien Luc a-t-il d’argent ?";
                    button1.Text = "43 $";
                    button2.Text = "44 $";
                    button3.Text = "45 $";
                    button4.Text = "46 $";
                    reponse_correct = 3;
                    break;

                case 79:
                    label1.Text = " Que vaut X si 28 + X = 82 ?";
                    button1.Text = "50";
                    button2.Text = "52";
                    button3.Text = "54";
                    button4.Text = "55";
                    reponse_correct = 3;
                    break;

                case 80:
                    label1.Text = " Comment s’appelle un quadrilatère qui a quatre côtés égaux ?";
                    button1.Text = " Carré ou losange";
                    button2.Text = " Carré ";
                    button3.Text = " losange";
                    button4.Text = " Rectangle";
                    reponse_correct = 1;
                    break;

                case 81:
                    label1.Text = "Vrai ou faux. Le nombre supérieur d’une fraction ordinaire est appelé dénominateur.";
                    button1.Text = "Vrai";
                    button2.Text = "Faux";
                    button3.Text = "oui";
                    button4.Text = "nom ";
                    reponse_correct = 2;
                    break;

                case 82:
                    label1.Text = " Quel est le plus grand nombre qui a une différence de 12 avec 559 ?";
                    button1.Text = "570";
                    button2.Text = "571";
                    button3.Text = "572";
                    button4.Text = "573";
                    reponse_correct = 2;
                    break;

                case 83:
                    label1.Text = " Quel est le nombre que l’on diminue de 21 en divisant par 4 ?";
                    button1.Text = "22";
                    button2.Text = "24";
                    button3.Text = "26";
                    button4.Text = "28";
                    reponse_correct = 4;
                    break;

                case 84:
                    label1.Text = " Quel est le nombre qui, additionné à son tiers, donne 60 ?";
                    button1.Text = "43";
                    button2.Text = "44";
                    button3.Text = "45";
                    button4.Text = "46";
                    reponse_correct = 3;
                    break;

                case 85:
                    label1.Text = " Combien un cube a-t-il de sommets ?";
                    button1.Text = "4";
                    button2.Text = "6";
                    button3.Text = "8";
                    button4.Text = "10";
                    reponse_correct = 3;
                    break;

                case 86:
                    label1.Text = "Avec les chiffres 1, 6 et 9 pris une seule fois, combien peut-on former de carrés ?";
                    button1.Text = " 2 carrés : 169 et 196 ";
                    button2.Text = " 2 carrés : 196 et 961";
                    button3.Text = " 3 carrés : 170, 196 et 961";
                    button4.Text = " 3 carrés : 169, 196 et 961";
                    reponse_correct = 4;
                    break;

                case 87:
                    label1.Text = " Combien y a-t-il de façons d’écrire trois nombres de 1 à 6 pour que leur somme soit 11 ?";
                    button1.Text = "3 façons : (2, 4, 6), (2, 3, 6), (2, 4, 5)";
                    button2.Text = "3 façons : (1, 4, 6), (2, 3, 6), (2, 4, 5)";
                    button3.Text = "3 façons : (1, 4, 6), (2, 4, 6), (2, 4, 5)";
                    button4.Text = "3 façons : (1, 4, 6), (2, 3, 6), (1, 4, 5)";
                    reponse_correct = 2;
                    break;

                case 88:
                    label1.Text = "À l’aide d’opérations, représentez 11 avec quatre 5.";
                    button1.Text = "5 + 5 + 5/5.";
                    button2.Text = "4 + 5 + 5/5.";
                    button3.Text = "3 + 5 + 5/5.";
                    button4.Text = "5 + 4 + 5/5.";
                    reponse_correct = 1;
                    break;

                case 89:
                    label1.Text = " Combien y a-t-il de douzaines dans 6000 ?";
                    button1.Text = "50 douzaines";
                    button2.Text = "501 douzaines";
                    button3.Text = "600 douzaines";
                    button4.Text = "500 douzaines";
                    reponse_correct = 4;
                    break;

                case 90:
                    label1.Text = " Comment s’appelle le polyèdre dont les faces sont des carrés ?";
                    button1.Text = "Cube";
                    button2.Text = "carré";
                    button3.Text = "polyèdre";
                    button4.Text = "losange";
                    reponse_correct = 1;
                    break;

                case 91:
                    label1.Text = " Annie prend une grille de mots croisés 12  12. Elle la découpe en parties 3 3. Combien de parties obtiendra-t-elle ?";
                    button1.Text = "15 parties";
                    button2.Text = "16 parties";
                    button3.Text = "17 parties";
                    button4.Text = "18 parties";
                    reponse_correct = 2;
                    break;
                case 92:
                    label1.Text = " Comment appelle-t-on le résultat d’une multiplication ?";
                    button1.Text = " résultat";
                    button2.Text = " multiplication";
                    button3.Text = " Produit";
                    button4.Text = "division";
                    reponse_correct = 3;
                    break;

                case 93:
                    label1.Text = " Luc divise 40 par 1/4. Quel est le résultat ?";
                    button1.Text = "160";
                    button2.Text = "161";
                    button3.Text = "162";
                    button4.Text = "163";
                    reponse_correct = 1;
                    break;

                case 94:
                    label1.Text = " Combien d’allumettes a-t-on besoin pour écrire 24 en chiffres romains ?";
                    button1.Text = "5 allumettes : XXI";
                    button2.Text = "7 allumettes : XXIV";
                    button3.Text = "6 allumettes : XXV";
                    button4.Text = "5 allumettes : XIV";
                    reponse_correct = 2;
                    break;

                case 95:
                    label1.Text = " Comment appelle-t-on deux droites qui ne se rejoignent jamais ?";
                    button1.Text = " Parallèles";
                    button2.Text = "perpendiculaires";
                    button3.Text = "egaux";
                    button4.Text = "sécantes";
                    reponse_correct = 1;
                    break;

                case 96:
                    label1.Text = " Effectuez : 48 ÷ 0,25.";
                    button1.Text = "191";
                    button2.Text = "192";
                    button3.Text = "193";
                    button4.Text = "194";
                    reponse_correct = 2;
                    break;

                case 97:
                    label1.Text = " Par quel nombre doit-on multiplier 34 pour avoir 442 ?";
                    button1.Text = "11";
                    button2.Text = "12";
                    button3.Text = "13";
                    button4.Text = "14";
                    reponse_correct = 3;
                    break;

                case 98:
                    label1.Text = " Le 2 juin 2014 était un lundi. Quel jour de la semaine était le 2 mai ?";
                    button1.Text = "Lundi";
                    button2.Text = "Dimanche";
                    button3.Text = "Samedi";
                    button4.Text = "Vendredi";
                    reponse_correct = 4;
                    break;

                case 99:
                    label1.Text = " Laurence mange deux chocolats en trois jours. Combien aura-t-elle mangé de chocolats en trois semaines ?";
                    button1.Text = "14 chocolats";
                    button2.Text = "15 chocolats";
                    button3.Text = "16 chocolats";
                    button4.Text = "17 chocolats";
                    reponse_correct = 1;
                    break;

                case 100:
                    label1.Text = " Comment appelle-t-on deux droites qui se coupent ?";
                    button1.Text = "Parallèles";
                    button2.Text = "egaux";
                    button3.Text = " Sécantes";
                    button4.Text = "Perpendiculaires";
                    reponse_correct = 3;
                    break;




            }
        }
    }
}
