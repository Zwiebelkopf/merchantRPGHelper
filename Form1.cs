using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merchant_RPG {
    public partial class Form1 : Form {

        private Hero activeHero;
        private int selectedHeroList;

        public Form1() {
            InitializeComponent();
            Fill_HeroChooser();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Fill_HeroChooser() {
            foreach (KeyValuePair<string, Hero> entry in Library.Heroes2) {
                //HeroChooserValue hcv = new HeroChooserValue(Library.Heroes[i]);
                HeroChooser.Items.Add(entry.Value);
            }

            for (int i = 1; i <= 60; i++) {
                LevelPicker.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            // Plus
            if (HeroChooser.SelectedItem != null) {
                HeroList.Items.Add(Library.Heroes2[HeroChooser.SelectedItem.ToString()]);
            }

        }

        private void button2_Click(object sender, EventArgs e) {
            if (HeroList.SelectedIndex >= 0)
                HeroList.Items.RemoveAt(HeroList.SelectedIndex);
        }

        private void HeroList_SelectedIndexChanged_1(object sender, EventArgs e) {
            if (HeroList.SelectedIndex >= 0) {
                activeHero = Library.Heroes2[HeroList.SelectedItem.ToString()];
                selectedHeroList = HeroList.SelectedIndex;
                HeroNameLabel.Text = activeHero.Name;
                LevelPicker.SelectedIndex = activeHero.Level - 1;
                att_str.Text = activeHero.Strength.ToString();
                att_int.Text = activeHero.Intelligence.ToString();
                att_dex.Text = activeHero.Dexterity.ToString();
                updateStats();
            }
        }

        private void updateStats() {
            att_patk.Text = ((activeHero.Level - 1) * activeHero.LevelAttack + activeHero.StartAttack).ToString();
            att_matk.Text = ((activeHero.Level - 1) * activeHero.LevelMagicAttack + activeHero.StartMagicAttack).ToString();
            att_acc.Text = ((activeHero.Level - 1) * activeHero.LevelAccuracy + activeHero.StartAccuracy).ToString();
            att_crit.Text = ((activeHero.Level - 1) * activeHero.LevelCriticalRate + activeHero.StartCriticalRate).ToString();
            att_mdef.Text = ((activeHero.Level - 1) * activeHero.LevelMagicDefense + activeHero.StartMagicDefense).ToString();
            att_pdef.Text = ((activeHero.Level - 1) * activeHero.LevelDefense + activeHero.StartDefense).ToString();
            att_dmg.Text = (double.Parse(att_patk.Text) + double.Parse(att_matk.Text)).ToString();

        }

        private void LevelPicker_SelectedItemChanged(object sender, EventArgs e) {
            activeHero.Level = int.Parse(LevelPicker.Text);
            updateStats();
            HeroList.Items[selectedHeroList] = activeHero;
        }

        private void button3_Click(object sender, EventArgs e) {
            Hero myHero = Library.Heroes2["Warrior"];
            Monster enemy = Library.Monsters.First(x => x.Name == "Forest Gathering");
            double enemyHP = enemy.HP;
            double runden = 0;

            while (enemyHP > 0) {
                double dmg = myHero.Level * myHero.LevelAttack;
                double def = enemy.Defense;
                enemyHP -= dmg;
                runden++;
            }
            Console.WriteLine("HUHU");
        }
    }
}
