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
        private Library bibo = new Library();
        private EditItem editItem;

        public Form1() {
            InitializeComponent();
            Fill_HeroChooser();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        #region Allgemein

        private void Fill_HeroChooser() {
            foreach (Hero entry in bibo.Heroes) {
                //HeroChooserValue hcv = new HeroChooserValue(Library.Heroes[i]);
                HeroChooser.Items.Add(entry);
            }

            for (int i = 1; i <= 60; i++) {
                LevelPicker.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            // Plus
            if (HeroChooser.SelectedItem != null) {
                Hero temp = new Hero(bibo.Heroes.First(x => x.Name.Equals(HeroChooser.SelectedItem.ToString())));

                temp.Equip(bibo.Items.First(x => x.Name.Equals("Worn Weapon")));
                temp.Equip(bibo.Items.First(x => x.Name.Equals("Worn Helm")));
                temp.Equip(bibo.Items.First(x => x.Name.Equals("Worn Chest")));
                temp.Equip(bibo.Items.First(x => x.Name.Equals("Worn Gloves")));
                temp.Equip(bibo.Items.First(x => x.Name.Equals("Worn Boots")));
                temp.Equip(bibo.Items.First(x => x.Name.Equals("Worn Trinket")));

                HeroList.Items.Add(temp);
            }

        }

        private void button2_Click(object sender, EventArgs e) {
            // Minus
            if (HeroList.SelectedIndex >= 0)
                HeroList.Items.RemoveAt(HeroList.SelectedIndex);
        }

        private void button3_Click(object sender, EventArgs e) {
            Hero myHero = new Hero(bibo.Heroes.First(x => x.Name.Equals("Warrior")));
            myHero.Level = 5;
            Hero secondHero = new Hero(bibo.Heroes.First(x => x.Name.Equals("Warrior")));
            Console.WriteLine(secondHero.Level);
            /*Monster enemy = Library.Monsters.First(x => x.Name == "Forest Gathering");
            double enemyHP = enemy.HP;
            double runden = 0;

            while (enemyHP > 0) {
                double dmg = myHero.Level * myHero.LevelAttack;
                double def = enemy.Defense;
                enemyHP -= dmg;
                runden++;
            }
            Console.WriteLine("HUHU");*/
        }

        #endregion

        #region Tabpage1 => Attribute

        private void HeroList_SelectedIndexChanged_1(object sender, EventArgs e) {
            if (HeroList.SelectedIndex >= 0) {
                activeHero = (Hero)HeroList.SelectedItem;
                selectedHeroList = HeroList.SelectedIndex;
                HeroNameLabel.Text = activeHero.Name;
                LevelPicker.SelectedIndex = activeHero.Level - 1;
                att_str.Text = activeHero.Strength.ToString();
                att_int.Text = activeHero.Intelligence.ToString();
                att_dex.Text = activeHero.Dexterity.ToString();
                updateStats();
                updateEquipment();
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

        #endregion

        #region TabPage2 => Equipment

        private void updateEquipment() {
            Equip_weapon_label.Text = activeHero.Equipment[ItemSlot.Weapon].ToString() + "\n" + activeHero.Equipment[ItemSlot.Weapon].Description();
            Equip_helm_label.Text = activeHero.Equipment[ItemSlot.Helm].ToString() + "\n" + activeHero.Equipment[ItemSlot.Helm].Description();
            Equip_chest_label.Text = activeHero.Equipment[ItemSlot.Chest].ToString() + "\n" + activeHero.Equipment[ItemSlot.Chest].Description();
            Equip_gloves_label.Text = activeHero.Equipment[ItemSlot.Gloves].ToString() + "\n" + activeHero.Equipment[ItemSlot.Gloves].Description();
            Equip_boots_label.Text = activeHero.Equipment[ItemSlot.Boots].ToString() + "\n" + activeHero.Equipment[ItemSlot.Boots].Description();
            Equip_trinket_label.Text = activeHero.Equipment[ItemSlot.Trinket].ToString() + "\n" + activeHero.Equipment[ItemSlot.Trinket].Description();
        }

        private void button4_Click(object sender, EventArgs e) {
            // Change Weapon
            Equip_weapon_label.Text = "Dies ist ein langer Text um zu prüfen,\nwas genau das Programm damit macht.";
            editItem = new EditItem(this, ItemSlot.Weapon, activeHero.Equipment[ItemSlot.Weapon]);
            editItem.Show();
        }
        private void button5_Click(object sender, EventArgs e) {
            // Change Helm
            editItem = new EditItem(this, ItemSlot.Helm, activeHero.Equipment[ItemSlot.Helm]);
            editItem.Show();
        }
        
        private void button6_Click(object sender, EventArgs e) {
            // Change Chest
            editItem = new EditItem(this, ItemSlot.Chest, activeHero.Equipment[ItemSlot.Chest]);
            editItem.Show();
        }

        private void button7_Click(object sender, EventArgs e) {
            // Change Gloves
            editItem = new EditItem(this, ItemSlot.Gloves, activeHero.Equipment[ItemSlot.Gloves]);
            editItem.Show();
        }

        private void button8_Click(object sender, EventArgs e) {
            // Change Boots
            editItem = new EditItem(this, ItemSlot.Boots, activeHero.Equipment[ItemSlot.Boots]);
            editItem.Show();
        }

        private void button9_Click(object sender, EventArgs e) {
            // Change Trinket
            editItem = new EditItem(this, ItemSlot.Trinket, activeHero.Equipment[ItemSlot.Trinket]);
            editItem.Show();
            HeroList.Enabled = false;
        }

        public void CreateItemAndEquip(Item item) {
            if (item != null) {
                activeHero.Equip(item);
                updateEquipment();
            }
            HeroList.Enabled = true;
        }

        #endregion

        

       

    }
}
