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
    public partial class EditItem : Form {

        private ItemSlot slot;
        private Form1 parent;
        private Item item;

        public EditItem(Form1 parent, ItemSlot slot, Item item) {
            InitializeComponent();
            this.parent = parent;
            this.slot = slot;

            itemName.Text = item.Name;
            itemLevel.Text = item.Level.ToString();
            itemAttack.Text = item.Attack.ToString();


            switch (slot) {
                case ItemSlot.Weapon:
                    break;
                case ItemSlot.Helm:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            int level = 1, att = 0, matt = 0, acc = 0, crit = 0, def = 0, mdef = 0, str = 0, inte = 0, dex = 0, hp = 0;
            int.TryParse(itemLevel.Text, out level);
            int.TryParse(itemAttack.Text, out att);
            int.TryParse(itemMAttack.Text, out matt);
            int.TryParse(itemAccuracy.Text, out acc);
            int.TryParse(itemCritical.Text, out crit);
            int.TryParse(itemDefense.Text, out def);
            int.TryParse(itemMDefense.Text, out mdef);
            int.TryParse(itemStrength.Text, out str);
            int.TryParse(itemIntelligence.Text, out inte);
            int.TryParse(itemDexterity.Text, out dex);
            int.TryParse(itemHP.Text, out hp);

            item = new Item(itemName.Text, level, slot, att, matt, acc, crit, def, mdef, str, inte, dex, hp);
            parent.CreateItemAndEquip(item);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            parent.CreateItemAndEquip(null);
            this.Close();
        }
    }
}
