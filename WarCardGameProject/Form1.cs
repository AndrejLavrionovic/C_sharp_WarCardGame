using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarCardGameProject {
    public partial class Form1 : Form {
        // Member Variables
        private const int MAX_CARDS = 52;

        private int cnt = 0;
        private int points1=0, points2=0;
        private int[] cards = new int[MAX_CARDS];
        private string[] deckOfCards = {
                                           "Ace of Clubs", "Two of Clubs", "Three of Clubs", "Four of Clubs", "Five of Clubs", "Six of Clubs",
                                           "Seven of Clubs", "Eight of Clubs", "Nine of Clubs", "Ten of Clubs", "Jack of Clubs", "Queen of Clubs", "King of Clubs",
                                           "Ace of Diamonds", "Two of Diamonds", "Three of Diamonds", "Four of Diamonds", "Five of Diamonds", "Six of Diamonds",
                                           "Seven of Diamonds", "Eight of Diamonds", "Nine of Diamonds", "Ten of Diamonds", "Jack of Diamonds", "Queen of Diamonds", "King of Diamonds",
                                           "Ace of Hearts", "Two of Hearts", "Three of Hearts", "Four of Hearts", "Five of Hearts", "Six of Hearts",
                                           "Seven of Hearts", "Eight of Hearts", "Nine of Hearts", "Ten of Hearts", "Jack of Hearts", "Queen of Hearts", "King of Hearts",
                                           "Ace of Spades", "Two of Spades", "Three of Spades", "Four of Spades", "Five of Spades", "Six of Spades",
                                           "Seven of Spades", "Eight of Spades", "Nine of Spades", "Ten of Spades", "Jack of Spades", "Queen of Spades", "King of Spades"
                                       };

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            btn_play.Visible = false;
            finalScore.Visible = false;
        }

        private void btn_exit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e) {
            FillDeck();
            player1.Text = "Player 1 ready!";
            player2.Text = "Player 2 ready!";
            btn_play.Visible = true;
            finalScore.Visible = false;
            cnt = 0;
            points1 = points2 = 0;
            score1.Text = Convert.ToString(points1);
            score2.Text = Convert.ToString(points2);
            btnStart.Visible = false;
            p1.Visible = true;
            p2.Visible = true;
        }

        private void btn_play_Click(object sender, EventArgs e) {
            int rem1, rem2;
            if(cnt < 52){
                rem1 = SelectCard(cards, cnt) % 13;
                player1.Text =deckOfCards[SelectCard(cards, cnt)-1];
                cnt++;

                rem2 = SelectCard(cards, cnt) % 13;
                player2.Text = deckOfCards[SelectCard(cards, cnt) - 1];
                cnt++;

                if(rem1 > rem2){
                    if (rem2 != 0) {
                        points1 += 2;
                        score1.Text = Convert.ToString(points1);
                    }  // if not a King
                    else {
                        points2 += 2;
                        score2.Text = Convert.ToString(points2);
                    } // if a King
                }
                else if (rem1 < rem2) {
                    if (rem1 != 0) { 
                        points2 += 2;
                        score2.Text = Convert.ToString(points2);
                    }  // if not a King
                    else {
                        points1 += 2;
                        score1.Text = Convert.ToString(points1);
                    } // if a King
                }
                else if(rem1 == rem2) {
                    points1++;
                    points2++;
                    score1.Text = Convert.ToString(points1);
                    score2.Text = Convert.ToString(points2);
                }
            }
            else {
                btnStart.Visible = true;
                btn_play.Visible = false;
                p1.Visible = false;
                p2.Visible = false;
                finalScore.Visible = true;
                fstb1.Text = Convert.ToString(points1);
                fstb2.Text = Convert.ToString(points2);
            }
        }

        //****************************************************************************************
        // Other Methods
        // FillDeck Method that places 52 unique values into this array
        public void FillDeck() {
            int i;
            for (i = 0; i < cards.Length; i++) {
                cards[i] = i + 1;
            }
            Random r = new Random();
            for (i = cards.Length; i > 0; i--) {
                int j = r.Next(i);
                int k = cards[j];
                cards[j] = cards[i - 1];
                cards[i - 1] = k;
            } // for loop
        }

        public int SelectCard(int[] c, int count) {
            int card;
            card = c[count];
            return card;
        }
    }
}
