using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class ScoreForm : Form
    {
        public Form BlackjackForm { get; set; }

        public ScoreForm(Form blackjackForm)
        {
            InitializeComponent();
            BlackjackForm = blackjackForm;
        }

        private void ReadXmlButton_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\Simone\Source\Repos\.NET\Blackjack\Blackjack\XML\games.xml";

            GameDataSet.ReadXml(filePath);

            dataGridView1.DataSource = GameDataSet;
            dataGridView1.DataMember = "game";
        }

        private void ShowSchemaButton_Click(object sender, EventArgs e)
        {
            StringWriter swXML = new StringWriter();
            GameDataSet.WriteXmlSchema(swXML);
            textBox1.Text = swXML.ToString();
        }

        private void ScoreForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            BlackjackForm.Show();
        }
    }
}
