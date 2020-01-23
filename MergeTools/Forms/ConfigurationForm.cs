using MergeTools.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MergeTools
{
    public partial class ConfigurationForm : Form
    {
        public ConfigurationForm()
        {
            InitializeComponent();
        }
        private void ConfigurationForm_Load(object sender, EventArgs e)
        {
            batPath.Text = PathsModel.BatPath;
            logBatPath.Text = PathsModel.LogBatPath;
            tfsPath.Text = PathsModel.TfsPath;
            winmergePath.Text = PathsModel.WinmergePath;
        }

        private void ConfirmeButton_Click(object sender, EventArgs e)
        {

            if (!PathsModel.FilesExists(AllDirectorys()))
            {
                MessageBox.Show("O Arquivo possui caminhos incorretos. Para salva é necessário corrigir os caminhos.", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PathsModel.BatPath = PathsModel.FormatDirectory(batPath.Text);
                PathsModel.LogBatPath = PathsModel.FormatDirectory(logBatPath.Text);
                PathsModel.TfsPath = PathsModel.FormatDirectory(tfsPath.Text);
                PathsModel.WinmergePath = PathsModel.FormatDirectory(winmergePath.Text);

                DialogResult = DialogResult.Yes;
                Properties.Settings.Default.Save();
                CloseForm(sender, e);
            }
        }

        private void CloseForm(object sender, EventArgs e)
        {              
            Close();
        }

        private List<string> AllDirectorys()
        {
            var directorys = new List<string>
            {
                batPath.Text,
                logBatPath.Text,
                tfsPath.Text,
                winmergePath.Text
            };

            return directorys;
        }

    }
}
