using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinylMusicStore.Classes;
using VinylMusicStore.Model;

namespace VinylMusicStore.Forms
{
    public partial class LabelsForm : Form
    {
        InfoFromDB infoFromDB = new InfoFromDB();

        List<AlbumLabel> labels = new List<AlbumLabel>();

        public LabelsForm()
        {
            InitializeComponent();

            dgvLabels.Columns[0].DataPropertyName = "LabelID";
            dgvLabels.Columns[1].DataPropertyName = "LabelName";
            dgvLabels.Columns[2].DataPropertyName = "Country";

            dgvLabels.Columns[0].Visible = false;
        }

        private void LabelsForm_Load(object sender, EventArgs e)
        {
            labels = infoFromDB.GetLabels();
            dgvLabels.DataSource = labels;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewInfoElementForm addNewInfoElementForm = new AddNewInfoElementForm("Добавление лейбла", "Лейбл", "Страна");
            addNewInfoElementForm.ShowDialog();

            labels = infoFromDB.GetLabels();
            dgvLabels.DataSource = labels;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LabelsForm_Activated(object sender, EventArgs e)
        {
            labels = infoFromDB.GetLabels();
            dgvLabels.DataSource = labels;
        }
    }
}
