namespace _10._17.menus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if(topLevelMenu.Text == null ||
                topLevelMenu.Text == String.Empty)
            {
                return;
            }
            menuStrip1.Items.Add(topLevelMenu.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (topLevelMenu.Text == null ||
                topLevelMenu.Text == String.Empty ||
                menuSubItem.Text == null ||
                menuSubItem.Text==String.Empty)
            {
                return;
            }

            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                if(item.Text == topLevelMenu.Text)
                {
                    item.DropDownItems.Add(menuSubItem.Text);
                }
            }
        }
    }
}
